namespace KosuVeRutinTakip.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblFull = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(85, 25);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Text = "Koşu ve Rutin Takip Sistemi";

            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(60, 75);
            this.lblUser.Text = "Kullanıcı Adı:";

            this.txtUsername.Location = new System.Drawing.Point(160, 72);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 23);

            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(60, 110);
            this.lblPass.Text = "Şifre:";

            this.txtPassword.Location = new System.Drawing.Point(160, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 23);
            this.txtPassword.UseSystemPasswordChar = true;

            this.btnLogin.Location = new System.Drawing.Point(160, 145);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 32);
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.lblFull.AutoSize = true;
            this.lblFull.Location = new System.Drawing.Point(60, 205);
            this.lblFull.Text = "Ad Soyad (Kayıt):";

            this.txtFullName.Location = new System.Drawing.Point(160, 202);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(180, 23);

            this.btnRegister.Location = new System.Drawing.Point(160, 240);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(180, 32);
            this.btnRegister.Text = "Yeni Kayıt Ol";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.ClientSize = new System.Drawing.Size(410, 300);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFull);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblBaslik);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}