using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizierApp
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private PictureBox pbLogo;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnRegister;

        // 🆕 Admin Controls
        private CheckBox chkIsAdmin;
        private TextBox txtInstitutionID;
        private Label lblInstitution;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            // ----- Form Settings -----
            this.ClientSize = new Size(1366, 768);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.BackColor = Color.FromArgb(45, 45, 45);

            int centerX = this.ClientSize.Width / 2;

            // ----- PictureBox (Logo) -----
            this.pbLogo = new PictureBox();
            string logoPath = @"C:\Users\ahmed\OneDrive\Pictures\logo\quizierLogo.png";
            this.pbLogo.Image = Image.FromFile(logoPath);
            this.pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbLogo.Size = new Size(200, 200);
            int logoY = 50;
            int logoX = centerX - (this.pbLogo.Width / 2);
            this.pbLogo.Location = new Point(logoX, logoY);
            this.Controls.Add(this.pbLogo);

            // ----- Username TextBox -----
            this.txtUsername = new TextBox();
#if NET6_0_OR_GREATER
            this.txtUsername.PlaceholderText = "Username";
#endif
            this.txtUsername.Font = new Font("Segoe UI", 14F);
            this.txtUsername.Size = new Size(400, 40);
            int textBoxX = centerX - (this.txtUsername.Width / 2);
            int textBoxY = logoY + this.pbLogo.Height + 40;
            this.txtUsername.Location = new Point(textBoxX, textBoxY);
            this.txtUsername.ForeColor = Color.White;
            this.txtUsername.BackColor = Color.FromArgb(60, 60, 60);
            this.Controls.Add(this.txtUsername);

            // ----- Password TextBox -----
            this.txtPassword = new TextBox();
#if NET6_0_OR_GREATER
            this.txtPassword.PlaceholderText = "Password";
#endif
            this.txtPassword.Font = new Font("Segoe UI", 14F);
            this.txtPassword.Size = new Size(400, 40);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Location = new Point(textBoxX, textBoxY + 60);
            this.txtPassword.ForeColor = Color.White;
            this.txtPassword.BackColor = Color.FromArgb(60, 60, 60);
            this.Controls.Add(this.txtPassword);

            // ----- Email TextBox -----
            this.txtEmail = new TextBox();
#if NET6_0_OR_GREATER
            this.txtEmail.PlaceholderText = "Email";
#endif
            this.txtEmail.Font = new Font("Segoe UI", 14F);
            this.txtEmail.Size = new Size(400, 40);
            this.txtEmail.Location = new Point(textBoxX, textBoxY + 120);
            this.txtEmail.ForeColor = Color.White;
            this.txtEmail.BackColor = Color.FromArgb(60, 60, 60);
            this.Controls.Add(this.txtEmail);

            // ----- Admin CheckBox -----
            this.chkIsAdmin = new CheckBox();
            this.chkIsAdmin.Text = "Register as Admin";
            this.chkIsAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.chkIsAdmin.ForeColor = Color.White;
            this.chkIsAdmin.BackColor = this.BackColor;
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Location = new Point(textBoxX, textBoxY + 180);
            this.chkIsAdmin.CheckedChanged += (s, e) =>
            {
                this.txtInstitutionID.Visible = this.chkIsAdmin.Checked;
                this.lblInstitution.Visible = this.chkIsAdmin.Checked;
            };
            this.Controls.Add(this.chkIsAdmin);

            // ----- Institution Label -----
            this.lblInstitution = new Label();
            this.lblInstitution.Text = "Institution ID";
            this.lblInstitution.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblInstitution.ForeColor = Color.White;
            this.lblInstitution.Location = new Point(textBoxX, textBoxY + 220);
            this.lblInstitution.Size = new Size(200, 30);
            this.lblInstitution.Visible = false;
            this.Controls.Add(this.lblInstitution);

            // ----- Institution ID TextBox -----
            this.txtInstitutionID = new TextBox();
#if NET6_0_OR_GREATER
            this.txtInstitutionID.PlaceholderText = "Institution ID";
#endif
            this.txtInstitutionID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtInstitutionID.Size = new Size(400, 40);
            this.txtInstitutionID.Location = new Point(textBoxX, textBoxY + 260);
            this.txtInstitutionID.ForeColor = Color.White;
            this.txtInstitutionID.BackColor = Color.FromArgb(60, 60, 60);
            this.txtInstitutionID.Visible = false;
            this.Controls.Add(this.txtInstitutionID);

            // ----- Register Button -----
            this.btnRegister = new Button();
            this.btnRegister.Text = "Register";
            this.btnRegister.Font = new Font("Segoe UI", 14F);
            this.btnRegister.Size = new Size(160, 50);
            int btnY = textBoxY + 320;
            this.btnRegister.Location = new Point(centerX - (this.btnRegister.Width / 2), btnY);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.BackColor = Color.FromArgb(60, 60, 60);
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);
            this.Controls.Add(this.btnRegister);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
