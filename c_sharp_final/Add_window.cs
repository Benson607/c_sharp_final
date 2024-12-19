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
    public partial class Add_window : Form
    {
        private int in_out_status;

        public event EventHandler call_back;

        public string[] data;

        public Add_window()
        {
            InitializeComponent();
            data = new string[5] { "", "", "", "", "" };
            in_out_status = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data = new string[1] { "0" };
            this.Hide();
            call_back?.Invoke(sender, e);
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            data = new string[7] { "1", hour_input.Text, minute_input.Text, text_input.Text, amount_input.Text, in_out_status.ToString(), "" };
            switch (tag_chooser.Text)
            {
                case "伙食費":
                    data[6] = "0";
                    break;
                case "交通費":
                    data[6] = "1";
                    break;
                case "娛樂費":
                    data[6] = "2";
                    break;
                case "生活用品費":
                    data[6] = "3";
                    break;
                case "其他費用":
                    data[6] = "4";
                    break;
            }
            this.Hide();
            call_back?.Invoke(sender, e);
        }

        private void in_out_choose_button_Click(object sender, EventArgs e)
        {
            if (in_out_status == 0)
            {
                in_out_choose_button.Text = "支出";
                in_out_status = 1;
            }
            else
            {
                in_out_choose_button.Text = "收入";
                in_out_status = 0;
            }
        }
    }
}
