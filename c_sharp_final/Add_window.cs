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
        public event EventHandler call_back;

        public string[] data;

        public Add_window()
        {
            InitializeComponent();
            data = new string[5] { "", "", "", "", "" };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data = new string[5] { "0", "", "", "", "" };
            this.Hide();
            call_back?.Invoke(sender, e);
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            data = new string[5] { "1", "", "", "", "" };
            data[1] = time_input.Text;
            data[2] = amount_input.Text;
            data[3] = tag_chooser.Text;
            data[4] = text_input.Text;
            this.Hide();
            call_back?.Invoke(sender, e);
        }
    }
}
