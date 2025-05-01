using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizierApp
{
    partial class ForgotPasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private PictureBox pbLogo;
        private TextBox txtUsername;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnSubmit;

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

            // ----- Form Settings -----
            this.SuspendLayout();
            // Targeting 1366 x 768
            this.ClientSize = new Size(1366, 768);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";

            // Dark background
            this.BackColor = Color.FromArgb(45, 45, 45);

            int centerX = this.ClientSize.Width / 2;

            // ----- PictureBox (Logo) -----
            this.pbLogo = new PictureBox();
            
            string logoPath = @"C:\Users\ahmed\OneDrive\Pictures\logo\quizierLogo.png";
            this.pbLogo.Image = Image.FromFile(logoPath);
            this.pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            
            this.pbLogo.Size = new Size(200, 200);

           
            int logoX = centerX - (this.pbLogo.Width / 2);
            int logoY = 50; 
            this.pbLogo.Location = new Point(logoX, logoY);
            this.Controls.Add(this.pbLogo);

            // ----- Username TextBox -----
            this.txtUsername = new TextBox();
#if NET6_0_OR_GREATER
            this.txtUsername.PlaceholderText = "username";
#endif
            this.txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtUsername.Size = new Size(400, 40);
            
            int textBoxX = centerX - (this.txtUsername.Width / 2);
            int textBoxY = logoY + this.pbLogo.Height + 40;
            this.txtUsername.Location = new Point(textBoxX, textBoxY);
            
            this.txtUsername.ForeColor = Color.White;
            this.txtUsername.BackColor = Color.FromArgb(60, 60, 60);
            this.Controls.Add(this.txtUsername);

           
            this.txtNewPassword = new TextBox();
#if NET6_0_OR_GREATER
            this.txtNewPassword.PlaceholderText = "new password";
#endif
            this.txtNewPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtNewPassword.Size = new Size(400, 40);
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Location = new Point(textBoxX, textBoxY + 60);
            this.txtNewPassword.ForeColor = Color.White;
            this.txtNewPassword.BackColor = Color.FromArgb(60, 60, 60);
            this.Controls.Add(this.txtNewPassword);

           
            this.txtConfirmPassword = new TextBox();
#if NET6_0_OR_GREATER
            this.txtConfirmPassword.PlaceholderText = "confirm password";
#endif
            this.txtConfirmPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtConfirmPassword.Size = new Size(400, 40);
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Location = new Point(textBoxX, textBoxY + 120);
            this.txtConfirmPassword.ForeColor = Color.White;
            this.txtConfirmPassword.BackColor = Color.FromArgb(60, 60, 60);
            this.Controls.Add(this.txtConfirmPassword);

            
            this.btnSubmit = new Button();
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnSubmit.Size = new Size(120, 40);
            
            int submitY = textBoxY + 180;
            this.btnSubmit.Location = new Point(centerX - (this.btnSubmit.Width / 2), submitY);
            
            this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);
           
            this.btnSubmit.ForeColor = Color.White;
            this.btnSubmit.BackColor = Color.FromArgb(60, 60, 60);
            this.Controls.Add(this.btnSubmit);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
