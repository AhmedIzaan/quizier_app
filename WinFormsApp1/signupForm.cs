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
            this.FormClosed += (s, ev) => _loginForm?.Show();
        }

        private void ChkIsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsAdmin == null || lblInstitution == null || txtInstitutionID == null) return;

            bool isChecked = chkIsAdmin.Checked;
            lblInstitution.Visible = isChecked;
            txtInstitutionID.Visible = isChecked;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; 
            string email = txtEmail.Text.Trim();
            bool isAdmin = chkIsAdmin.Checked;
            string institutionId = txtInstitutionID.Text.Trim();


            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Username, Password, and Email fields are required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (username.Length < 3 || username.Length >= 50)
            {
                MessageBox.Show("Username must be between 3 and 49 characters long.", "Invalid Username Length", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (password.Length < 5 || password.Length > 20)
            {
                MessageBox.Show("Password must be between 5 and 20 characters long.", "Invalid Password Length", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!username.Any(char.IsLetter)) 
            {
                MessageBox.Show("Username must contain at least one letter (cannot be numbers only).", "Invalid Username Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           


            // Email format check
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate username/email
            if (LoginForm.Users == null)
            {
                MessageBox.Show("Error: User list not initialized.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isDuplicate = LoginForm.Users.Any(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) ||
                u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            if (isDuplicate)
            {
                MessageBox.Show("Username or email already exists. Please choose different ones.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (isAdmin)
            {
                if (string.IsNullOrWhiteSpace(institutionId))
                {
                    MessageBox.Show("Institution ID is required for admin registration.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (institutionId != "12345")
                {
                    MessageBox.Show("Invalid Institution ID.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // --- Add user to list ---
            User newUser = new User
            {
                Username = username,
                Password = password, 
                Email = email,
                IsAdmin = isAdmin,
                InstitutionId = isAdmin ? institutionId : null
            };

            LoginForm.Users.Add(newUser);

            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _loginForm?.Show();
            this.Close();
        }

    } 
} 