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
        private Button[] button_arr;
        private int show_mode;

        int year_now;
        int month_now;
        int day_now;

        int year_choose;
        int month_choose;
        int day_choose;

        FormLogin login_window;
        FormRegister register_window;

        public main_window()
        {
            InitializeComponent();

            login_window = new FormLogin();
            register_window = new FormRegister();

            login_window.to_register += to_register;
            login_window.access += access;
            register_window.to_login += to_login;

            register_window.Show();
            
            show_mode = 0;
            
            DateTime now = DateTime.Now;
            year_now = Convert.ToInt32(now.ToString("yyyy"));
            month_now = Convert.ToInt32(now.ToString("MM"));
            day_now = Convert.ToInt32(now.ToString("dd"));
            year_choose = year_now;
            month_choose = month_now;
            day_choose = 0;

            year_box.Text = year_now.ToString();
            month_box.Text = month_now.ToString();
            
            set_day_button();
            update_button();
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
            button_arr[day_choose + (int)new DateTime(year_choose, month_choose, 1).DayOfWeek - 1].BackColor = Color.Red;
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
        }

        private void month_up_button_Click(object sender, EventArgs e)
        {
            month_choose++;
            if (month_choose == 13)
            {
                month_choose = 1;
                year_choose++;
                year_box.Text = year_choose.ToString();
            }
            month_box.Text = month_choose.ToString();
            update_button();
        }

        private void month_down_button_Click(object sender, EventArgs e)
        {
            month_choose--;
            if (month_choose == 0)
            {
                month_choose = 12;
                year_choose--;
                year_box.Text = year_choose.ToString();
            }
            month_box.Text = month_choose.ToString();
            update_button();
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
    }
}
