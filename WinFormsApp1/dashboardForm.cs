using System;
using System.Collections.Generic; 
using System.Linq;             
using System.Windows.Forms;     
using System.Drawing;          
namespace QuizierApp
{
    public partial class DashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly LoginForm _loginFormInstance;
        private bool _isLoggingOut = false;

        public DashboardForm(User loggedInUser, LoginForm loginForm)
        {
            InitializeComponent(); 

            
            if (loggedInUser == null || string.IsNullOrWhiteSpace(loggedInUser.Username))
            {
                
                MessageBox.Show("Error: Invalid user data received.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                _currentUser = new User { Username = "Guest" }; 
                
            }
            else
            {
                _currentUser = loggedInUser; 
            }

            _loginFormInstance = loginForm; 

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dashboard";

            
            if (this.lblWelcome != null)
            {
                this.lblWelcome.Text = $"Welcome, {_currentUser.Username}!";
            }
            else
            {
                
                Console.WriteLine("Error: lblWelcome control not found on DashboardForm.");
                
            }


            
            if (_currentUser != null && !_currentUser.IsAdmin)
            {
                this.btnAdminPanel.Visible = false;
            }
            
            else if (_currentUser == null)
            {
                this.btnAdminPanel.Visible = false; 
            }


            
            this.btnStartQuiz.Click -= this.btnStartQuiz_Click;
            this.btnStartQuiz.Click += this.btnStartQuiz_Click;

            this.btnViewScores.Click -= this.btnViewScores_Click;
            this.btnViewScores.Click += this.btnViewScores_Click;

            this.btnAdminPanel.Click -= this.btnAdminPanel_Click;
            this.btnAdminPanel.Click += this.btnAdminPanel_Click;

           

            this.btnLogout.Click -= this.btnLogout_Click;
            this.btnLogout.Click += this.btnLogout_Click;

            this.FormClosed -= DashboardForm_FormClosed;
            this.FormClosed += DashboardForm_FormClosed;
        }

       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            _isLoggingOut = true;
            _loginFormInstance?.Show();
            this.Close();
        }

       
        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isLoggingOut)
            {
                _loginFormInstance?.Close();
            }
        }

       
        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
           
            if (_currentUser != null && _currentUser.IsAdmin)
            {
                AdminPanelForm adminPanel = new AdminPanelForm();
                adminPanel.ShowDialog(this);
            }
            else
            {
                
                MessageBox.Show("Admin privileges required.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            if (AppData.AllQuestions == null || !AppData.AllQuestions.Any())
            {
                MessageBox.Show("No questions have been loaded. Please add questions via the Admin Panel.", "No Questions Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (_currentUser == null)
            {
                MessageBox.Show("Error: User information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectSubjectForm selectForm = new SelectSubjectForm(AppData.AllQuestions, _currentUser);
            selectForm.ShowDialog(this);
        }

        private void btnViewScores_Click(object sender, EventArgs e)
        {
            ViewScoresForm scoresForm = new ViewScoresForm(AppData.AllScores);
            scoresForm.ShowDialog(this);
        }

        

    } 
} 