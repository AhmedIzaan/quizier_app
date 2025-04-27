// filename: UpdateQuestionsForm.Designer.cs

namespace QuizierApp
{
    partial class UpdateQuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // --- Instantiating Controls ---
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.grpEditArea = new System.Windows.Forms.GroupBox();
            this.grpCorrectAnswer = new System.Windows.Forms.GroupBox();
            this.rbCorrectD = new System.Windows.Forms.RadioButton(); // Declare D first for TabIndex flow
            this.rbCorrectC = new System.Windows.Forms.RadioButton();
            this.rbCorrectB = new System.Windows.Forms.RadioButton();
            this.rbCorrectA = new System.Windows.Forms.RadioButton();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.labelOptionD = new System.Windows.Forms.Label();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.labelOptionC = new System.Windows.Forms.Label();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.labelOptionB = new System.Windows.Forms.Label();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.labelOptionA = new System.Windows.Forms.Label();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelSelectSubject = new System.Windows.Forms.Label();
            this.labelSelectQuestion = new System.Windows.Forms.Label();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.grpEditArea.SuspendLayout(); // GroupBox needs Suspend/Resume
            this.grpCorrectAnswer.SuspendLayout();
            this.SuspendLayout(); // Form needs Suspend/Resume

            //
            // labelSelectSubject
            //
            this.labelSelectSubject.AutoSize = true;
            this.labelSelectSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelSelectSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220))))); // Light gray text
            this.labelSelectSubject.Location = new System.Drawing.Point(12, 15);
            this.labelSelectSubject.Name = "labelSelectSubject";
            this.labelSelectSubject.Size = new System.Drawing.Size(90, 17);
            this.labelSelectSubject.TabIndex = 0;
            this.labelSelectSubject.Text = "Select Subject:";
            //
            // cmbSubjects
            //
            this.cmbSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))); // Darker background
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Flat style
            this.cmbSubjects.ForeColor = System.Drawing.Color.White; // White text
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(108, 12);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(261, 23); // Font set on Form
            this.cmbSubjects.TabIndex = 1;
            // Event Handler attached in UpdateQuestionsForm.cs
            //
            // labelSelectQuestion
            //
            this.labelSelectQuestion.AutoSize = true;
            this.labelSelectQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelSelectQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelSelectQuestion.Location = new System.Drawing.Point(12, 48);
            this.labelSelectQuestion.Name = "labelSelectQuestion";
            this.labelSelectQuestion.Size = new System.Drawing.Size(135, 17);
            this.labelSelectQuestion.TabIndex = 2;
            this.labelSelectQuestion.Text = "Select Question to Edit:";
            //
            // lstQuestions
            //
            this.lstQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))); // Darker background
            this.lstQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstQuestions.ForeColor = System.Drawing.Color.White; // White text
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.ItemHeight = 15; // Based on Form's default font
            this.lstQuestions.Location = new System.Drawing.Point(15, 68);
            this.lstQuestions.Name = "lstQuestions";
            // Use Anchors for flexible height
            this.lstQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstQuestions.Size = new System.Drawing.Size(354, 437); // Adjusted height calculation for anchors
            this.lstQuestions.TabIndex = 3;
            // Event Handler attached in UpdateQuestionsForm.cs
            //
            // grpEditArea
            //
            this.grpEditArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEditArea.Controls.Add(this.grpCorrectAnswer);
            this.grpEditArea.Controls.Add(this.txtOptionD);
            this.grpEditArea.Controls.Add(this.labelOptionD);
            this.grpEditArea.Controls.Add(this.txtOptionC);
            this.grpEditArea.Controls.Add(this.labelOptionC);
            this.grpEditArea.Controls.Add(this.txtOptionB);
            this.grpEditArea.Controls.Add(this.labelOptionB);
            this.grpEditArea.Controls.Add(this.txtOptionA);
            this.grpEditArea.Controls.Add(this.labelOptionA);
            this.grpEditArea.Controls.Add(this.txtQuestionText);
            this.grpEditArea.Controls.Add(this.labelQuestionText);
            this.grpEditArea.Enabled = false; // Initially disabled
            this.grpEditArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220))))); // GroupBox text color
            this.grpEditArea.Location = new System.Drawing.Point(389, 12);
            this.grpEditArea.Name = "grpEditArea";
            this.grpEditArea.Size = new System.Drawing.Size(430, 434); // Adjusted height
            this.grpEditArea.TabIndex = 4;
            this.grpEditArea.TabStop = false;
            this.grpEditArea.Text = "Edit Selected Question";
            //
            // grpCorrectAnswer
            //
            this.grpCorrectAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right))); // Anchor to bottom of parent groupbox
            this.grpCorrectAnswer.Controls.Add(this.rbCorrectD);
            this.grpCorrectAnswer.Controls.Add(this.rbCorrectC);
            this.grpCorrectAnswer.Controls.Add(this.rbCorrectB);
            this.grpCorrectAnswer.Controls.Add(this.rbCorrectA);
            this.grpCorrectAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpCorrectAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.grpCorrectAnswer.Location = new System.Drawing.Point(19, 363); // Position near bottom
            this.grpCorrectAnswer.Name = "grpCorrectAnswer";
            this.grpCorrectAnswer.Size = new System.Drawing.Size(392, 55);
            this.grpCorrectAnswer.TabIndex = 10;
            this.grpCorrectAnswer.TabStop = false;
            this.grpCorrectAnswer.Text = "Correct Answer";
            //
            // rbCorrectD
            //
            this.rbCorrectD.AutoSize = true;
            this.rbCorrectD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbCorrectD.Location = new System.Drawing.Point(240, 22);
            this.rbCorrectD.Name = "rbCorrectD";
            this.rbCorrectD.Size = new System.Drawing.Size(35, 21);
            this.rbCorrectD.TabIndex = 3;
            this.rbCorrectD.TabStop = true;
            this.rbCorrectD.Text = "D";
            this.rbCorrectD.UseVisualStyleBackColor = true;
            //
            // rbCorrectC
            //
            this.rbCorrectC.AutoSize = true;
            this.rbCorrectC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbCorrectC.Location = new System.Drawing.Point(165, 22);
            this.rbCorrectC.Name = "rbCorrectC";
            this.rbCorrectC.Size = new System.Drawing.Size(34, 21);
            this.rbCorrectC.TabIndex = 2;
            this.rbCorrectC.TabStop = true;
            this.rbCorrectC.Text = "C";
            this.rbCorrectC.UseVisualStyleBackColor = true;
            //
            // rbCorrectB
            //
            this.rbCorrectB.AutoSize = true;
            this.rbCorrectB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbCorrectB.Location = new System.Drawing.Point(90, 22);
            this.rbCorrectB.Name = "rbCorrectB";
            this.rbCorrectB.Size = new System.Drawing.Size(34, 21);
            this.rbCorrectB.TabIndex = 1;
            this.rbCorrectB.TabStop = true;
            this.rbCorrectB.Text = "B";
            this.rbCorrectB.UseVisualStyleBackColor = true;
            //
            // rbCorrectA
            //
            this.rbCorrectA.AutoSize = true;
            this.rbCorrectA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbCorrectA.Location = new System.Drawing.Point(15, 22);
            this.rbCorrectA.Name = "rbCorrectA";
            this.rbCorrectA.Size = new System.Drawing.Size(34, 21);
            this.rbCorrectA.TabIndex = 0;
            this.rbCorrectA.TabStop = true;
            this.rbCorrectA.Text = "A";
            this.rbCorrectA.UseVisualStyleBackColor = true;
            //
            // txtOptionD
            //
            this.txtOptionD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOptionD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtOptionD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOptionD.ForeColor = System.Drawing.Color.White;
            this.txtOptionD.Location = new System.Drawing.Point(78, 318); // Adjusted Y
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(333, 25);
            this.txtOptionD.TabIndex = 9;
            //
            // labelOptionD
            //
            this.labelOptionD.AutoSize = true;
            this.labelOptionD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelOptionD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelOptionD.Location = new System.Drawing.Point(16, 321); // Adjusted Y
            this.labelOptionD.Name = "labelOptionD";
            this.labelOptionD.Size = new System.Drawing.Size(66, 17);
            this.labelOptionD.TabIndex = 8;
            this.labelOptionD.Text = "Option D:";
            //
            // txtOptionC
            //
            this.txtOptionC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOptionC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtOptionC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOptionC.ForeColor = System.Drawing.Color.White;
            this.txtOptionC.Location = new System.Drawing.Point(78, 279); // Adjusted Y
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(333, 25);
            this.txtOptionC.TabIndex = 7;
            //
            // labelOptionC
            //
            this.labelOptionC.AutoSize = true;
            this.labelOptionC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelOptionC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelOptionC.Location = new System.Drawing.Point(16, 282); // Adjusted Y
            this.labelOptionC.Name = "labelOptionC";
            this.labelOptionC.Size = new System.Drawing.Size(65, 17);
            this.labelOptionC.TabIndex = 6;
            this.labelOptionC.Text = "Option C:";
            //
            // txtOptionB
            //
            this.txtOptionB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOptionB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtOptionB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOptionB.ForeColor = System.Drawing.Color.White;
            this.txtOptionB.Location = new System.Drawing.Point(78, 240); // Adjusted Y
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(333, 25);
            this.txtOptionB.TabIndex = 5;
            //
            // labelOptionB
            //
            this.labelOptionB.AutoSize = true;
            this.labelOptionB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelOptionB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelOptionB.Location = new System.Drawing.Point(16, 243); // Adjusted Y
            this.labelOptionB.Name = "labelOptionB";
            this.labelOptionB.Size = new System.Drawing.Size(64, 17);
            this.labelOptionB.TabIndex = 4;
            this.labelOptionB.Text = "Option B:";
            //
            // txtOptionA
            //
            this.txtOptionA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOptionA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtOptionA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOptionA.ForeColor = System.Drawing.Color.White;
            this.txtOptionA.Location = new System.Drawing.Point(78, 201); // Adjusted Y
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(333, 25);
            this.txtOptionA.TabIndex = 3;
            //
            // labelOptionA
            //
            this.labelOptionA.AutoSize = true;
            this.labelOptionA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelOptionA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelOptionA.Location = new System.Drawing.Point(16, 204); // Adjusted Y
            this.labelOptionA.Name = "labelOptionA";
            this.labelOptionA.Size = new System.Drawing.Size(65, 17);
            this.labelOptionA.TabIndex = 2;
            this.labelOptionA.Text = "Option A:";
            //
            // txtQuestionText
            //
            this.txtQuestionText.AcceptsReturn = true;
            this.txtQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right))); // Allow vertical resize
            this.txtQuestionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtQuestionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuestionText.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtQuestionText.ForeColor = System.Drawing.Color.White;
            this.txtQuestionText.Location = new System.Drawing.Point(19, 48);
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestionText.Size = new System.Drawing.Size(392, 140); // Adjusted height calculation
            this.txtQuestionText.TabIndex = 1;
            //
            // labelQuestionText
            //
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelQuestionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelQuestionText.Location = new System.Drawing.Point(16, 30);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(92, 17);
            this.labelQuestionText.TabIndex = 0;
            this.labelQuestionText.Text = "Question Text:";
            //
            // btnSaveChanges
            //
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right))); // Anchor bottom-right
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))); // Greenish (match Save button)
            this.btnSaveChanges.Enabled = false; // Initially disabled
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(559, 469); // Adjusted position
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 35); // Match Save/Cancel size
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            // Event Handler attached in UpdateQuestionsForm.cs
            //
            // btnClose
            //
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))); // Dark Gray (match Cancel button)
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(699, 469); // Adjusted position
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35); // Match Save/Cancel size
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // Event Handler attached in UpdateQuestionsForm.cs
            //
            // UpdateQuestionsForm
            //
            this.AcceptButton = this.btnSaveChanges; // Enter key triggers save
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))); // Dark background
            this.CancelButton = this.btnClose; // Escape key triggers close
            this.ClientSize = new System.Drawing.Size(834, 521); // Maintain overall size
            this.Controls.Add(this.labelSelectQuestion);
            this.Controls.Add(this.labelSelectSubject);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.grpEditArea);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.cmbSubjects);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Set base font
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateQuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Questions";
            this.grpEditArea.ResumeLayout(false);
            this.grpEditArea.PerformLayout();
            this.grpCorrectAnswer.ResumeLayout(false);
            this.grpCorrectAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            // btnDeleteQuestion
            //
            this.btnDeleteQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteQuestion.BackColor = System.Drawing.Color.Firebrick; // Example color
            this.btnDeleteQuestion.Enabled = false; // Initially disabled
            this.btnDeleteQuestion.FlatAppearance.BorderSize = 0;
            this.btnDeleteQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteQuestion.ForeColor = System.Drawing.Color.White;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(419, 469); // *** ADJUST POSITION ***
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(120, 35); // *** ADJUST SIZE ***
            this.btnDeleteQuestion.TabIndex = 7; // *** ADJUST TAB INDEX ***
            this.btnDeleteQuestion.Text = "Delete Question";
            this.btnDeleteQuestion.UseVisualStyleBackColor = false;

            this.Controls.Add(this.btnDeleteQuestion);

        }

        #endregion

        // --- Control Declarations (Keep these matching the above) ---
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.GroupBox grpEditArea;
        private System.Windows.Forms.GroupBox grpCorrectAnswer;
        private System.Windows.Forms.RadioButton rbCorrectD;
        private System.Windows.Forms.RadioButton rbCorrectC;
        private System.Windows.Forms.RadioButton rbCorrectB;
        private System.Windows.Forms.RadioButton rbCorrectA;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.Label labelOptionD;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.Label labelOptionC;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.Label labelOptionB;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.Label labelOptionA;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.Label labelQuestionText;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelSelectSubject;
        private System.Windows.Forms.Label labelSelectQuestion;
    }
}