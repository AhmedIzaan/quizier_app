using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuizierApp
{
    public partial class UpdateQuestionsForm : Form
    {
        private readonly List<Question> _allQuestions;
        private List<Question> _filteredQuestions;   
        private Question _currentlySelectedQuestion; 

      
        private System.Windows.Forms.Button btnDeleteQuestion;


        public UpdateQuestionsForm(List<Question> allQuestions)
        {
            InitializeComponent();

            _allQuestions = allQuestions ?? new List<Question>(); 

            
            PopulateSubjectsComboBox();

            
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
           
            if (this.btnDeleteQuestion != null) 
            {
                this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            }
            else
            {
                Console.WriteLine("WARNING: btnDeleteQuestion control not found during initialization.");
            }


            
            ClearAndDisableEditingFields();
        }

        private void PopulateSubjectsComboBox()
        {
            
            var subjects = _allQuestions
                           .Select(q => q.Subject)
                           .Distinct()
                           .OrderBy(s => s)
                           .ToList();

            cmbSubjects.Items.Clear();
            cmbSubjects.Items.Add("--- Select Subject ---"); 
            cmbSubjects.Items.AddRange(subjects.ToArray());
            cmbSubjects.SelectedIndex = 0; 
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQuestionsForSelectedSubject();
        }

        private void LoadQuestionsForSelectedSubject()
        {
            _currentlySelectedQuestion = null; 
            ClearAndDisableEditingFields();
            lstQuestions.DataSource = null; 

            if (cmbSubjects.SelectedIndex <= 0) 
            {
                _filteredQuestions = new List<Question>(); 
                lstQuestions.Items.Clear();
                lstQuestions.Items.Add("Select a subject to see questions.");
                lstQuestions.Enabled = false;
                return;
            }

            string selectedSubject = cmbSubjects.SelectedItem.ToString();

          
            _filteredQuestions = _allQuestions
                .Where(q => q.Subject.Equals(selectedSubject, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (_filteredQuestions.Any())
            {
                lstQuestions.DisplayMember = "ToString"; 
                lstQuestions.ValueMember = null;
                lstQuestions.DataSource = _filteredQuestions;
                lstQuestions.Enabled = true;
            }
            else
            {
                
                lstQuestions.DataSource = null; 
                lstQuestions.Items.Clear();
                lstQuestions.Items.Add($"No questions found for '{selectedSubject}'.");
                lstQuestions.Enabled = false;

               
                bool subjectStillExists = _allQuestions.Any(q => q.Subject.Equals(selectedSubject, StringComparison.OrdinalIgnoreCase));
                if (!subjectStillExists)
                {
                    Console.WriteLine($"Subject '{selectedSubject}' no longer has questions. Refreshing subjects list.");
                 
                    string previouslySelectedSubject = cmbSubjects.SelectedItem?.ToString();
                    PopulateSubjectsComboBox();
                 
                    int newIndex = cmbSubjects.Items.IndexOf(previouslySelectedSubject);
                    cmbSubjects.SelectedIndex = (newIndex >= 0) ? newIndex : 0;

                }
            }
            
            if (lstQuestions.SelectedIndex == -1)
            {
                ClearAndDisableEditingFields();
            }
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            _currentlySelectedQuestion = lstQuestions.SelectedItem as Question;
            PopulateEditingFields(_currentlySelectedQuestion); 
        }

        private void PopulateEditingFields(Question question)
        {
            bool isQuestionSelected = (question != null);

            if (!isQuestionSelected)
            {
                ClearAndDisableEditingFields(); 
                return;
            }

          
            txtQuestionText.Text = question.QuestionText;
            txtOptionA.Text = question.OptionA;
            txtOptionB.Text = question.OptionB;
            txtOptionC.Text = question.OptionC;
            txtOptionD.Text = question.OptionD;

            rbCorrectA.Checked = (question.CorrectAnswerLetter == 'A');
            rbCorrectB.Checked = (question.CorrectAnswerLetter == 'B');
            rbCorrectC.Checked = (question.CorrectAnswerLetter == 'C');
            rbCorrectD.Checked = (question.CorrectAnswerLetter == 'D');

            grpEditArea.Enabled = true;
            btnSaveChanges.Enabled = true;
            if (this.btnDeleteQuestion != null) btnDeleteQuestion.Enabled = true;
        }

        private void ClearAndDisableEditingFields()
        {
            txtQuestionText.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();
            rbCorrectA.Checked = false; 
            rbCorrectB.Checked = false;
            rbCorrectC.Checked = false;
            rbCorrectD.Checked = false;

            
            grpEditArea.Enabled = false;
            btnSaveChanges.Enabled = false;

            if (this.btnDeleteQuestion != null) btnDeleteQuestion.Enabled = false;

            _currentlySelectedQuestion = null; 
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (_currentlySelectedQuestion == null)
            {
                MessageBox.Show("No question selected to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Basic Validation ---
            string questionText = txtQuestionText.Text.Trim();
            string optionA = txtOptionA.Text.Trim();
            string optionB = txtOptionB.Text.Trim();
            string optionC = txtOptionC.Text.Trim();
            string optionD = txtOptionD.Text.Trim();
            char correctAnswer = ' ';

            if (rbCorrectA.Checked) correctAnswer = 'A';
            else if (rbCorrectB.Checked) correctAnswer = 'B';
            else if (rbCorrectC.Checked) correctAnswer = 'C';
            else if (rbCorrectD.Checked) correctAnswer = 'D';

            if (string.IsNullOrWhiteSpace(questionText) ||
                string.IsNullOrWhiteSpace(optionA) || string.IsNullOrWhiteSpace(optionB) ||
                string.IsNullOrWhiteSpace(optionC) || string.IsNullOrWhiteSpace(optionD))
            {
                MessageBox.Show("Please fill in the question and all four options.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (correctAnswer == ' ')
            {
                MessageBox.Show("Please select the correct answer.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          


          
            _currentlySelectedQuestion.QuestionText = questionText;
            _currentlySelectedQuestion.OptionA = optionA;
            _currentlySelectedQuestion.OptionB = optionB;
            _currentlySelectedQuestion.OptionC = optionC;
            _currentlySelectedQuestion.OptionD = optionD;
            _currentlySelectedQuestion.CorrectAnswerLetter = correctAnswer;

            MessageBox.Show("Question updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int currentSubjectIndex = cmbSubjects.SelectedIndex;
            int currentQuestionIndex = lstQuestions.SelectedIndex;

            LoadQuestionsForSelectedSubject();

            if (currentSubjectIndex >= 0) cmbSubjects.SelectedIndex = currentSubjectIndex; 
            if (currentQuestionIndex >= 0 && currentQuestionIndex < lstQuestions.Items.Count)
            {
                lstQuestions.SelectedIndex = currentQuestionIndex;
            }
            else
            {
                lstQuestions.SelectedIndex = -1; 
                ClearAndDisableEditingFields();
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (_currentlySelectedQuestion == null)
            {
                MessageBox.Show("No question selected to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to permanently delete this question?\n\n-> \"{_currentlySelectedQuestion.ToString()}\"",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2); 

            if (confirm == DialogResult.Yes)
            {
                _allQuestions.Remove(_currentlySelectedQuestion);

                MessageBox.Show("Question deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _currentlySelectedQuestion = null;
               
                LoadQuestionsForSelectedSubject();

                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}