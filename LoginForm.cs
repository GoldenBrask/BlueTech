using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BlueTechAPP
{
    public class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Dictionary<string, (string Password, string Role)> users;

        public LoginForm()
        {
            InitializeComponent();
            users = new Dictionary<string, (string, string)>
            {
                { "superadmin", ("password", "super_admin") },
                { "admin", ("password", "admin") }
            };
        }

        private void InitializeComponent()
        {
            this.Text = "Login";
            this.ClientSize = new Size(400, 200);
            Label lblUser = new Label { Text = "Username", Left = 50, Top = 30, Width = 80 };
            Label lblPass = new Label { Text = "Password", Left = 50, Top = 70, Width = 80 };
            txtUsername = new TextBox { Left = 150, Top = 25, Width = 180 };
            txtPassword = new TextBox { Left = 150, Top = 65, Width = 180, UseSystemPasswordChar = true };
            btnLogin = new Button { Text = "Login", Left = 150, Top = 110, Width = 100 };
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(lblUser);
            this.Controls.Add(lblPass);
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (users.TryGetValue(txtUsername.Text.Trim(), out var data) && data.Password == txtPassword.Text)
            {
                Form1 main = new Form1(data.Role);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Identifiants invalides", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
