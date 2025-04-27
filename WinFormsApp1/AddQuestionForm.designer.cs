namespace QuizierApp
{
    partial class AddQuestionForm
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
            this.lblSubjectInfo = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.lblOptionD = new System.Windows.Forms.Label();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.gbCorrectAnswer = new System.Windows.Forms.GroupBox();
            this.rbCorrectD = new System.Windows.Forms.RadioButton(); // Declare D first for TabIndex flow
            this.rbCorrectC = new System.Windows.Forms.RadioButton();
            this.rbCorrectB = new System.Windows.Forms.RadioButton();
            this.rbCorrectA = new System.Windows.Forms.RadioButton();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbCorrectAnswer.SuspendLayout(); // GroupBox needs Suspend/Resume
            this.SuspendLayout(); // Form needs Suspend/Resume

            //
            // lblSubjectInfo
            //
            this.lblSubjectInfo.AutoSize = true;
            this.lblSubjectInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220))))); // Light gray text
            this.lblSubjectInfo.Location = new System.Drawing.Point(25, 22); // Adjusted position
            this.lblSubjectInfo.Name = "lblSubjectInfo";
            this.lblSubjectInfo.Size = new System.Drawing.Size(53, 17);
            this.lblSubjectInfo.TabIndex = 0; // Tab index starts here
            this.lblSubjectInfo.Text = "Subject:";

            //
            // lblSubjectName
            //
            this.lblSubjectName.AutoSize = false; // Set to false to control width if needed later
            this.lblSubjectName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(255))))); // Light blue text
            this.lblSubjectName.Location = new System.Drawing.Point(84, 22);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(450, 17); // Give it some width
            this.lblSubjectName.TabIndex = 1;
            this.lblSubjectName.Text = "[Subject Name Placeholder]"; // Placeholder text

            //
            // lblQuestion
            //
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblQuestion.Location = new System.Drawing.Point(25, 60);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(64, 17);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question:";

            //
            // txtQuestion
            //
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right))); // Anchor for resizing
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))); // Darker background
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtQuestion.ForeColor = System.Drawing.Color.White; // White text
            this.txtQuestion.Location = new System.Drawing.Point(28, 83);
            this.txtQuestion.Multiline = true; // --- Make multiline ---
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Add scrollbar
            this.txtQuestion.Size = new System.Drawing.Size(525, 90); // Adjusted size and anchor
            this.txtQuestion.TabIndex = 3; // Next tab index

            //
            // lblOptionA
            //
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOptionA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblOptionA.Location = new System.Drawing.Point(25, 190); // Adjusted position
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(65, 17);
            this.lblOptionA.TabIndex = 4;
            this.lblOptionA.Text = "Option A:";

            //
            // txtOptionA
            //
            this.txtOptionA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOptionA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtOptionA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOptionA.ForeColor = System.Drawing.Color.White;
            this.txtOptionA.Location = new System.Drawing.Point(96, 187);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(457, 25); // Adjusted size and anchor
            this.txtOptionA.TabIndex = 5;

            // --- Option B, C, D - Similar styling ---
            //
            // lblOptionB
            //
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOptionB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblOptionB.Location = new System.Drawing.Point(25, 225); // Adjusted position
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(64, 17);
            this.lblOptionB.TabIndex = 6;
            this.lblOptionB.Text = "Option B:";
            //
            // txtOptionB
            //
            this.txtOptionB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOptionB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtOptionB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOptionB.ForeColor = System.Drawing.Color.White;
            this.txtOptionB.Location = new System.Drawing.Point(96, 222);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(457, 25);
            this.txtOptionB.TabIndex = 7;
            //
            // lblOptionC
            //
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOptionC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblOptionC.Location = new System.Drawing.Point(25, 260); // Adjusted position
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(65, 17);
            this.lblOptionC.TabIndex = 8;
            this.lblOptionC.Text = "Option C:";
            //
            // txtOptionC
            //
            this.txtOptionC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOptionC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtOptionC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOptionC.ForeColor = System.Drawing.Color.White;
            this.txtOptionC.Location = new System.Drawing.Point(96, 257);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(457, 25);
            this.txtOptionC.TabIndex = 9;
            //
            // lblOptionD
            //
            this.lblOptionD.AutoSize = true;
            this.lblOptionD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOptionD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblOptionD.Location = new System.Drawing.Point(25, 295); // Adjusted position
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(66, 17);
            this.lblOptionD.TabIndex = 10;
            this.lblOptionD.Text = "Option D:";
            //
            // txtOptionD
            //
            this.txtOptionD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOptionD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtOptionD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOptionD.ForeColor = System.Drawing.Color.White;
            this.txtOptionD.Location = new System.Drawing.Point(96, 292);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(457, 25);
            this.txtOptionD.TabIndex = 11;

            //
            // gbCorrectAnswer
            //
            this.gbCorrectAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCorrectAnswer.Controls.Add(this.rbCorrectD); // Add in reverse order for desired visual layout
            this.gbCorrectAnswer.Controls.Add(this.rbCorrectC);
            this.gbCorrectAnswer.Controls.Add(this.rbCorrectB);
            this.gbCorrectAnswer.Controls.Add(this.rbCorrectA);
            this.gbCorrectAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbCorrectAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220))))); // GroupBox text color
            this.gbCorrectAnswer.Location = new System.Drawing.Point(28, 335); // Adjusted position
            this.gbCorrectAnswer.Name = "gbCorrectAnswer";
            this.gbCorrectAnswer.Size = new System.Drawing.Size(525, 65); // Adjusted size
            this.gbCorrectAnswer.TabIndex = 12;
            this.gbCorrectAnswer.TabStop = false; // GroupBox itself isn't a tab stop
            this.gbCorrectAnswer.Text = "Correct Answer";

            //
            // rbCorrectD
            //
            this.rbCorrectD.AutoSize = true; // Let it size itself
            this.rbCorrectD.Font = new System.Drawing.Font("Segoe UI", 9.75F); // Regular font for options
            this.rbCorrectD.Location = new System.Drawing.Point(325, 28); // Adjusted position
            this.rbCorrectD.Name = "rbCorrectD";
            this.rbCorrectD.Size = new System.Drawing.Size(35, 21);
            this.rbCorrectD.TabIndex = 3; // Tab index within group
            this.rbCorrectD.TabStop = true; // Allow tabbing
            this.rbCorrectD.Text = "D";
            this.rbCorrectD.UseVisualStyleBackColor = true;

            //
            // rbCorrectC
            //
            this.rbCorrectC.AutoSize = true;
            this.rbCorrectC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbCorrectC.Location = new System.Drawing.Point(225, 28); // Adjusted position
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
            this.rbCorrectB.Location = new System.Drawing.Point(125, 28); // Adjusted position
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
            this.rbCorrectA.Checked = true; // Default check
            this.rbCorrectA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbCorrectA.Location = new System.Drawing.Point(25, 28); // Adjusted position
            this.rbCorrectA.Name = "rbCorrectA";
            this.rbCorrectA.Size = new System.Drawing.Size(34, 21);
            this.rbCorrectA.TabIndex = 0; // First tab stop in group
            this.rbCorrectA.TabStop = true;
            this.rbCorrectA.Text = "A";
            this.rbCorrectA.UseVisualStyleBackColor = true;


            //
            // btnSaveQuestion
            //
            this.btnSaveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right))); // Anchor bottom-right
            this.btnSaveQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))); // Greenish
            this.btnSaveQuestion.FlatAppearance.BorderSize = 0; // No border for flat style
            this.btnSaveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQuestion.ForeColor = System.Drawing.Color.White;
            this.btnSaveQuestion.Location = new System.Drawing.Point(307, 420); // Adjusted position
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(120, 35); // Adjusted size
            this.btnSaveQuestion.TabIndex = 13; // Tab index after groupbox
            this.btnSaveQuestion.Text = "Save"; // Text will be changed by code for Edit mode
            this.btnSaveQuestion.UseVisualStyleBackColor = false; // Important for custom backcolor
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click); // Assign event handler

            //
            // btnCancel
            //
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))); // Dark Gray
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel; // Assign Cancel DialogResult
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(433, 420); // Adjusted position
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 35); // Adjusted size
            this.btnCancel.TabIndex = 14; // Last tab index
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click); // Assign event handler

            //
            // AddQuestionForm
            //
            this.AcceptButton = this.btnSaveQuestion; // Enter key triggers save/update
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F); // Base font scaling
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))); // Dark background
            this.CancelButton = this.btnCancel; // Escape key triggers cancel
            this.ClientSize = new System.Drawing.Size(584, 471); // Adjusted form size
            this.Controls.Add(this.btnCancel); // Add controls to form
            this.Controls.Add(this.btnSaveQuestion);
            this.Controls.Add(this.gbCorrectAnswer);
            this.Controls.Add(this.txtOptionD); // Add in reverse order of creation sometimes helps designer view
            this.Controls.Add(this.lblOptionD);
            this.Controls.Add(this.txtOptionC);
            this.Controls.Add(this.lblOptionC);
            this.Controls.Add(this.txtOptionB);
            this.Controls.Add(this.lblOptionB);
            this.Controls.Add(this.txtOptionA);
            this.Controls.Add(this.lblOptionA);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.lblSubjectInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Set base font
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Prevent resizing
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; // Center relative to parent form
            this.Text = "Add/Edit Question"; // Generic title, code will set specific
            this.gbCorrectAnswer.ResumeLayout(false); // Resume GroupBox layout
            this.gbCorrectAnswer.PerformLayout();
            this.ResumeLayout(false); // Resume Form layout
            this.PerformLayout();

        }

        #endregion

        // --- Control Declarations (Keep these matching the above) ---
        private System.Windows.Forms.Label lblSubjectInfo;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.Label lblOptionD;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.GroupBox gbCorrectAnswer;
        private System.Windows.Forms.RadioButton rbCorrectD; // Declaration order matches visual/tab order
        private System.Windows.Forms.RadioButton rbCorrectC;
        private System.Windows.Forms.RadioButton rbCorrectB;
        private System.Windows.Forms.RadioButton rbCorrectA;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.Button btnCancel;
    }
}