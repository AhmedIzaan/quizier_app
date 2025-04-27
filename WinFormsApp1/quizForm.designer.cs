// QuizForm.Designer.cs
namespace QuizierApp
{
    partial class QuizForm
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
            // --- Ensure timer is disposed ---
            if (disposing && (_quizTimer != null))
            {
                _quizTimer.Dispose();
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.rbOptionD = new System.Windows.Forms.RadioButton();
            this.rbOptionC = new System.Windows.Forms.RadioButton();
            this.rbOptionB = new System.Windows.Forms.RadioButton();
            this.rbOptionA = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTimer
            //
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblTimer.Location = new System.Drawing.Point(629, 20); // Adjust position as needed
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(133, 20);   // Adjust size as needed
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "Time Left: 00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTimer.Visible = false;
            //
            // lblQuestionNumber
            //
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblQuestionNumber.Location = new System.Drawing.Point(25, 20);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(118, 20);
            this.lblQuestionNumber.TabIndex = 0;
            this.lblQuestionNumber.Text = "Question X / Y";
            //
            // lblQuestionText
            //
            this.lblQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblQuestionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestionText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.ForeColor = System.Drawing.Color.White;
            this.lblQuestionText.Location = new System.Drawing.Point(29, 55);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Padding = new System.Windows.Forms.Padding(5);
            this.lblQuestionText.Size = new System.Drawing.Size(720, 120);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "[Question text will appear here]";
            //
            // gbOptions
            //
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.rbOptionD);
            this.gbOptions.Controls.Add(this.rbOptionC);
            this.gbOptions.Controls.Add(this.rbOptionB);
            this.gbOptions.Controls.Add(this.rbOptionA);
            this.gbOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbOptions.Location = new System.Drawing.Point(29, 190);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.gbOptions.Size = new System.Drawing.Size(720, 200);
            this.gbOptions.TabIndex = 2;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Select your answer:";
            //
            // rbOptionD
            //
            this.rbOptionD.AutoSize = true;
            this.rbOptionD.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rbOptionD.Location = new System.Drawing.Point(13, 150);
            this.rbOptionD.MinimumSize = new System.Drawing.Size(0, 30);
            this.rbOptionD.Name = "rbOptionD";
            this.rbOptionD.Size = new System.Drawing.Size(88, 30);
            this.rbOptionD.TabIndex = 3;
            this.rbOptionD.TabStop = true;
            this.rbOptionD.Text = "Option D";
            this.rbOptionD.UseVisualStyleBackColor = true;
            //
            // rbOptionC
            //
            this.rbOptionC.AutoSize = true;
            this.rbOptionC.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rbOptionC.Location = new System.Drawing.Point(13, 110);
            this.rbOptionC.MinimumSize = new System.Drawing.Size(0, 30);
            this.rbOptionC.Name = "rbOptionC";
            this.rbOptionC.Size = new System.Drawing.Size(87, 30);
            this.rbOptionC.TabIndex = 2;
            this.rbOptionC.TabStop = true;
            this.rbOptionC.Text = "Option C";
            this.rbOptionC.UseVisualStyleBackColor = true;
            //
            // rbOptionB
            //
            this.rbOptionB.AutoSize = true;
            this.rbOptionB.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rbOptionB.Location = new System.Drawing.Point(13, 70);
            this.rbOptionB.MinimumSize = new System.Drawing.Size(0, 30);
            this.rbOptionB.Name = "rbOptionB";
            this.rbOptionB.Size = new System.Drawing.Size(86, 30);
            this.rbOptionB.TabIndex = 1;
            this.rbOptionB.TabStop = true;
            this.rbOptionB.Text = "Option B";
            this.rbOptionB.UseVisualStyleBackColor = true;
            //
            // rbOptionA
            //
            this.rbOptionA.AutoSize = true;
            this.rbOptionA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionA.Location = new System.Drawing.Point(13, 30);
            this.rbOptionA.MinimumSize = new System.Drawing.Size(0, 30);
            this.rbOptionA.Name = "rbOptionA";
            this.rbOptionA.Size = new System.Drawing.Size(87, 30);
            this.rbOptionA.TabIndex = 0;
            this.rbOptionA.TabStop = true;
            this.rbOptionA.Text = "Option A";
            this.rbOptionA.UseVisualStyleBackColor = true;
            //
            // btnNext
            //
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(609, 405); // Adjust position
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(140, 45);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // --- Attach Event Handler ---
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            //
            // QuizForm
            //
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(774, 471);
            this.Controls.Add(this.lblTimer); // Ensure timer label is added
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.lblQuestionNumber);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quiz in Progress";
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        // --- Control Declarations ---
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rbOptionD;
        private System.Windows.Forms.RadioButton rbOptionC;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.Button btnNext;

    } // End Class
} // End Namespace