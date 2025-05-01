using System;
using System.Collections.Generic; 
using System.Drawing;
using System.Windows.Forms;

using System.Linq; 

namespace QuizierApp
{
    public partial class AdminPanelForm : Form
    {
       
        private PictureBox pbLogo;
        private ComboBox cmbSubjects;
        private Button btnAddQuestions;
        private Button btnUpdateQuestions;
        private Button btnSettings; 

       
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void btnAddQuestions_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbSubjects.SelectedIndex;
            string selectedSubject = cmbSubjects.SelectedItem?.ToString();

            if (selectedIndex <= 0 || string.IsNullOrEmpty(selectedSubject))
            {
                MessageBox.Show("Please select a subject from the dropdown first.", "No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddQuestionForm addForm = new AddQuestionForm(selectedSubject);
            addForm.ShowDialog(this);
        }

        private void btnUpdateQuestions_Click(object sender, EventArgs e)
        {
            UpdateQuestionsForm updateForm = new UpdateQuestionsForm(AppData.AllQuestions);
            updateForm.ShowDialog(this);
        }

        
        private void btnSettings_Click(object sender, EventArgs e)
        {
            
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this); 
        }

        
        private void InitializeComponent()
        {
            
            this.ClientSize = new Size(1366, 768); 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Admin Panel";
            this.BackColor = Color.FromArgb(45, 45, 45);

            int centerX = this.ClientSize.Width / 2; 
            int buttonWidth = 150; 
            int buttonHeight = 40; 
            int verticalSpacing = 20; 

            // --- Logo ---
            this.pbLogo = new PictureBox();
            try { this.pbLogo.Image = Image.FromFile(@"C:\Users\ahmed\OneDrive\Pictures\logo\quizierLogo.png"); }
            catch (Exception ex) {  this.pbLogo.BackColor = Color.DarkGray; }
            this.pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbLogo.Size = new Size(200, 200); 
            this.pbLogo.Location = new Point(centerX - (pbLogo.Width / 2), 50); 
            this.Controls.Add(this.pbLogo);

            // --- Subjects ComboBox ---
            this.cmbSubjects = new ComboBox();
            this.cmbSubjects.Font = new Font("Segoe UI", 12F);
            this.cmbSubjects.Items.Add("--- Select Subject ---");
            this.cmbSubjects.Items.AddRange(new object[] { "Math", "Science", "History", "Geography" }); // Add more subjects?
            this.cmbSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSubjects.Size = new Size(220, 30); // Combo Box Size
            this.cmbSubjects.Location = new Point(centerX - (cmbSubjects.Width / 2), pbLogo.Bottom + verticalSpacing + 10); // Position below logo
            this.cmbSubjects.SelectedIndex = 0;
            this.cmbSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))); // Style consistency
            this.cmbSubjects.ForeColor = System.Drawing.Color.White;
            this.cmbSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Style consistency
            this.Controls.Add(this.cmbSubjects);

            // --- Add Questions Button ---
            this.btnAddQuestions = new Button();
            this.btnAddQuestions.Text = "Add Questions";
            this.btnAddQuestions.Font = new Font("Segoe UI", 12F);
            this.btnAddQuestions.Size = new Size(buttonWidth, buttonHeight);
            this.btnAddQuestions.Location = new Point(centerX - (buttonWidth / 2), cmbSubjects.Bottom + verticalSpacing + 10); // Position below combo
            this.btnAddQuestions.BackColor = Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))); // Style consistency
            this.btnAddQuestions.ForeColor = Color.White;
            this.btnAddQuestions.FlatStyle = FlatStyle.Flat;
            this.btnAddQuestions.FlatAppearance.BorderSize = 0; // Style consistency
            this.btnAddQuestions.Click += new System.EventHandler(this.btnAddQuestions_Click);
            this.Controls.Add(this.btnAddQuestions);

            // --- Update Questions Button ---
            this.btnUpdateQuestions = new Button();
            this.btnUpdateQuestions.Text = "Update Questions";
            this.btnUpdateQuestions.Font = new Font("Segoe UI", 12F);
            this.btnUpdateQuestions.Size = new Size(buttonWidth, buttonHeight);
            this.btnUpdateQuestions.Location = new Point(centerX - (buttonWidth / 2), btnAddQuestions.Bottom + verticalSpacing); // Position below Add
            this.btnUpdateQuestions.BackColor = Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))); // Style consistency
            this.btnUpdateQuestions.ForeColor = Color.White;
            this.btnUpdateQuestions.FlatStyle = FlatStyle.Flat;
            this.btnUpdateQuestions.FlatAppearance.BorderSize = 0; // Style consistency
            this.btnUpdateQuestions.Click += new System.EventHandler(this.btnUpdateQuestions_Click);
            this.Controls.Add(this.btnUpdateQuestions);

            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSettings.Text = "Settings";
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSettings.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnSettings.Location = new System.Drawing.Point(centerX - (buttonWidth / 2), this.btnUpdateQuestions.Bottom + verticalSpacing); // Position below Update
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))); // Style consistency
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.FlatAppearance.BorderSize = 0; 
            
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
          
            this.Controls.Add(this.btnSettings);
           
            this.pbLogo.Name = "pbLogo";
            this.cmbSubjects.Name = "cmbSubjects";
            this.btnAddQuestions.Name = "btnAddQuestions";
            this.btnUpdateQuestions.Name = "btnUpdateQuestions";
            this.btnSettings.Name = "btnSettings"; 

           
        }

    } 
} 