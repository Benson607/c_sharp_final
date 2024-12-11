
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
            this.time_input = new System.Windows.Forms.TextBox();
            this.amount_input = new System.Windows.Forms.TextBox();
            this.tag_chooser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_input = new System.Windows.Forms.TextBox();
            this.check_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "時間";
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
            // time_input
            // 
            this.time_input.Location = new System.Drawing.Point(14, 24);
            this.time_input.Name = "time_input";
            this.time_input.Size = new System.Drawing.Size(100, 22);
            this.time_input.TabIndex = 3;
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
            // Add_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 130);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.text_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tag_chooser);
            this.Controls.Add(this.amount_input);
            this.Controls.Add(this.time_input);
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
        private System.Windows.Forms.TextBox time_input;
        private System.Windows.Forms.TextBox amount_input;
        private System.Windows.Forms.ComboBox tag_chooser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Button cancel_button;
    }
}