namespace MelodexAdmin
{
    partial class melodex_admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.slct_users = new System.Windows.Forms.Button();
            this.shw_reports = new System.Windows.Forms.Button();
            this.slct_albums = new System.Windows.Forms.Button();
            this.slct_songs = new System.Windows.Forms.Button();
            this.slct_members = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 254);
            this.panel1.TabIndex = 0;
            // 
            // slct_users
            // 
            this.slct_users.Location = new System.Drawing.Point(13, 13);
            this.slct_users.Name = "slct_users";
            this.slct_users.Size = new System.Drawing.Size(153, 23);
            this.slct_users.TabIndex = 1;
            this.slct_users.Text = "Select Users";
            this.slct_users.UseVisualStyleBackColor = true;
            // 
            // shw_reports
            // 
            this.shw_reports.Location = new System.Drawing.Point(13, 43);
            this.shw_reports.Name = "shw_reports";
            this.shw_reports.Size = new System.Drawing.Size(153, 23);
            this.shw_reports.TabIndex = 2;
            this.shw_reports.Text = "Show Reports";
            this.shw_reports.UseVisualStyleBackColor = true;
            // 
            // slct_albums
            // 
            this.slct_albums.Location = new System.Drawing.Point(172, 13);
            this.slct_albums.Name = "slct_albums";
            this.slct_albums.Size = new System.Drawing.Size(153, 23);
            this.slct_albums.TabIndex = 3;
            this.slct_albums.Text = "Select Albums";
            this.slct_albums.UseVisualStyleBackColor = true;
            // 
            // slct_songs
            // 
            this.slct_songs.Location = new System.Drawing.Point(331, 13);
            this.slct_songs.Name = "slct_songs";
            this.slct_songs.Size = new System.Drawing.Size(153, 23);
            this.slct_songs.TabIndex = 4;
            this.slct_songs.Text = "Select Songs";
            this.slct_songs.UseVisualStyleBackColor = true;
            // 
            // slct_members
            // 
            this.slct_members.Location = new System.Drawing.Point(490, 13);
            this.slct_members.Name = "slct_members";
            this.slct_members.Size = new System.Drawing.Size(153, 23);
            this.slct_members.TabIndex = 5;
            this.slct_members.Text = "Select Members";
            this.slct_members.UseVisualStyleBackColor = true;
            // 
            // melodex_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.slct_members);
            this.Controls.Add(this.slct_songs);
            this.Controls.Add(this.slct_albums);
            this.Controls.Add(this.shw_reports);
            this.Controls.Add(this.slct_users);
            this.Controls.Add(this.panel1);
            this.Name = "melodex_admin";
            this.Text = "Melodex Admin";
            this.Load += new System.EventHandler(this.melodex_admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button slct_users;
        private System.Windows.Forms.Button shw_reports;
        private System.Windows.Forms.Button slct_albums;
        private System.Windows.Forms.Button slct_songs;
        private System.Windows.Forms.Button slct_members;
    }
}