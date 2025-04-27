using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuizierApp
{
    public partial class UpdateQuestionsForm : Form
    {
        private readonly List<Question> _allQuestions; // Reference to AppData.AllQuestions
        private List<Question> _filteredQuestions;   // Questions for the selected subject
        private Question _currentlySelectedQuestion; // The question currently selected in the listbox

        // --- ADD Declaration for the Delete Button (ensure Name matches Designer) ---
        // This should technically be in the .Designer.cs file, but ensure your code knows about it.
        // If the designer added it correctly, you don't strictly need this line here,
        // but it doesn't hurt for clarity if the designer is correct.
        private System.Windows.Forms.Button btnDeleteQuestion;


        public UpdateQuestionsForm(List<Question> allQuestions)
        {
            InitializeComponent();

            _allQuestions = allQuestions ?? new List<Question>(); // Handle null just in case

            // Populate the subjects ComboBox
            PopulateSubjectsComboBox();

            // Attach event handlers (ensure these are ALSO done in Designer for safety)
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // *** ADD Event Handler for Delete Button ***
            // Make sure your button Name in the designer is "btnDeleteQuestion"
            if (this.btnDeleteQuestion != null) // Check if designer created it
            {
                this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            }
            else
            {
                // Log or warn if the button wasn't found - indicates designer issue
                Console.WriteLine("WARNING: btnDeleteQuestion control not found during initialization.");
            }


            // Initial state: no subject selected, editing disabled
            ClearAndDisableEditingFields();
        }

        private void PopulateSubjectsComboBox()
        {
            // Get distinct subjects from the master list
            var subjects = _allQuestions
                           .Select(q => q.Subject)
                           .Distinct()
                           .OrderBy(s => s)
                           .ToList();

            cmbSubjects.Items.Clear();
            cmbSubjects.Items.Add("--- Select Subject ---"); // Placeholder
            cmbSubjects.Items.AddRange(subjects.ToArray());
            cmbSubjects.SelectedIndex = 0; // Select the placeholder
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQuestionsForSelectedSubject();
        }

        private void LoadQuestionsForSelectedSubject()
        {
            _currentlySelectedQuestion = null; // Reset selection when subject changes
            ClearAndDisableEditingFields();
            lstQuestions.DataSource = null; // Unbind

            if (cmbSubjects.SelectedIndex <= 0) // No real subject selected
            {
                _filteredQuestions = new List<Question>(); // Empty list
                lstQuestions.Items.Clear();
                lstQuestions.Items.Add("Select a subject to see questions.");
                lstQuestions.Enabled = false;
                return;
            }

            string selectedSubject = cmbSubjects.SelectedItem.ToString();

            // Filter questions
            _filteredQuestions = _allQuestions
                .Where(q => q.Subject.Equals(selectedSubject, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (_filteredQuestions.Any())
            {
                lstQuestions.DisplayMember = "ToString"; // Use Question's ToString()
                lstQuestions.ValueMember = null;
                lstQuestions.DataSource = _filteredQuestions; // Bind the filtered list
                lstQuestions.Enabled = true;
            }
            else
            {
                // If no questions left for this subject after potential delete, clear listbox
                lstQuestions.DataSource = null; // Ensure unbound
                lstQuestions.Items.Clear();
                lstQuestions.Items.Add($"No questions found for '{selectedSubject}'.");
                lstQuestions.Enabled = false;

                // Optional: Refresh subjects list if this was the last question for the subject
                // Check if the master list STILL contains this subject after removal
                bool subjectStillExists = _allQuestions.Any(q => q.Subject.Equals(selectedSubject, StringComparison.OrdinalIgnoreCase));
                if (!subjectStillExists)
                {
                    Console.WriteLine($"Subject '{selectedSubject}' no longer has questions. Refreshing subjects list.");
                    // Store current selection text before repopulating
                    string previouslySelectedSubject = cmbSubjects.SelectedItem?.ToString();
                    PopulateSubjectsComboBox();
                    // Try to reselect if it wasn't the one removed, otherwise default to index 0
                    int newIndex = cmbSubjects.Items.IndexOf(previouslySelectedSubject);
                    cmbSubjects.SelectedIndex = (newIndex >= 0) ? newIndex : 0;

                }
            }
            // Ensure editing fields are cleared/disabled if no item gets automatically selected
            if (lstQuestions.SelectedIndex == -1)
            {
                ClearAndDisableEditingFields();
            }
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected Question object
            _currentlySelectedQuestion = lstQuestions.SelectedItem as Question;
            PopulateEditingFields(_currentlySelectedQuestion); // This will enable/disable buttons too
        }

        private void PopulateEditingFields(Question question)
        {
            bool isQuestionSelected = (question != null);

            if (!isQuestionSelected)
            {
                ClearAndDisableEditingFields(); // Calls the method that also disables buttons
                return;
            }

            // Populate fields with data from the selected question
            txtQuestionText.Text = question.QuestionText;
            txtOptionA.Text = question.OptionA;
            txtOptionB.Text = question.OptionB;
            txtOptionC.Text = question.OptionC;
            txtOptionD.Text = question.OptionD;

            // Select the correct RadioButton
            rbCorrectA.Checked = (question.CorrectAnswerLetter == 'A');
            rbCorrectB.Checked = (question.CorrectAnswerLetter == 'B');
            rbCorrectC.Checked = (question.CorrectAnswerLetter == 'C');
            rbCorrectD.Checked = (question.CorrectAnswerLetter == 'D');

            // Enable editing area and relevant buttons
            grpEditArea.Enabled = true;
            btnSaveChanges.Enabled = true;
            // *** ENABLE Delete Button ***
            if (this.btnDeleteQuestion != null) btnDeleteQuestion.Enabled = true;
        }

        private void ClearAndDisableEditingFields()
        {
            // Clear all fields
            txtQuestionText.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();
            rbCorrectA.Checked = false; // Or set a default like A
            rbCorrectB.Checked = false;
            rbCorrectC.Checked = false;
            rbCorrectD.Checked = false;

            // Disable editing area and action buttons
            grpEditArea.Enabled = false;
            btnSaveChanges.Enabled = false;
            // *** DISABLE Delete Button ***
            if (this.btnDeleteQuestion != null) btnDeleteQuestion.Enabled = false;

            _currentlySelectedQuestion = null; // Clear selection reference
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
            // --- End Validation ---


            // --- Perform the Update ---
            _currentlySelectedQuestion.QuestionText = questionText;
            _currentlySelectedQuestion.OptionA = optionA;
            _currentlySelectedQuestion.OptionB = optionB;
            _currentlySelectedQuestion.OptionC = optionC;
            _currentlySelectedQuestion.OptionD = optionD;
            _currentlySelectedQuestion.CorrectAnswerLetter = correctAnswer;

            MessageBox.Show("Question updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the list box display (binding doesn't always auto-update text)
            int currentSubjectIndex = cmbSubjects.SelectedIndex;
            int currentQuestionIndex = lstQuestions.SelectedIndex;

            // Force refresh by rebinding
            LoadQuestionsForSelectedSubject();

            // Re-select subject and item
            if (currentSubjectIndex >= 0) cmbSubjects.SelectedIndex = currentSubjectIndex; // Ensure subject is still selected
            if (currentQuestionIndex >= 0 && currentQuestionIndex < lstQuestions.Items.Count)
            {
                lstQuestions.SelectedIndex = currentQuestionIndex;
            }
            else
            {
                // If re-selection fails, clear fields
                lstQuestions.SelectedIndex = -1; // Explicitly clear selection
                ClearAndDisableEditingFields();
            }
        }

        // *** ADD Handler for the Delete Button ***
        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (_currentlySelectedQuestion == null)
            {
                MessageBox.Show("No question selected to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation Dialog
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to permanently delete this question?\n\n-> \"{_currentlySelectedQuestion.ToString()}\"",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2); // Default to No

            if (confirm == DialogResult.Yes)
            {
                // Remove from the master list (passed by reference from AppData)
                _allQuestions.Remove(_currentlySelectedQuestion);

                MessageBox.Show("Question deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the UI
                _currentlySelectedQuestion = null; // Ensure reference is cleared
                // Reload questions for the currently selected subject
                // This will automatically update the listbox and call ClearAndDisableEditingFields if needed
                LoadQuestionsForSelectedSubject();

                // Note: LoadQuestionsForSelectedSubject now handles checking if the subject
                // needs to be removed from the dropdown if it has no more questions.
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}