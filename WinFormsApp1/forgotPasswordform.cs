using System;
using System.Linq;
using System.Windows.Forms;

namespace QuizierApp
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

           
            var user = LoginForm.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                MessageBox.Show("Username not found.");
                return;
            }

            
            user.Password = newPassword;
            MessageBox.Show("Password updated successfully!");

           
            this.Close();
        }
    }
}
