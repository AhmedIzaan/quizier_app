using System;
using System.Collections.Generic;
using System.Data; // Keep if you might use BindingList later
using System.Linq;
using System.Windows.Forms;

namespace QuizierApp
{
    // Notice: No control declarations or InitializeComponent DEFINITION here
    public partial class ViewEditQuestionsForm : Form
    {
        private readonly string _subject;
        private readonly List<Question> _allQuestions;
        private List<Question> _subjectQuestions;

        public ViewEditQuestionsForm(string subject, List<Question> allQuestions)
        {
            // This call executes the code in ViewEditQuestionsForm.Designer.cs
            InitializeComponent(); // <<< KEEP THIS CALL

            // --- Now it's safe to access controls ---
            _subject = subject;
            _allQuestions = allQuestions;

            // This should now work assuming lblSubjectView is correctly defined in the .Designer.cs
            if (this.lblSubjectView != null) // Optional safety check
            {
                this.lblSubjectView.Text = $"Editing Questions for: {_subject}";
            }
            else
            {
                // Log error or show message if still null - indicates Designer issue
                Console.WriteLine("ERROR: lblSubjectView control not initialized correctly by Designer.");
                MessageBox.Show("Error initializing form layout.", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            LoadQuestionsForSubject();
        }

        private void LoadQuestionsForSubject()
        {
            // Ensure controls exist before using them
            if (lstQuestions == null) return;

            _subjectQuestions = _allQuestions
                .Where(q => q.Subject.Equals(_subject, StringComparison.OrdinalIgnoreCase))
                .ToList();

            lstQuestions.DataSource = null;
            lstQuestions.DisplayMember = "ToString";
            lstQuestions.ValueMember = null;

            if (_subjectQuestions.Any())
            {
                lstQuestions.DataSource = _subjectQuestions;
                lstQuestions.Enabled = true;
            }
            else
            {
                lstQuestions.DataSource = null;
                lstQuestions.Items.Clear();
                lstQuestions.Items.Add("No questions found for this subject.");
                lstQuestions.Enabled = false;
            }

            UpdateButtonStates();
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            // Ensure controls exist before using them
            if (lstQuestions == null || btnEditQuestion == null || btnDeleteQuestion == null) return;

            bool isQuestionSelected = lstQuestions.SelectedIndex != -1 && lstQuestions.SelectedItem is Question;
            btnEditQuestion.Enabled = isQuestionSelected;
            btnDeleteQuestion.Enabled = isQuestionSelected;
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            // Ensure control exists
            if (lstQuestions == null) return;

            if (lstQuestions.SelectedItem is Question selectedQuestion)
            {
                AddQuestionForm editForm = new AddQuestionForm(selectedQuestion);
                DialogResult result = editForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    int previouslySelectedIndex = lstQuestions.SelectedIndex;
                    LoadQuestionsForSubject();
                    if (previouslySelectedIndex >= 0 && previouslySelectedIndex < lstQuestions.Items.Count)
                    {
                        lstQuestions.SelectedIndex = previouslySelectedIndex;
                    }
                }
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            // Ensure control exists
            if (lstQuestions == null) return;

            if (lstQuestions.SelectedItem is Question selectedQuestion)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete this question?\n\n\"{selectedQuestion.ToString()}\"",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _allQuestions.Remove(selectedQuestion);
                    LoadQuestionsForSubject();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- REMOVE THE #REGION AND CONTROL DECLARATIONS THAT WERE HERE ---

    } // End Class
} // End Namespace