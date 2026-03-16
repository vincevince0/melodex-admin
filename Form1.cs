using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.Leave += passwordTextBox_Leave;

            contentPanel.Controls.Add(passwordTextBox);
        }

        //login buttons
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            melodex_admin melodexadmin = new melodex_admin();

            melodexadmin.FormClosed += (s, args) => this.Close(); 

            this.Hide();
            melodexadmin.Show();
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
            }
        }
 

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            TextBox passwordTextBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "Password";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }




    }
}
