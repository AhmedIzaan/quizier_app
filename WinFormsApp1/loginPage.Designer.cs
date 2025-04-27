using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizierApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private PictureBox pbLogo;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnSignUp;
        private Button btnForgotPassword;
        private Label lblOr;

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
            this.Text = "Login";

            // Dark background
            this.BackColor = Color.FromArgb(45, 45, 45);

            // We'll define some helper variables for layout
            int centerX = this.ClientSize.Width / 2;

            // ----- PictureBox (Logo) -----
            this.pbLogo = new PictureBox();
            
            string logoPath = @"C:\Users\ahmed\OneDrive\Pictures\logo\quizierLogo.png";
            this.pbLogo.Image = Image.FromFile(logoPath);
            this.pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            // Make the logo bigger
            this.pbLogo.Size = new Size(200, 200);

            // Place the logo near the top center
            int logoX = centerX - (this.pbLogo.Width / 2);
            int logoY = 50; // 50px from top
            this.pbLogo.Location = new Point(logoX, logoY);
            this.Controls.Add(this.pbLogo);

            // ----- Username TextBox -----
            this.txtUsername = new TextBox();
#if NET6_0_OR_GREATER
            this.txtUsername.PlaceholderText = "username";
#endif
            // Bigger font
            this.txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            // Wider text box
            this.txtUsername.Size = new Size(400, 40);

            // Position below the logo
            int textBoxX = centerX - (this.txtUsername.Width / 2);
            int textBoxY = logoY + this.pbLogo.Height + 40; // 40px gap under logo
            this.txtUsername.Location = new Point(textBoxX, textBoxY);
            this.Controls.Add(this.txtUsername);

            // ----- Password TextBox -----
            this.txtPassword = new TextBox();
#if NET6_0_OR_GREATER
            this.txtPassword.PlaceholderText = "password";
#endif
            this.txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtPassword.Size = new Size(400, 40);
            this.txtPassword.PasswordChar = '*';
            // Place 60px below the username box
            this.txtPassword.Location = new Point(textBoxX, textBoxY + 60);
            this.Controls.Add(this.txtPassword);

            // We'll arrange the Login, OR, and Signup buttons side by side
            // using bigger buttons to fill more space.
            int buttonWidth = 120;
            int buttonHeight = 40;
            int labelWidth = 40; // "OR"
            int spacing = 30;    // space between items
            // Y position for the row of buttons (further down)
            int rowY = (textBoxY + 60) + 80;

            // Calculate total width for [login + spacing + OR + spacing + signup]
            int totalWidth = buttonWidth + spacing + labelWidth + spacing + buttonWidth;
            int startX = centerX - (totalWidth / 2);

            // ----- Login Button -----
            this.btnLogin = new Button();
            this.btnLogin.Text = "Login";
            this.btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Size = new Size(buttonWidth, buttonHeight);
            this.btnLogin.Location = new Point(startX, rowY);
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            this.Controls.Add(this.btnLogin);

            // ----- "OR" Label -----
            this.lblOr = new Label();
            this.lblOr.Text = "OR";
            this.lblOr.ForeColor = Color.White;
            this.lblOr.AutoSize = true;
            // Make the "OR" label a bit bigger
            this.lblOr.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblOr.ForeColor = Color.White;
            // place it after login + spacing
            this.lblOr.Location = new Point(startX + buttonWidth + spacing, rowY + 8);
            this.Controls.Add(this.lblOr);

            // ----- Sign Up Button -----
            this.btnSignUp = new Button();
            this.btnSignUp.Text = "Signup";
            this.btnSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnSignUp.ForeColor = Color.White;
            this.btnSignUp.Size = new Size(buttonWidth, buttonHeight);
            int signUpX = startX + buttonWidth + spacing + labelWidth + spacing;
            this.btnSignUp.Location = new Point(signUpX, rowY);
            this.btnSignUp.Click += new EventHandler(this.btnSignUp_Click);
            this.Controls.Add(this.btnSignUp);

            // ----- Forgot Password Button -----
            this.btnForgotPassword = new Button();
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnForgotPassword.ForeColor = Color.White;
            this.btnForgotPassword.Size = new Size(160, buttonHeight);
            // Center it below the row, leaving more vertical space
            int forgotY = rowY + 80;
            this.btnForgotPassword.Location = new Point(centerX - (this.btnForgotPassword.Width / 2), forgotY);
            this.btnForgotPassword.Click += new EventHandler(this.btnForgotPassword_Click);
            this.Controls.Add(this.btnForgotPassword);

            // ----- AcceptButton, Resume Layout -----
            this.AcceptButton = this.btnLogin;
            this.ResumeLayout(false);
        }

        #endregion
    }
}
