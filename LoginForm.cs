using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BlueTechAPP
{
    public class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        public LoginForm()
        {
            InitializeComponent();
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
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT password_hash, role FROM users WHERE username=@u", conn))
                    {
                        cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string pwd = reader.GetString(0);
                                string role = reader.GetString(1);
                                if (VerifyPassword(txtPassword.Text, pwd))
                                {
                                    Form1 main = new Form1(role);
                                    main.Show();
                                    this.Hide();
                                    return;
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Identifiants invalides", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool VerifyPassword(string inputPassword, string storedHash)
        {
            string hash = ComputeHash(inputPassword);
            return string.Equals(hash, storedHash, StringComparison.OrdinalIgnoreCase);
        }

        private static string ComputeHash(string input)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
