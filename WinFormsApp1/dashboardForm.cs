using System;
using System.Collections.Generic; // Needed for List<>
using System.Linq;             // Needed for Any()
using System.Windows.Forms;      // Needed for Form, Controls, etc.
using System.Drawing;          // Needed for Padding (if used in label) - Keep if designer label uses it

namespace QuizierApp
{
    public partial class DashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly LoginForm _loginFormInstance;
        private bool _isLoggingOut = false;

        public DashboardForm(User loggedInUser, LoginForm loginForm)
        {
            InitializeComponent(); // <-- Runs designer code first (creates lblWelcome)

            // --- VALIDATION: Ensure user object and username are valid ---
            if (loggedInUser == null || string.IsNullOrWhiteSpace(loggedInUser.Username))
            {
                // Handle this error case appropriately - maybe close the form,
                // show an error, or use a default message.
                MessageBox.Show("Error: Invalid user data received.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Option 1: Use a default message
                _currentUser = new User { Username = "Guest" }; // Or similar default
                // Option 2: Close the form (might require more complex handling)
                // this.Load += (s, e) => this.Close(); // Close after load event
                // return; // Prevent further execution if closing
            }
            else
            {
                _currentUser = loggedInUser; // Store valid user
            }

            _loginFormInstance = loginForm; // Store reference to login form

            // --- Apply Form Settings ---
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dashboard";

            // --- REMOVE the programmatic label creation ---
            // var label = new Label { ... };
            // this.Controls.Add(label);
            // label.BringToFront();
            // --- END OF REMOVAL ---

            // --- Set the Text of the DESIGNER Label ---
            // Make sure the label added in the designer is named "lblWelcome"
            // Add null check for safety, although InitializeComponent should create it.
            if (this.lblWelcome != null)
            {
                this.lblWelcome.Text = $"Welcome, {_currentUser.Username}!";
            }
            else
            {
                // Log an error or show a message if the designer label is missing
                Console.WriteLine("Error: lblWelcome control not found on DashboardForm.");
                // Optionally, create it programmatically as a fallback, but it's better
                // to ensure the designer is correct.
            }


            // --- Admin Panel Button Visibility ---
            // Ensure _currentUser is not null before checking IsAdmin
            if (_currentUser != null && !_currentUser.IsAdmin)
            {
                this.btnAdminPanel.Visible = false;
            }
            // If _currentUser could be null due to error handling above,
            // you might need to hide it by default or handle the null case:
            else if (_currentUser == null)
            {
                this.btnAdminPanel.Visible = false; // Hide if user data is invalid
            }


            // --- Attach Event Handlers ---
            // It's often better to attach these only once, either here OR in the designer, not both.
            // If the designer already attaches them (check Form.Designer.cs for lines like
            // this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click); )
            // then you don't need to add them here again. Removing them first (-) is safer if unsure.
            this.btnStartQuiz.Click -= this.btnStartQuiz_Click;
            this.btnStartQuiz.Click += this.btnStartQuiz_Click;

            this.btnViewScores.Click -= this.btnViewScores_Click;
            this.btnViewScores.Click += this.btnViewScores_Click;

            this.btnAdminPanel.Click -= this.btnAdminPanel_Click;
            this.btnAdminPanel.Click += this.btnAdminPanel_Click;

            //this.btnSettings.Click -= this.btnSettings_Click;
            //this.btnSettings.Click += this.btnSettings_Click;

            this.btnLogout.Click -= this.btnLogout_Click;
            this.btnLogout.Click += this.btnLogout_Click;

            this.FormClosed -= DashboardForm_FormClosed;
            this.FormClosed += DashboardForm_FormClosed;
        }

        // ----- Logout Button Handler -----
        private void btnLogout_Click(object sender, EventArgs e)
        {
            _isLoggingOut = true;
            _loginFormInstance?.Show();
            this.Close();
        }

        // ----- FormClosed Handler -----
        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isLoggingOut)
            {
                _loginFormInstance?.Close();
            }
        }

        // ----- Other Event Handler Methods -----

        // In DashboardForm.cs
        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            // Ensure _currentUser is not null and is an Admin
            if (_currentUser != null && _currentUser.IsAdmin)
            {
                // Just create and show the Admin Panel - it doesn't need internal verification
                AdminPanelForm adminPanel = new AdminPanelForm();
                adminPanel.ShowDialog(this);
            }
            else
            {
                // This message already handles non-admins trying to access the panel
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
            // Add null check for _currentUser before passing it
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

        //private void btnSettings_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Settings not yet implemented.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

    } // End of DashboardForm class
} // End of namespace