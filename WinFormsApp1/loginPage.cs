using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.ComponentModel;

namespace QuizierApp
{
    public partial class LoginForm : Form
    {
       
        public static List<User> Users = new List<User>();

        public LoginForm()
        {
            InitializeComponent();

           
            if (!Users.Any())
            {
               
                Users.Add(new User { Username = "admin", Password = "admin123", Email = "admin@quiz.com", IsAdmin = true, InstitutionId = "12345" }); // Add InstitutionId for admin
                Users.Add(new User { Username = "student", Password = "pass", Email = "student@quiz.com", IsAdmin = false });
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim(); 
            string password = txtPassword.Text; 

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            User foundUser = Users.FirstOrDefault(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == password); 

            if (foundUser != null) 
            {
                MessageBox.Show($"Login successful! Welcome {foundUser.Username}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                DashboardForm dashboard = new DashboardForm(foundUser, this);

                
                dashboard.Show();
                this.Hide();
            }
            else 
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

        
        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword();
        }

        
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword();
        }

        
        private void ForgotPassword()
        {
            var forgotForm = new ForgotPasswordForm();
            forgotForm.ShowDialog(this); 
        }


        

    } 


    
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; } 
        public string Email { get; set; }
        public bool IsAdmin { get; set; } = false; 
        public string InstitutionId { get; set; } 
    }

} 