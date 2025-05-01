// In ViewEditQuestionsForm.Designer.cs

namespace QuizierApp
{
    partial class ViewEditQuestionsForm 
    {
       
        private System.ComponentModel.IContainer components = null;

        
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

        private void InitializeComponent()
        {
            
            this.lblSubjectView = new System.Windows.Forms.Label();
            this.SuspendLayout(); 

            //
            // lblSubjectView Properties 
            //
            this.lblSubjectView.AutoSize = true; 
            this.lblSubjectView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectView.Location = new System.Drawing.Point(25, 20); 
            this.lblSubjectView.Name = "lblSubjectView"; 
            this.lblSubjectView.Size = new System.Drawing.Size(75, 21); 
            this.lblSubjectView.TabIndex = 0; 
            this.lblSubjectView.Text = "Subject: [Loading...]"; // Placeholder text



            this.Controls.Add(this.lblSubjectView);


            this.ResumeLayout(false);
            this.PerformLayout(); 
        }

        #endregion

        private System.Windows.Forms.Label lblSubjectView;

        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnClose;
       
    }
}