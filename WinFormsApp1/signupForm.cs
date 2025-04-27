using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuizierApp
{
    public partial class SignUpForm : Form
    {
        private readonly LoginForm _loginForm;

        public SignUpForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            this.FormClosed += (s, ev) => _loginForm.Show(); // If user closes sign-up, show login again
        }
        private void ChkIsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkIsAdmin.Checked;
            lblInstitution.Visible = isChecked;
            txtInstitutionID.Visible = isChecked;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            bool isAdmin = chkIsAdmin.Checked;
            string institutionId = txtInstitutionID.Text;

            // Basic validation
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            // Email format check
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            // Check for duplicate username/email
            bool isDuplicate = LoginForm.Users.Any(u => u.Username == username || u.Email == email);
            if (isDuplicate)
            {
                MessageBox.Show("Username or email already exists.");
                return;
            }

            // 🧠 Admin-specific validation
            if (isAdmin)
            {
                if (string.IsNullOrWhiteSpace(institutionId))
                {
                    MessageBox.Show("Institution ID is required for admin registration.");
                    return;
                }

                // Optional: Validate the institution ID with a hardcoded or external list
                if (institutionId != "12345") // Replace with your valid ID logic
                {
                    MessageBox.Show("Invalid Institution ID.");
                    return;
                }
            }

            // Add user to list
            LoginForm.Users.Add(new User
            {
                Username = username,
                Password = password,
                Email = email,
                IsAdmin = isAdmin 
            });

            MessageBox.Show("Registration successful!");

            _loginForm.Show();
            this.Close();
        }

    }
}
