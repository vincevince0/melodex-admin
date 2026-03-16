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
            this.slct_reports = new System.Windows.Forms.Button();
            this.slct_albums = new System.Windows.Forms.Button();
            this.slct_songs = new System.Windows.Forms.Button();
            this.slct_members = new System.Windows.Forms.Button();
            this.slct_artists = new System.Windows.Forms.Button();
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
            this.slct_users.Click += new System.EventHandler(this.slct_users_Click);
            // 
            // slct_reports
            // 
            this.slct_reports.Location = new System.Drawing.Point(13, 43);
            this.slct_reports.Name = "slct_reports";
            this.slct_reports.Size = new System.Drawing.Size(153, 23);
            this.slct_reports.TabIndex = 2;
            this.slct_reports.Text = "Select Reports";
            this.slct_reports.UseVisualStyleBackColor = true;
            this.slct_reports.Click += new System.EventHandler(this.slct_reports_Click);
            // 
            // slct_albums
            // 
            this.slct_albums.Location = new System.Drawing.Point(172, 13);
            this.slct_albums.Name = "slct_albums";
            this.slct_albums.Size = new System.Drawing.Size(153, 23);
            this.slct_albums.TabIndex = 3;
            this.slct_albums.Text = "Select Albums";
            this.slct_albums.UseVisualStyleBackColor = true;
            this.slct_albums.Click += new System.EventHandler(this.slct_albums_Click);
            // 
            // slct_songs
            // 
            this.slct_songs.Location = new System.Drawing.Point(331, 13);
            this.slct_songs.Name = "slct_songs";
            this.slct_songs.Size = new System.Drawing.Size(153, 23);
            this.slct_songs.TabIndex = 4;
            this.slct_songs.Text = "Select Songs";
            this.slct_songs.UseVisualStyleBackColor = true;
            this.slct_songs.Click += new System.EventHandler(this.slct_songs_Click);
            // 
            // slct_members
            // 
            this.slct_members.Location = new System.Drawing.Point(490, 13);
            this.slct_members.Name = "slct_members";
            this.slct_members.Size = new System.Drawing.Size(153, 23);
            this.slct_members.TabIndex = 5;
            this.slct_members.Text = "Select Members";
            this.slct_members.UseVisualStyleBackColor = true;
            this.slct_members.Click += new System.EventHandler(this.slct_members_Click);
            // 
            // slct_artists
            // 
            this.slct_artists.Location = new System.Drawing.Point(649, 13);
            this.slct_artists.Name = "slct_artists";
            this.slct_artists.Size = new System.Drawing.Size(153, 23);
            this.slct_artists.TabIndex = 6;
            this.slct_artists.Text = "Select Artists";
            this.slct_artists.UseVisualStyleBackColor = true;
            this.slct_artists.Click += new System.EventHandler(this.slct_artists_Click);
            // 
            // melodex_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.slct_artists);
            this.Controls.Add(this.slct_members);
            this.Controls.Add(this.slct_songs);
            this.Controls.Add(this.slct_albums);
            this.Controls.Add(this.slct_reports);
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
        private System.Windows.Forms.Button slct_reports;
        private System.Windows.Forms.Button slct_albums;
        private System.Windows.Forms.Button slct_songs;
        private System.Windows.Forms.Button slct_members;
        private System.Windows.Forms.Button slct_artists;
    }
}