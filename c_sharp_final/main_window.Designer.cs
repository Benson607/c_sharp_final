
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
            this.month_data_box = new System.Windows.Forms.ListView();
            this.income_text = new System.Windows.Forms.Label();
            this.outcome_text = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.data_list_box = new System.Windows.Forms.ListBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.check_button = new System.Windows.Forms.Button();
            this.month_down_button = new System.Windows.Forms.Button();
            this.month_up_button = new System.Windows.Forms.Button();
            this.year_box = new System.Windows.Forms.Label();
            this.month_box = new System.Windows.Forms.Label();
            this.in_out_switch = new System.Windows.Forms.Button();
            this.button_panel = new System.Windows.Forms.Panel();
            this.month_data_box = new System.Windows.Forms.ListBox();
            this.mask = new System.Windows.Forms.Label();
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
            // month_data_box
            // 
            this.month_data_box.HideSelection = false;
            this.month_data_box.Location = new System.Drawing.Point(506, 10);
            this.month_data_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.month_data_box.Name = "month_data_box";
            this.month_data_box.Size = new System.Drawing.Size(260, 642);
            this.month_data_box.TabIndex = 1;
            this.month_data_box.UseCompatibleStateImageBehavior = false;
            this.month_data_box.SelectedIndexChanged += new System.EventHandler(this.month_data_box_SelectedIndexChanged);
            // 
            // income_text
            // 
            this.income_text.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.income_text.Font = new System.Drawing.Font("新細明體", 30F);
            this.income_text.Location = new System.Drawing.Point(770, 10);
            this.income_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.income_text.Name = "income_text";
            this.income_text.Size = new System.Drawing.Size(582, 68);
            this.income_text.TabIndex = 2;
            this.income_text.Text = "income";
            this.income_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.income_text.Click += new System.EventHandler(this.income_Click);
            // 
            // outcome_text
            // 
            this.outcome_text.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.outcome_text.Font = new System.Drawing.Font("新細明體", 30F);
            this.outcome_text.Location = new System.Drawing.Point(770, 86);
            this.outcome_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outcome_text.Name = "outcome_text";
            this.outcome_text.Size = new System.Drawing.Size(581, 70);
            this.outcome_text.TabIndex = 3;
            this.outcome_text.Text = "outcome";
            this.outcome_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outcome_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(770, 158);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(582, 494);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 20F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(950, 187);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 35);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // data_list_box
            // 
            this.data_list_box.FormattingEnabled = true;
            this.data_list_box.ItemHeight = 12;
            this.data_list_box.Location = new System.Drawing.Point(788, 238);
            this.data_list_box.Margin = new System.Windows.Forms.Padding(2);
            this.data_list_box.Name = "data_list_box";
            this.data_list_box.Size = new System.Drawing.Size(423, 400);
            this.data_list_box.TabIndex = 7;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(1214, 449);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(117, 85);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // check_button
            // 
            this.check_button.Location = new System.Drawing.Point(1214, 538);
            this.check_button.Margin = new System.Windows.Forms.Padding(2);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(117, 85);
            this.check_button.TabIndex = 9;
            this.check_button.Text = "check";
            this.check_button.UseVisualStyleBackColor = true;
            // 
            // month_down_button
            // 
            this.month_down_button.Location = new System.Drawing.Point(80, 86);
            this.month_down_button.Name = "month_down_button";
            this.month_down_button.Size = new System.Drawing.Size(75, 23);
            this.month_down_button.TabIndex = 10;
            this.month_down_button.Text = "<<<";
            this.month_down_button.UseVisualStyleBackColor = true;
            this.month_down_button.Click += new System.EventHandler(this.month_down_button_Click);
            // 
            // month_up_button
            // 
            this.month_up_button.Location = new System.Drawing.Point(359, 86);
            this.month_up_button.Name = "month_up_button";
            this.month_up_button.Size = new System.Drawing.Size(75, 23);
            this.month_up_button.TabIndex = 11;
            this.month_up_button.Text = ">>>";
            this.month_up_button.UseVisualStyleBackColor = true;
            this.month_up_button.Click += new System.EventHandler(this.month_up_button_Click);
            // 
            // year_box
            // 
            this.year_box.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.year_box.Font = new System.Drawing.Font("新細明體", 30F);
            this.year_box.Location = new System.Drawing.Point(207, 37);
            this.year_box.Name = "year_box";
            this.year_box.Size = new System.Drawing.Size(97, 41);
            this.year_box.TabIndex = 54;
            this.year_box.Text = "2024";
            this.year_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // month_box
            // 
            this.month_box.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.month_box.Font = new System.Drawing.Font("新細明體", 30F);
            this.month_box.Location = new System.Drawing.Point(207, 115);
            this.month_box.Name = "month_box";
            this.month_box.Size = new System.Drawing.Size(97, 41);
            this.month_box.TabIndex = 55;
            this.month_box.Text = "1";
            this.month_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // in_out_switch
            // 
            this.in_out_switch.Font = new System.Drawing.Font("新細明體", 12F);
            this.in_out_switch.Location = new System.Drawing.Point(788, 187);
            this.in_out_switch.Margin = new System.Windows.Forms.Padding(2);
            this.in_out_switch.Name = "in_out_switch";
            this.in_out_switch.Size = new System.Drawing.Size(133, 33);
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
            this.month_data_box.Location = new System.Drawing.Point(509, 10);
            this.month_data_box.MultiColumn = true;
            this.month_data_box.Name = "month_data_box";
            this.month_data_box.Size = new System.Drawing.Size(256, 640);
            this.month_data_box.TabIndex = 59;
            // 
            // mask
            // 
            this.mask.Enabled = false;
            this.mask.Location = new System.Drawing.Point(10, 9);
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(1342, 644);
            this.mask.TabIndex = 60;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1358, 663);
            this.Controls.Add(this.mask);
            this.Controls.Add(this.month_data_box);
            this.Controls.Add(this.button_panel);
            this.Controls.Add(this.in_out_switch);
            this.Controls.Add(this.month_box);
            this.Controls.Add(this.year_box);
            this.Controls.Add(this.month_up_button);
            this.Controls.Add(this.month_down_button);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.data_list_box);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.outcome_text);
            this.Controls.Add(this.income_text);
            this.Controls.Add(this.month_data_box);
            this.Controls.Add(this.date_box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main_window";
            this.Text = "個人收支計算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView date_box;
        private System.Windows.Forms.ListView month_data_box;
        private System.Windows.Forms.Label income_text;
        private System.Windows.Forms.Label outcome_text;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox data_list_box;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Button month_down_button;
        private System.Windows.Forms.Button month_up_button;
        private System.Windows.Forms.Label year_box;
        private System.Windows.Forms.Label month_box;
        private System.Windows.Forms.Button in_out_switch;
        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.ListBox month_data_box;
        private System.Windows.Forms.Label mask;
    }
}

