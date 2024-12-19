
namespace c_sharp_final
{
    partial class main_window
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.date_box = new System.Windows.Forms.ListView();
            this.income_text = new System.Windows.Forms.Label();
            this.outcome_text = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tag_chooser = new System.Windows.Forms.ComboBox();
            this.data_list_box = new System.Windows.Forms.ListBox();
            this.del_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.month_down_button = new System.Windows.Forms.Button();
            this.month_up_button = new System.Windows.Forms.Button();
            this.year_box = new System.Windows.Forms.Label();
            this.month_box = new System.Windows.Forms.Label();
            this.in_out_switch = new System.Windows.Forms.Button();
            this.button_panel = new System.Windows.Forms.Panel();
            this.month_data_box = new System.Windows.Forms.ListBox();
            this.mask = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.month_income_data_box = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date_box
            // 
            this.date_box.HideSelection = false;
            this.date_box.Location = new System.Drawing.Point(10, 10);
            this.date_box.Margin = new System.Windows.Forms.Padding(2);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(494, 642);
            this.date_box.TabIndex = 0;
            this.date_box.UseCompatibleStateImageBehavior = false;
            this.date_box.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // income_text
            // 
            this.income_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.income_text.Font = new System.Drawing.Font("新細明體", 20F);
            this.income_text.ForeColor = System.Drawing.Color.White;
            this.income_text.Location = new System.Drawing.Point(508, 10);
            this.income_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.income_text.Name = "income_text";
            this.income_text.Size = new System.Drawing.Size(365, 36);
            this.income_text.TabIndex = 2;
            this.income_text.Text = "income";
            this.income_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.income_text.Click += new System.EventHandler(this.income_Click);
            // 
            // outcome_text
            // 
            this.outcome_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.outcome_text.Font = new System.Drawing.Font("新細明體", 20F);
            this.outcome_text.ForeColor = System.Drawing.Color.White;
            this.outcome_text.Location = new System.Drawing.Point(509, 238);
            this.outcome_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outcome_text.Name = "outcome_text";
            this.outcome_text.Size = new System.Drawing.Size(365, 37);
            this.outcome_text.TabIndex = 3;
            this.outcome_text.Text = "outcome";
            this.outcome_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outcome_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(878, 10);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(337, 642);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tag_chooser
            // 
            this.tag_chooser.Font = new System.Drawing.Font("新細明體", 20F);
            this.tag_chooser.FormattingEnabled = true;
            this.tag_chooser.Items.AddRange(new object[] {
            "未選擇",
            "伙食費",
            "交通費",
            "娛樂費",
            "生活用品費",
            "其他費用"});
            this.tag_chooser.Location = new System.Drawing.Point(1072, 26);
            this.tag_chooser.Margin = new System.Windows.Forms.Padding(2);
            this.tag_chooser.Name = "tag_chooser";
            this.tag_chooser.Size = new System.Drawing.Size(129, 35);
            this.tag_chooser.TabIndex = 5;
            this.tag_chooser.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // data_list_box
            // 
            this.data_list_box.FormattingEnabled = true;
            this.data_list_box.ItemHeight = 12;
            this.data_list_box.Location = new System.Drawing.Point(890, 115);
            this.data_list_box.Margin = new System.Windows.Forms.Padding(2);
            this.data_list_box.Name = "data_list_box";
            this.data_list_box.Size = new System.Drawing.Size(311, 412);
            this.data_list_box.TabIndex = 7;
            // 
            // del_button
            // 
            this.del_button.Font = new System.Drawing.Font("新細明體", 20F);
            this.del_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.del_button.Location = new System.Drawing.Point(890, 545);
            this.del_button.Margin = new System.Windows.Forms.Padding(2);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(133, 85);
            this.del_button.TabIndex = 8;
            this.del_button.Text = "刪除";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("新細明體", 20F);
            this.add_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.add_button.Location = new System.Drawing.Point(1072, 545);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(129, 85);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "新增";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // month_down_button
            // 
            this.month_down_button.Location = new System.Drawing.Point(75, 115);
            this.month_down_button.Name = "month_down_button";
            this.month_down_button.Size = new System.Drawing.Size(75, 23);
            this.month_down_button.TabIndex = 10;
            this.month_down_button.Text = "<<<";
            this.month_down_button.UseVisualStyleBackColor = true;
            this.month_down_button.Click += new System.EventHandler(this.month_down_button_Click);
            // 
            // month_up_button
            // 
            this.month_up_button.Location = new System.Drawing.Point(358, 115);
            this.month_up_button.Name = "month_up_button";
            this.month_up_button.Size = new System.Drawing.Size(75, 23);
            this.month_up_button.TabIndex = 11;
            this.month_up_button.Text = ">>>";
            this.month_up_button.UseVisualStyleBackColor = true;
            this.month_up_button.Click += new System.EventHandler(this.month_up_button_Click);
            // 
            // year_box
            // 
            this.year_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.year_box.Font = new System.Drawing.Font("新細明體", 30F);
            this.year_box.ForeColor = System.Drawing.Color.White;
            this.year_box.Location = new System.Drawing.Point(207, 37);
            this.year_box.Name = "year_box";
            this.year_box.Size = new System.Drawing.Size(97, 41);
            this.year_box.TabIndex = 54;
            this.year_box.Text = "日曆";
            this.year_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // month_box
            // 
            this.month_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.month_box.Font = new System.Drawing.Font("新細明體", 20F);
            this.month_box.ForeColor = System.Drawing.Color.White;
            this.month_box.Location = new System.Drawing.Point(156, 105);
            this.month_box.Name = "month_box";
            this.month_box.Size = new System.Drawing.Size(196, 33);
            this.month_box.TabIndex = 55;
            this.month_box.Text = "1";
            this.month_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // in_out_switch
            // 
            this.in_out_switch.Font = new System.Drawing.Font("新細明體", 12F);
            this.in_out_switch.Location = new System.Drawing.Point(895, 26);
            this.in_out_switch.Margin = new System.Windows.Forms.Padding(2);
            this.in_out_switch.Name = "in_out_switch";
            this.in_out_switch.Size = new System.Drawing.Size(133, 35);
            this.in_out_switch.TabIndex = 56;
            this.in_out_switch.Text = "顯示條件:不限";
            this.in_out_switch.UseVisualStyleBackColor = true;
            this.in_out_switch.Click += new System.EventHandler(this.in_out_switch_Click);
            // 
            // button_panel
            // 
            this.button_panel.Location = new System.Drawing.Point(29, 211);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(460, 399);
            this.button_panel.TabIndex = 57;
            // 
            // month_data_box
            // 
            this.month_data_box.FormattingEnabled = true;
            this.month_data_box.ItemHeight = 12;
            this.month_data_box.Location = new System.Drawing.Point(509, 277);
            this.month_data_box.Margin = new System.Windows.Forms.Padding(2);
            this.month_data_box.MultiColumn = true;
            this.month_data_box.Name = "month_data_box";
            this.month_data_box.Size = new System.Drawing.Size(364, 376);
            this.month_data_box.TabIndex = 59;
            this.month_data_box.SelectedIndexChanged += new System.EventHandler(this.month_data_box_SelectedIndexChanged);
            // 
            // mask
            // 
            this.mask.Enabled = false;
            this.mask.Location = new System.Drawing.Point(562, 115);
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(100, 100);
            this.mask.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sun";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 37);
            this.label2.TabIndex = 61;
            this.label2.Text = "Mon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(166, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 37);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label4.Font = new System.Drawing.Font("新細明體", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(230, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 37);
            this.label4.TabIndex = 63;
            this.label4.Text = "Wed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label5.Font = new System.Drawing.Font("新細明體", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(294, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 37);
            this.label5.TabIndex = 64;
            this.label5.Text = "Thu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Font = new System.Drawing.Font("新細明體", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(358, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 37);
            this.label6.TabIndex = 65;
            this.label6.Text = "Fri";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label7.Font = new System.Drawing.Font("新細明體", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(422, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 37);
            this.label7.TabIndex = 66;
            this.label7.Text = "Sat";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // month_income_data_box
            // 
            this.month_income_data_box.FormattingEnabled = true;
            this.month_income_data_box.ItemHeight = 12;
            this.month_income_data_box.Location = new System.Drawing.Point(509, 48);
            this.month_income_data_box.Margin = new System.Windows.Forms.Padding(2);
            this.month_income_data_box.MultiColumn = true;
            this.month_income_data_box.Name = "month_income_data_box";
            this.month_income_data_box.Size = new System.Drawing.Size(364, 184);
            this.month_income_data_box.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label8.Font = new System.Drawing.Font("新細明體", 20F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(890, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 37);
            this.label8.TabIndex = 68;
            this.label8.Text = "當日收支明細";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1227, 661);
            this.Controls.Add(this.mask);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_panel);
            this.Controls.Add(this.in_out_switch);
            this.Controls.Add(this.month_box);
            this.Controls.Add(this.year_box);
            this.Controls.Add(this.month_up_button);
            this.Controls.Add(this.month_down_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.data_list_box);
            this.Controls.Add(this.tag_chooser);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.outcome_text);
            this.Controls.Add(this.income_text);
            this.Controls.Add(this.month_data_box);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.month_income_data_box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main_window";
            this.Text = "個人收支計算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView date_box;
        private System.Windows.Forms.Label income_text;
        private System.Windows.Forms.Label outcome_text;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox tag_chooser;
        private System.Windows.Forms.ListBox data_list_box;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button month_down_button;
        private System.Windows.Forms.Button month_up_button;
        private System.Windows.Forms.Label year_box;
        private System.Windows.Forms.Label month_box;
        private System.Windows.Forms.Button in_out_switch;
        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.ListBox month_data_box;
        private System.Windows.Forms.Label mask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox month_income_data_box;
        private System.Windows.Forms.Label label8;
    }
}

