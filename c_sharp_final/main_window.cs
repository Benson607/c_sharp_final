using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_final
{
    public partial class main_window : Form
    {

        private TransactionManager trans_manager;

        private Button[] button_arr;
        private int show_mode;

        int year_now;
        int month_now;
        int day_now;

        int year_choose;
        int month_choose;
        int day_choose;

        int total_in;
        int total_out;

        FormLogin login_window;
        FormRegister register_window;

        Add_window add_window;

        public main_window()
        {
            InitializeComponent();

            mask.Location = new Point(10, 10);
            mask.Size = new Size(1352, 652);

            trans_manager = new TransactionManager();

            login_window = new FormLogin();
            register_window = new FormRegister();

            login_window.to_register += to_register;
            login_window.access += access;
            register_window.to_login += to_login;

            register_window.Show();

            add_window = new Add_window();
            add_window.call_back += add_call_back;

            show_mode = 0;
            
            DateTime now = DateTime.Now;
            year_now = Convert.ToInt32(now.ToString("yyyy"));
            month_now = Convert.ToInt32(now.ToString("MM"));
            day_now = Convert.ToInt32(now.ToString("dd"));
            year_choose = year_now;
            month_choose = month_now;
            day_choose = 0;

            month_box.Text = $"{year_now.ToString()} 年 {month_now.ToString()} 月";
            
            total_in = 0;
            total_out = 0;
            
            set_day_button();
            update_button();
            update_month();
        }

        private void set_day_button()
        {
            button_arr = new Button[42];
            int margin = 5;
            int width = 60;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Button button = new Button
                    {
                        Text = "",
                        Width = width,
                        Height = width,
                        Left = j * (width + margin) + 5,
                        Top = i * (width + margin) + 5
                    };
                    button.Click += day_button_click;
                    button_panel.Controls.Add(button);
                    button_arr[i * 7 + j] = button;
                }
            }
        }

        private void update_button()
        {
            day_choose = 0;
            int[] days_for_month = { 0, 31, 28 + Convert.ToInt32(year_choose % 4 == 0 && year_choose % 100 != 0 || year_choose % 4 == 0 && year_choose % 400 == 0), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int j = 1;
            int first_day = (int)new DateTime(year_choose, month_choose, 1).DayOfWeek + 1;
            for (int i = 0; i < 42; i++)
            {
                button_arr[i].BackColor = Color.White;
                if (j >= first_day && j - first_day + 1 <= days_for_month[Convert.ToInt32(month_choose)])
                {
                    button_arr[i].Text = (j - first_day + 1).ToString();
                }
                else
                {
                    button_arr[i].Text = "";
                }
                j++;
            }
        }

        private void day_button_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "")
            {
                return;
            }
            if (day_choose > 0)
            {
                button_arr[day_choose + (int)new DateTime(year_choose, month_choose, 1).DayOfWeek - 1].BackColor = Color.White;
            }
            day_choose = Convert.ToInt32(button.Text);
            button_arr[day_choose + (int)new DateTime(year_choose, month_choose, 1).DayOfWeek - 1].BackColor = Color.FromArgb(116, 86, 174);

            update_day_list();
        }

        private void update_day_list()
        {
            trans_manager.ChangeDate(new DateTime(year_choose, month_choose, day_choose));
            List<Transaction> transactions = trans_manager.Transactions;

            switch (tag_chooser.Text)
            {
                case "伙食費":
                    transactions = TransactionManager.Filter(transactions, TransactionTag.FOOD);
                    break;
                case "交通費":
                    transactions = TransactionManager.Filter(transactions, TransactionTag.TRANSPORTATION);
                    break;
                case "娛樂費":
                    transactions = TransactionManager.Filter(transactions, TransactionTag.ENTERTAINMENT);
                    break;
                case "生活用品費":
                    transactions = TransactionManager.Filter(transactions, TransactionTag.DAILY);
                    break;
                case "其他費用":
                    transactions = TransactionManager.Filter(transactions, TransactionTag.OTHER);
                    break;
                default:
                    break;
            }

            switch (show_mode)
            {
                case 1:
                    transactions = TransactionManager.Filter(transactions, TransactionType.INCOME);
                    break;
                case 2:
                    transactions = TransactionManager.Filter(transactions, TransactionType.OUTCOME);
                    break;
                default:
                    break;
            }

            data_list_box.Items.Clear();
            foreach (var trans in transactions)
            {
                data_list_box.Items.Add($"{trans.Time} - {trans.Desc} - {trans.Amount} - {trans.Tag} - {trans.Type}");
            }
        }

        private void update_month()
        {
            Dictionary<DateTime, List<Transaction>> month_trans = TransactionManager.GetMonthTransactions(new DateTime(year_choose, month_choose, 1));
            month_data_box.Items.Clear();
            month_income_data_box.Items.Clear();
            total_in = 0;
            total_out = 0;
            foreach (var month_tran in month_trans)
            {
                foreach (var trans in month_tran.Value)
                {
                    if (trans.Type == TransactionType.INCOME)
                    {
                        month_income_data_box.Items.Add($"{month_tran.Key.ToString("dd")} - {trans.Time} - {trans.Desc} - {trans.Amount} - {trans.Tag}");
                        total_in += trans.Amount;
                    }
                    if (trans.Type == TransactionType.OUTCOME)
                    {
                        month_data_box.Items.Add($"{month_tran.Key.ToString("dd")} - {trans.Time} - {trans.Desc} - {trans.Amount} - {trans.Tag}");
                        total_out += trans.Amount;
                    }
                }
            }
            income_text.Text = $"本月總收入: {total_in.ToString()}";
            outcome_text.Text = $"本月總支出: {total_out.ToString()}";
        }

        private void income_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (day_choose == 0)
            {
                return;
            }
            update_day_list();
        }

        private void month_data_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void day_button1_Click(object sender, EventArgs e)
        {

        }

        private void in_out_switch_Click(object sender, EventArgs e)
        {
            show_mode++;
            if (show_mode == 3)
            {
                show_mode = 0;
            }
            if (show_mode == 0)
            {
                in_out_switch.Text = "顯示條件:不限";
            }
            else if (show_mode == 1)
            {
                in_out_switch.Text = "顯示條件:僅收入";
            }
            else if (show_mode == 2)
            {
                in_out_switch.Text = "顯示條件:僅支出";
            }
            if (day_choose == 0)
            {
                return;
            }
            update_day_list();
        }

        private void month_up_button_Click(object sender, EventArgs e)
        {
            month_choose++;
            if (month_choose == 13)
            {
                month_choose = 1;
                year_choose++;
            }
            month_box.Text = $"{year_choose.ToString()} 年 {month_choose.ToString()} 月";
            data_list_box.Items.Clear();
            update_button();
            update_month();
        }

        private void month_down_button_Click(object sender, EventArgs e)
        {
            month_choose--;
            if (month_choose == 0)
            {
                month_choose = 12;
                year_choose--;
            }
            month_box.Text = $"{year_choose.ToString()} 年 {month_choose.ToString()} 月";
            data_list_box.Items.Clear();
            update_button();
            update_month();
        }

        private void to_login(Object sender, EventArgs e)
        {
            register_window.Hide();
            login_window.Show();
        }

        private void to_register(Object sender, EventArgs e)
        {
            login_window.Hide();
            register_window.Show();
        }

        private void access(Object sender, EventArgs e)
        {
            login_window.Hide();
            register_window.Hide();
            mask.Hide();
        }

        private void add_call_back(Object sender, EventArgs e)
        {
            for (int i = 0; i < 42; i++)
            {
                button_arr[i].Enabled = true;
            }
            month_up_button.Enabled = true;
            month_down_button.Enabled = true;
            in_out_switch.Enabled = true;
            tag_chooser.Enabled = true;
            del_button.Enabled = true;
            add_button.Enabled = true;
            month_data_box.Enabled = true;
            data_list_box.Enabled = true;
            
            if (add_window.data[0] == "0")
            {
                return;
            }

            Transaction new_item = default(Transaction);
            new_item.Time = new TimeSpan(Convert.ToInt32(add_window.data[1]), Convert.ToInt32(add_window.data[2]), 0);
            new_item.Desc = add_window.data[3];
            new_item.Amount = Convert.ToInt32(add_window.data[4]);
            new_item.Type = (TransactionType)Convert.ToInt32(add_window.data[5]);
            new_item.Tag = (TransactionTag)Convert.ToInt32(add_window.data[6]);

            trans_manager.AppendTransaction(new_item);
            update_month();
            update_day_list();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (day_choose == 0)
            {
                return;
            }
            string select = data_list_box.SelectedItem as string;
            if (select != null)
            {
                string[] del_item = select.Split(new string[] { " - " }, StringSplitOptions.None);
                string[] date = del_item[0].Split(new string[] { ":" }, StringSplitOptions.None);

                Transaction del_transaction = default(Transaction);
                del_transaction.Time = new TimeSpan(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
                del_transaction.Desc = del_item[1];
                del_transaction.Amount = Convert.ToInt32(del_item[2]);

                if (del_item[4] == "INCOME")
                {
                    del_transaction.Type = TransactionType.INCOME;
                }
                else
                {
                    del_transaction.Type = TransactionType.OUTCOME;
                }

                switch (del_item[3])
                {
                    case "FOOD":
                        del_transaction.Tag = TransactionTag.FOOD;
                        break;
                    case "TRANSPORTATION":
                        del_transaction.Tag = TransactionTag.TRANSPORTATION;
                        break;
                    case "ENTERTAINMENT":
                        del_transaction.Tag = TransactionTag.ENTERTAINMENT;
                        break;
                    case "DAILY":
                        del_transaction.Tag = TransactionTag.DAILY;
                        break;
                    case "OTHER":
                        del_transaction.Tag = TransactionTag.OTHER;
                        break;
                    default:
                        break;
                }
                
                trans_manager.DeleteTransaction(del_transaction);
                
                update_day_list();
                update_month();
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (day_choose == 0)
            {
                return;
            }
            for (int i = 0; i < 42; i++)
            {
                button_arr[i].Enabled = false;
            }
            month_up_button.Enabled = false;
            month_down_button.Enabled = false;
            in_out_switch.Enabled = false;
            tag_chooser.Enabled = false;
            del_button.Enabled = false;
            add_button.Enabled = false;
            month_data_box.Enabled = false;
            data_list_box.Enabled = false;
            add_window.Show();
        }
    }
}
