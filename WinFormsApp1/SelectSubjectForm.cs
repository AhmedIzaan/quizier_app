// SelectSubjectForm.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuizierApp
{
    public partial class SelectSubjectForm : Form
    {
        private readonly List<Question> _allQuestions;
        private readonly User _currentUser; // User taking the quiz

        public SelectSubjectForm(List<Question> allQuestions, User currentUser)
        {
            InitializeComponent();
            _allQuestions = allQuestions;
            _currentUser = currentUser;
            PopulateSubjects();
        }

        private void PopulateSubjects()
        {
            cmbQuizSubjects.Items.Clear();
            cmbQuizSubjects.Items.Add("-- Select a Subject --"); // Placeholder

            if (_allQuestions != null && _allQuestions.Any())
            {
                // Get distinct subjects that actually have questions
                var subjects = _allQuestions
                                 .Select(q => q.Subject)
                                 .Distinct(StringComparer.OrdinalIgnoreCase)
                                 .OrderBy(s => s)
                                 .ToList();

                if (subjects.Any())
                {
                    cmbQuizSubjects.Items.AddRange(subjects.ToArray());
                }
            }

            cmbQuizSubjects.SelectedIndex = 0; // Select the placeholder

            // Disable start button if no real subjects are available
            btnStartQuiz.Enabled = cmbQuizSubjects.Items.Count > 1;
            if (!btnStartQuiz.Enabled)
            {
                cmbQuizSubjects.Items.Clear(); // Clear if disabled
                cmbQuizSubjects.Items.Add("[No Subjects Available]");
                cmbQuizSubjects.SelectedIndex = 0;
                cmbQuizSubjects.Enabled = false;
            }
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            if (cmbQuizSubjects.SelectedIndex <= 0) // Check if placeholder is selected
            {
                MessageBox.Show("Please select a subject to start the quiz.", "Subject Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedSubject = cmbQuizSubjects.SelectedItem.ToString();

            // Filter questions for the selected subject BEFORE opening the quiz form
            List<Question> questionsForQuiz = _allQuestions
                .Where(q => q.Subject.Equals(selectedSubject, StringComparison.OrdinalIgnoreCase))
                .ToList(); // Consider shuffling these later for randomness

            if (!questionsForQuiz.Any())
            {
                MessageBox.Show($"Sorry, there are currently no questions available for the subject '{selectedSubject}'.", "No Questions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // --- Start the Actual Quiz ---
            QuizForm quizForm = new QuizForm(selectedSubject, _currentUser.Username, questionsForQuiz);
            quizForm.ShowDialog(this.Owner); // Show quiz modal relative to Dashboard

            // Quiz is complete, just close the selection form
            this.DialogResult = DialogResult.OK; // Indicate successful start
            this.Close();
        }

        private void btnCancelQuiz_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // --- Add InitializeComponent and control declarations ---
        #region Windows Form Designer generated code
        // (Generate this via the designer - basic layout)
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbQuizSubjects = new System.Windows.Forms.ComboBox();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnCancelQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Subject for Quiz:";
            //
            // cmbQuizSubjects
            //
            this.cmbQuizSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuizSubjects.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbQuizSubjects.FormattingEnabled = true;
            this.cmbQuizSubjects.Location = new System.Drawing.Point(34, 60);
            this.cmbQuizSubjects.Name = "cmbQuizSubjects";
            this.cmbQuizSubjects.Size = new System.Drawing.Size(320, 28);
            this.cmbQuizSubjects.TabIndex = 1;
            //
            // btnStartQuiz
            //
            this.btnStartQuiz.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartQuiz.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnStartQuiz.ForeColor = System.Drawing.Color.White;
            this.btnStartQuiz.Location = new System.Drawing.Point(34, 115);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(150, 40);
            this.btnStartQuiz.TabIndex = 2;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = false;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            //
            // btnCancelQuiz
            //
            this.btnCancelQuiz.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelQuiz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelQuiz.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCancelQuiz.ForeColor = System.Drawing.Color.White;
            this.btnCancelQuiz.Location = new System.Drawing.Point(204, 115);
            this.btnCancelQuiz.Name = "btnCancelQuiz";
            this.btnCancelQuiz.Size = new System.Drawing.Size(150, 40);
            this.btnCancelQuiz.TabIndex = 3;
            this.btnCancelQuiz.Text = "Cancel";
            this.btnCancelQuiz.UseVisualStyleBackColor = false;
            this.btnCancelQuiz.Click += new System.EventHandler(this.btnCancelQuiz_Click);
            //
            // SelectSubjectForm
            //
            this.AcceptButton = this.btnStartQuiz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CancelButton = this.btnCancelQuiz;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.btnCancelQuiz);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.cmbQuizSubjects);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Quiz Subject";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbQuizSubjects;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnCancelQuiz;

    }
}