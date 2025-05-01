using System;
using System.Windows.Forms;

namespace QuizierApp
{
    public partial class AddQuestionForm : Form
    {
        private string _subject; 
        private readonly Question _editingQuestion; 

     
        public AddQuestionForm(string subject) : this()
        {
            _subject = subject;
            lblSubjectName.Text = _subject;
            this.Text = "Add New Question";
            btnSaveQuestion.Text = "Save Question";
        }

       
        public AddQuestionForm(Question questionToEdit) : this()
        {
            _editingQuestion = questionToEdit;
            _subject = questionToEdit.Subject;

            PopulateFieldsForEdit();
            lblSubjectName.Text = _subject;
            this.Text = "Edit Question";
            btnSaveQuestion.Text = "Update Question";
        }

   
        private AddQuestionForm()
        {
            InitializeComponent(); 
        }

        
        private void PopulateFieldsForEdit()
        {
            if (_editingQuestion == null) return;

            txtQuestion.Text = _editingQuestion.QuestionText;
            txtOptionA.Text = _editingQuestion.OptionA;
            txtOptionB.Text = _editingQuestion.OptionB;
            txtOptionC.Text = _editingQuestion.OptionC;
            txtOptionD.Text = _editingQuestion.OptionD;

            switch (_editingQuestion.CorrectAnswerLetter)
            {
                case 'A': rbCorrectA.Checked = true; break;
                case 'B': rbCorrectB.Checked = true; break;
                case 'C': rbCorrectC.Checked = true; break;
                case 'D': rbCorrectD.Checked = true; break;
                default: rbCorrectA.Checked = true; break;
            }
        }

        
        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            string questionText = txtQuestion.Text.Trim();
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
                string.IsNullOrWhiteSpace(optionA) ||
                string.IsNullOrWhiteSpace(optionB) ||
                string.IsNullOrWhiteSpace(optionC) ||
                string.IsNullOrWhiteSpace(optionD))
            {
                MessageBox.Show("Please fill in the question and all four options.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (correctAnswer == ' ')
            {
                MessageBox.Show("Please select the correct answer.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_editingQuestion == null)
            {
           
                Question newQuestion = new Question(_subject, questionText, optionA, optionB, optionC, optionD, correctAnswer);
                AppData.AllQuestions.Add(newQuestion);

                MessageBox.Show($"Question for '{_subject}' saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormFields();
                txtQuestion.Focus();
            }
            else
            {
                
                _editingQuestion.QuestionText = questionText;
                _editingQuestion.OptionA = optionA;
                _editingQuestion.OptionB = optionB;
                _editingQuestion.OptionC = optionC;
                _editingQuestion.OptionD = optionD;
                _editingQuestion.CorrectAnswerLetter = correctAnswer;

                MessageBox.Show($"Question updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

       
        private void ClearFormFields()
        {
            txtQuestion.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();
            rbCorrectA.Checked = true;
        }

    
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
