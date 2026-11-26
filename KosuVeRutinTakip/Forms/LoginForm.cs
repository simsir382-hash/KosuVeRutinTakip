using System;
using System.Windows.Forms;
using KosuVeRutinTakip.Models;
using KosuVeRutinTakip.Services;

namespace KosuVeRutinTakip.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService = new UserService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User user = _userService.Login(txtUsername.Text.Trim(), txtPassword.Text);
                if (user == null)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Giriş başarılı, ana ekrana yönlendir
                MainDashboardForm dashboard = new MainDashboardForm(user);
                this.Hide();
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser = new User
                {
                    FullName = txtFullName.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                    PasswordHash = txtPassword.Text
                };

                _userService.Register(newUser);
                MessageBox.Show("Kayıt başarılı! Şimdi giriş yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFullName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}