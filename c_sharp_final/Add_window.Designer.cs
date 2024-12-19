
namespace c_sharp_final
{
    partial class Add_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hour_input = new System.Windows.Forms.TextBox();
            this.amount_input = new System.Windows.Forms.TextBox();
            this.tag_chooser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_input = new System.Windows.Forms.TextBox();
            this.check_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.in_out_choose_button = new System.Windows.Forms.Button();
            this.minute_input = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "時";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "金額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "標籤";
            // 
            // hour_input
            // 
            this.hour_input.Location = new System.Drawing.Point(14, 24);
            this.hour_input.Name = "hour_input";
            this.hour_input.Size = new System.Drawing.Size(49, 22);
            this.hour_input.TabIndex = 3;
            // 
            // amount_input
            // 
            this.amount_input.Location = new System.Drawing.Point(120, 24);
            this.amount_input.Name = "amount_input";
            this.amount_input.Size = new System.Drawing.Size(100, 22);
            this.amount_input.TabIndex = 4;
            // 
            // tag_chooser
            // 
            this.tag_chooser.FormattingEnabled = true;
            this.tag_chooser.Items.AddRange(new object[] {
            "伙食費",
            "交通費",
            "娛樂費",
            "生活用品費",
            "其他費用"});
            this.tag_chooser.Location = new System.Drawing.Point(226, 24);
            this.tag_chooser.Name = "tag_chooser";
            this.tag_chooser.Size = new System.Drawing.Size(100, 20);
            this.tag_chooser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "說明";
            // 
            // text_input
            // 
            this.text_input.Location = new System.Drawing.Point(14, 81);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(312, 22);
            this.text_input.TabIndex = 7;
            // 
            // check_button
            // 
            this.check_button.Location = new System.Drawing.Point(397, 95);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(75, 23);
            this.check_button.TabIndex = 8;
            this.check_button.Text = "確認";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(397, 66);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // in_out_choose_button
            // 
            this.in_out_choose_button.Location = new System.Drawing.Point(332, 24);
            this.in_out_choose_button.Name = "in_out_choose_button";
            this.in_out_choose_button.Size = new System.Drawing.Size(75, 20);
            this.in_out_choose_button.TabIndex = 10;
            this.in_out_choose_button.Text = "收入";
            this.in_out_choose_button.UseVisualStyleBackColor = true;
            this.in_out_choose_button.Click += new System.EventHandler(this.in_out_choose_button_Click);
            // 
            // minute_input
            // 
            this.minute_input.Location = new System.Drawing.Point(64, 24);
            this.minute_input.Name = "minute_input";
            this.minute_input.Size = new System.Drawing.Size(50, 22);
            this.minute_input.TabIndex = 11;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(62, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(17, 12);
            this.label.TabIndex = 12;
            this.label.Text = "分";
            // 
            // Add_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 130);
            this.Controls.Add(this.label);
            this.Controls.Add(this.minute_input);
            this.Controls.Add(this.in_out_choose_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.text_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tag_chooser);
            this.Controls.Add(this.amount_input);
            this.Controls.Add(this.hour_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_window";
            this.Text = "add_window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hour_input;
        private System.Windows.Forms.TextBox amount_input;
        private System.Windows.Forms.ComboBox tag_chooser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button in_out_choose_button;
        private System.Windows.Forms.TextBox minute_input;
        private System.Windows.Forms.Label label;
    }
}