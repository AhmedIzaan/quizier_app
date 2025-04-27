using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
// Added for LinkLabel if you used that for Forgot Password
using System.ComponentModel;

namespace QuizierApp
{
    public partial class LoginForm : Form
    {
        // Static list to hold users (Replace with persistent storage later)
        public static List<User> Users = new List<User>();

        public LoginForm()
        {
            InitializeComponent();

            // --- Optional: Add default users for testing if list is empty ---
            if (!Users.Any())
            {
                // Remember to use strong, hashed passwords in a real app!
                Users.Add(new User { Username = "admin", Password = "admin123", Email = "admin@quiz.com", IsAdmin = true, InstitutionId = "12345" }); // Add InstitutionId for admin
                Users.Add(new User { Username = "student", Password = "pass", Email = "student@quiz.com", IsAdmin = false });
            }
            // --- End Optional ---
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim(); // Trim input
            string password = txtPassword.Text; // Don't trim password

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Find the User object
            User foundUser = Users.FirstOrDefault(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == password); // <<< USE HASH COMPARISON IN PRODUCTION

            if (foundUser != null) // User found
            {
                MessageBox.Show($"Login successful! Welcome {foundUser.Username}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- MODIFICATION START ---

                // 1. Create DashboardForm, passing the found User object AND 'this' LoginForm instance.
                DashboardForm dashboard = new DashboardForm(foundUser, this);

                // 2. REMOVE the old FormClosed handler that automatically closed LoginForm.
                // The DashboardForm now controls when the LoginForm should close (on app exit).
                // dashboard.FormClosed += (s, args) => this.Close(); // <<< REMOVE THIS LINE

                // --- MODIFICATION END ---

                // 3. Show the dashboard and hide the login form.
                dashboard.Show();
                this.Hide();
            }
            else // User not found
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var signUpForm = new SignUpForm(this);
            signUpForm.Show();
            this.Hide();
        }

        // --- Combined Forgot Password Logic ---
        // This method handles click from either the Button or LinkLabel

        // If using LinkLabel in Designer.cs:
        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword();
        }

        // If using Button btnForgotPassword in Designer.cs:
        // (Make sure the event handler is attached in InitializeComponent or here)
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword();
        }

        // Common method called by either handler
        private void ForgotPassword()
        {
            var forgotForm = new ForgotPasswordForm();
            forgotForm.ShowDialog(this); // Show modal
        }


        // --- Ensure InitializeComponent exists (usually in LoginForm.Designer.cs) ---
        // (Your designer code seems fine from the previous step)
        // #region Windows Form Designer generated code ... #endregion


        // --- Control declarations (should be in LoginForm.Designer.cs) ---
        // private TextBox txtUsername;
        // private TextBox txtPassword;
        // private Button btnLogin;
        // private Button btnSignUp;
        // private PictureBox pbLogo;
        // private Label lblOr;
        // private Button btnForgotPassword; // Or LinkLabel lnkForgotPassword;

    } // End of LoginForm Class


    // --- User Class Definition ---
    // (Ensure this class definition is accessible - ideally in its own User.cs file)
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; } // STORE HASHED PASSWORDS!
        public string Email { get; set; }
        public bool IsAdmin { get; set; } = false; // Default to not admin
        public string InstitutionId { get; set; } // Needed for Admin Sign Up
    }

} // End of namespace