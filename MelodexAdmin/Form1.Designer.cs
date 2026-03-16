namespace MelodexAdmin
{
    partial class Form1
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
            this.chooseLoginBtn = new System.Windows.Forms.Button();
            this.chooseRegisterBtn = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseLoginBtn
            // 
            this.chooseLoginBtn.Location = new System.Drawing.Point(371, 145);
            this.chooseLoginBtn.Name = "chooseLoginBtn";
            this.chooseLoginBtn.Size = new System.Drawing.Size(245, 35);
            this.chooseLoginBtn.TabIndex = 0;
            this.chooseLoginBtn.Text = "LOGIN";
            this.chooseLoginBtn.UseVisualStyleBackColor = true;
            this.chooseLoginBtn.Click += new System.EventHandler(this.chooseLoginBtn_Click);
            // 
            // chooseRegisterBtn
            // 
            this.chooseRegisterBtn.Location = new System.Drawing.Point(369, 213);
            this.chooseRegisterBtn.Name = "chooseRegisterBtn";
            this.chooseRegisterBtn.Size = new System.Drawing.Size(245, 35);
            this.chooseRegisterBtn.TabIndex = 1;
            this.chooseRegisterBtn.Text = "REGISTER";
            this.chooseRegisterBtn.UseVisualStyleBackColor = true;
            this.chooseRegisterBtn.Click += new System.EventHandler(this.chooseRegisterBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.chooseRegisterBtn);
            this.contentPanel.Controls.Add(this.chooseLoginBtn);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(984, 461);
            this.contentPanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.contentPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseLoginBtn;
        private System.Windows.Forms.Button chooseRegisterBtn;
        private System.Windows.Forms.Panel contentPanel;
    }
}

