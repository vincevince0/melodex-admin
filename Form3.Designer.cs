namespace MelodexAdmin
{
    partial class Form3
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
            this.host_label = new System.Windows.Forms.Label();
            this.user_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.host_textbox = new System.Windows.Forms.TextBox();
            this.user_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // host_label
            // 
            this.host_label.AutoSize = true;
            this.host_label.Location = new System.Drawing.Point(13, 13);
            this.host_label.Name = "host_label";
            this.host_label.Size = new System.Drawing.Size(35, 13);
            this.host_label.TabIndex = 0;
            this.host_label.Text = "Host: ";
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(13, 40);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(93, 13);
            this.user_label.TabIndex = 1;
            this.user_label.Text = "Felhasználó neve:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(13, 73);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(42, 13);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Jelszó: ";
            // 
            // host_textbox
            // 
            this.host_textbox.Location = new System.Drawing.Point(129, 6);
            this.host_textbox.Name = "host_textbox";
            this.host_textbox.Size = new System.Drawing.Size(208, 20);
            this.host_textbox.TabIndex = 3;
            // 
            // user_textbox
            // 
            this.user_textbox.Location = new System.Drawing.Point(129, 37);
            this.user_textbox.Name = "user_textbox";
            this.user_textbox.Size = new System.Drawing.Size(208, 20);
            this.user_textbox.TabIndex = 4;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(129, 73);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(208, 20);
            this.password_textbox.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 105);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.user_textbox);
            this.Controls.Add(this.host_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.host_label);
            this.MaximumSize = new System.Drawing.Size(392, 144);
            this.MinimumSize = new System.Drawing.Size(392, 144);
            this.Name = "Form3";
            this.Text = "Szerver Beállítások";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label host_label;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox host_textbox;
        private System.Windows.Forms.TextBox user_textbox;
        private System.Windows.Forms.TextBox password_textbox;
    }
}