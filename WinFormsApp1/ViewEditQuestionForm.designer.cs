// In ViewEditQuestionsForm.Designer.cs

namespace QuizierApp
{
    partial class ViewEditQuestionsForm // Ensure this matches your form's class name
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
            // ---- Keep ALL your existing control initializations here ----
            // (e.g., for lstQuestions, btnEditQuestion, btnDeleteQuestion, btnClose)

            // --- ADD Initialization for lblSubjectView ---
            this.lblSubjectView = new System.Windows.Forms.Label();
            this.SuspendLayout(); // Suspend layout might already exist

            //
            // lblSubjectView Properties (Example - Adjust as needed)
            //
            this.lblSubjectView.AutoSize = true; // Or false if you set a specific size
            this.lblSubjectView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectView.Location = new System.Drawing.Point(25, 20); // Example Position
            this.lblSubjectView.Name = "lblSubjectView"; // <<< CRITICAL: Name must match code
            this.lblSubjectView.Size = new System.Drawing.Size(75, 21); // Example Size (adjust if AutoSize=false)
            this.lblSubjectView.TabIndex = 0; // Example Tab Index (usually first)
            this.lblSubjectView.Text = "Subject: [Loading...]"; // Placeholder text

            // --- KEEP the rest of your InitializeComponent method ---
            // (Setting form properties, initializing other controls like lstQuestions, buttons, etc.)

            // --- Ensure lblSubjectView is added to Controls ---
            this.Controls.Add(this.lblSubjectView);

            // --- KEEP existing event handler attachments ----
            // e.g., this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            // e.g., this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // ... other handlers ...

            this.ResumeLayout(false);
            this.PerformLayout(); // Perform layout might already exist
        }

        #endregion

        // --- ADD the declaration for the Label variable ---
        private System.Windows.Forms.Label lblSubjectView;

        // --- KEEP Declarations for your other controls ---
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnClose;
        // ... any other controls declared here ...
    }
}