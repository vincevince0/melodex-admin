using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDatabaseMySQL;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MelodexAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start();
        }

        //on start
        public void start()
        {
            contentPanel.Controls.Clear();

            Button LoginBtn = new Button();
            LoginBtn.Size = new Size(188, 30);
            LoginBtn.Location = new Point(406, 240);
            LoginBtn.Text = "Login";
            LoginBtn.Name = "LoginBtn";
            contentPanel.Controls.Add(LoginBtn);

            this.AcceptButton = LoginBtn;
            LoginBtn.Click += LoginBtn_Click;

            TextBox emailTextBox = new TextBox();
            emailTextBox.Size = new Size(188, 20);
            emailTextBox.Location = new Point(406, 166);
            emailTextBox.Text = "Email";
            emailTextBox.Name = "EmailTextBox";

            emailTextBox.Enter += emailTextBox_Enter;
            emailTextBox.Leave += emailTextBox_Leave;

            contentPanel.Controls.Add(emailTextBox);

            TextBox passwordTextBox = new TextBox();
            passwordTextBox.Size = new Size(188, 20);
            passwordTextBox.Location = new Point(406, 200);
            passwordTextBox.Text = "Password";
            passwordTextBox.Name = "PasswordTextBox";
            passwordTextBox.UseSystemPasswordChar = false;

            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.Leave += passwordTextBox_Leave;

            contentPanel.Controls.Add(passwordTextBox);

            PictureBox logo = new PictureBox();
            logo.Size = new Size(155, 124);
            logo.Location = new Point(817, 325);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.BackColor = Color.Transparent;

            try
            {
                logo.Image = Image.FromFile("angled_view.png");
            }
            catch { }

            contentPanel.Controls.Add(logo);
        }

        //login buttons
            private void LoginBtn_Click(object sender, EventArgs e)
        {
            // 1. Get the values from the TextBoxes
            // Since you added them to 'contentPanel', we find them by name
            string inputEmail = contentPanel.Controls["EmailTextBox"].Text;
            string inputPass = contentPanel.Controls["PasswordTextBox"].Text;

            // 2. Load DB connection settings from options.txt
            Options opt = Közös.KapcsolódásiAdatokBeolvasása();

            try
            {
                // 3. Initialize the database connection
                MyDB db = new MyDB($"server={opt.Host};userid={opt.FNév};password={opt.Jelszó};charset=utf8;database=melodex");

                // 4. SQL Query: Look for the user with ID 2 and matching credentials
                // Note: In a real app, use hashing! For now, we compare plain text.
                string sql = $"SELECT * FROM users WHERE id = 2 AND email = '{inputEmail}' AND name = '{inputPass}'";

                DataTable dt = db.SelectDataTableGUI(sql);

                // 5. Check if we found a match
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Sikeres bejelentkezés, Admin!");

                    // Open the admin form
                    melodex_admin adminForm = new melodex_admin();
                    adminForm.FormClosed += (s, args) => this.Close();
                    this.Hide();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Helytelen adatok vagy nincs admin jogosultságod!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a csatlakozás során: " + ex.Message);
            }
        }
        
        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            TextBox emailTextBox = sender as TextBox;

            if (emailTextBox.Text == "Email")
            {
                emailTextBox.Text = "";
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            TextBox emailTextBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailTextBox.Text = "Email";
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            TextBox passwordTextBox = sender as TextBox;

            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.UseSystemPasswordChar = true;
            }
            
        }
 

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            TextBox passwordTextBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }




    }
}
