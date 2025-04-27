// SettingsForm.Designer.cs
namespace QuizierApp
{
    partial class SettingsForm
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
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.grpClearData = new System.Windows.Forms.GroupBox();
            this.labelClearWarning = new System.Windows.Forms.Label();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnClearQuestions = new System.Windows.Forms.Button();
            this.grpExport = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnBrowseExport = new System.Windows.Forms.Button();
            this.txtExportFilePath = new System.Windows.Forms.TextBox();
            this.labelExportPath = new System.Windows.Forms.Label();
            this.grpImport = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnBrowseImport = new System.Windows.Forms.Button();
            this.txtImportFilePath = new System.Windows.Forms.TextBox();
            this.labelImportPath = new System.Windows.Forms.Label();
            this.labelImportFormat = new System.Windows.Forms.Label();
            this.tabPageQuiz = new System.Windows.Forms.TabPage();
            this.grpRandomization = new System.Windows.Forms.GroupBox();
            this.chkRandomizeQuestions = new System.Windows.Forms.CheckBox();
            this.grpTimeLimit = new System.Windows.Forms.GroupBox();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.numTimeLimit = new System.Windows.Forms.NumericUpDown();
            this.labelTimeLimit = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.tabControlSettings.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.grpClearData.SuspendLayout();
            this.grpExport.SuspendLayout();
            this.grpImport.SuspendLayout();
            this.tabPageQuiz.SuspendLayout();
            this.grpRandomization.SuspendLayout();
            this.grpTimeLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeLimit)).BeginInit();
            this.SuspendLayout();
            //
            // tabControlSettings
            //
            this.tabControlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSettings.Controls.Add(this.tabPageData);
            this.tabControlSettings.Controls.Add(this.tabPageQuiz);
            this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(560, 438);
            this.tabControlSettings.TabIndex = 0;
            //
            // tabPageData
            //
            this.tabPageData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))); // Slightly lighter dark background for tab page
            this.tabPageData.Controls.Add(this.grpClearData);
            this.tabPageData.Controls.Add(this.grpExport);
            this.tabPageData.Controls.Add(this.grpImport);
            this.tabPageData.Location = new System.Drawing.Point(4, 24);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(552, 410);
            this.tabPageData.TabIndex = 0;
            this.tabPageData.Text = "Data Management";
            //
            // grpClearData
            //
            this.grpClearData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClearData.Controls.Add(this.labelClearWarning);
            this.grpClearData.Controls.Add(this.btnClearScores);
            this.grpClearData.Controls.Add(this.btnClearQuestions);
            this.grpClearData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.grpClearData.Location = new System.Drawing.Point(15, 290); // Position below Export
            this.grpClearData.Name = "grpClearData";
            this.grpClearData.Size = new System.Drawing.Size(521, 105);
            this.grpClearData.TabIndex = 2;
            this.grpClearData.TabStop = false;
            this.grpClearData.Text = "Clear Application Data";
            //
            // labelClearWarning
            //
            this.labelClearWarning.AutoSize = true;
            this.labelClearWarning.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClearWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelClearWarning.Location = new System.Drawing.Point(15, 28);
            this.labelClearWarning.Name = "labelClearWarning";
            this.labelClearWarning.Size = new System.Drawing.Size(258, 17);
            this.labelClearWarning.TabIndex = 2;
            this.labelClearWarning.Text = "Warning: These actions are irreversible!";
            //
            // btnClearScores
            //
            this.btnClearScores.BackColor = System.Drawing.Color.Firebrick;
            this.btnClearScores.FlatAppearance.BorderSize = 0;
            this.btnClearScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearScores.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearScores.ForeColor = System.Drawing.Color.White;
            this.btnClearScores.Location = new System.Drawing.Point(201, 58);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(150, 30);
            this.btnClearScores.TabIndex = 1;
            this.btnClearScores.Text = "Clear All Scores";
            this.btnClearScores.UseVisualStyleBackColor = false;
            // Click handler assigned in code-behind
            //
            // btnClearQuestions
            //
            this.btnClearQuestions.BackColor = System.Drawing.Color.Firebrick;
            this.btnClearQuestions.FlatAppearance.BorderSize = 0;
            this.btnClearQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearQuestions.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearQuestions.ForeColor = System.Drawing.Color.White;
            this.btnClearQuestions.Location = new System.Drawing.Point(18, 58);
            this.btnClearQuestions.Name = "btnClearQuestions";
            this.btnClearQuestions.Size = new System.Drawing.Size(150, 30);
            this.btnClearQuestions.TabIndex = 0;
            this.btnClearQuestions.Text = "Clear All Questions";
            this.btnClearQuestions.UseVisualStyleBackColor = false;
            // Click handler assigned in code-behind
            //
            // grpExport
            //
            this.grpExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExport.Controls.Add(this.btnExport);
            this.grpExport.Controls.Add(this.btnBrowseExport);
            this.grpExport.Controls.Add(this.txtExportFilePath);
            this.grpExport.Controls.Add(this.labelExportPath);
            this.grpExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.grpExport.Location = new System.Drawing.Point(15, 161); // Position below Import
            this.grpExport.Name = "grpExport";
            this.grpExport.Size = new System.Drawing.Size(521, 112);
            this.grpExport.TabIndex = 1;
            this.grpExport.TabStop = false;
            this.grpExport.Text = "Export Questions (CSV)";
            //
            // btnExport
            //
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(396, 68);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(106, 28);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export Now";
            this.btnExport.UseVisualStyleBackColor = false;
            // Click handler assigned in code-behind
            //
            // btnBrowseExport
            //
            this.btnBrowseExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnBrowseExport.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBrowseExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseExport.ForeColor = System.Drawing.Color.White;
            this.btnBrowseExport.Location = new System.Drawing.Point(396, 34);
            this.btnBrowseExport.Name = "btnBrowseExport";
            this.btnBrowseExport.Size = new System.Drawing.Size(106, 28);
            this.btnBrowseExport.TabIndex = 2;
            this.btnBrowseExport.Text = "Browse...";
            this.btnBrowseExport.UseVisualStyleBackColor = false;
            // Click handler assigned in code-behind
            //
            // txtExportFilePath
            //
            this.txtExportFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExportFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtExportFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExportFilePath.ForeColor = System.Drawing.Color.White;
            this.txtExportFilePath.Location = new System.Drawing.Point(18, 37);
            this.txtExportFilePath.Name = "txtExportFilePath";
            this.txtExportFilePath.ReadOnly = true;
            this.txtExportFilePath.Size = new System.Drawing.Size(372, 23);
            this.txtExportFilePath.TabIndex = 1;
            //
            // labelExportPath
            //
            this.labelExportPath.AutoSize = true;
            this.labelExportPath.Location = new System.Drawing.Point(15, 19);
            this.labelExportPath.Name = "labelExportPath";
            this.labelExportPath.Size = new System.Drawing.Size(88, 15);
            this.labelExportPath.TabIndex = 0;
            this.labelExportPath.Text = "Export File Path:";
            //
            // grpImport
            //
            this.grpImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpImport.Controls.Add(this.btnImport);
            this.grpImport.Controls.Add(this.btnBrowseImport);
            this.grpImport.Controls.Add(this.txtImportFilePath);
            this.grpImport.Controls.Add(this.labelImportPath);
            this.grpImport.Controls.Add(this.labelImportFormat);
            this.grpImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.grpImport.Location = new System.Drawing.Point(15, 15);
            this.grpImport.Name = "grpImport";
            this.grpImport.Size = new System.Drawing.Size(521, 130);
            this.grpImport.TabIndex = 0;
            this.grpImport.TabStop = false;
            this.grpImport.Text = "Import Questions (CSV)";
            //
            // btnImport
            //
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(396, 89);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(106, 28);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import Now";
            this.btnImport.UseVisualStyleBackColor = false;
            // Click handler assigned in code-behind
            //
            // btnBrowseImport
            //
            this.btnBrowseImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnBrowseImport.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBrowseImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImport.ForeColor = System.Drawing.Color.White;
            this.btnBrowseImport.Location = new System.Drawing.Point(396, 55);
            this.btnBrowseImport.Name = "btnBrowseImport";
            this.btnBrowseImport.Size = new System.Drawing.Size(106, 28);
            this.btnBrowseImport.TabIndex = 3;
            this.btnBrowseImport.Text = "Browse...";
            this.btnBrowseImport.UseVisualStyleBackColor = false;
            // Click handler assigned in code-behind
            //
            // txtImportFilePath
            //
            this.txtImportFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImportFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtImportFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImportFilePath.ForeColor = System.Drawing.Color.White;
            this.txtImportFilePath.Location = new System.Drawing.Point(18, 58);
            this.txtImportFilePath.Name = "txtImportFilePath";
            this.txtImportFilePath.ReadOnly = true;
            this.txtImportFilePath.Size = new System.Drawing.Size(372, 23);
            this.txtImportFilePath.TabIndex = 2;
            //
            // labelImportPath
            //
            this.labelImportPath.AutoSize = true;
            this.labelImportPath.Location = new System.Drawing.Point(15, 40);
            this.labelImportPath.Name = "labelImportPath";
            this.labelImportPath.Size = new System.Drawing.Size(89, 15);
            this.labelImportPath.TabIndex = 1;
            this.labelImportPath.Text = "Import File Path:";
            //
            // labelImportFormat
            //
            this.labelImportFormat.AutoSize = true;
            this.labelImportFormat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImportFormat.ForeColor = System.Drawing.Color.Silver;
            this.labelImportFormat.Location = new System.Drawing.Point(15, 19);
            this.labelImportFormat.Name = "labelImportFormat";
            this.labelImportFormat.Size = new System.Drawing.Size(375, 13);
            this.labelImportFormat.TabIndex = 0;
            this.labelImportFormat.Text = "Format: Subject,QuestionText,OptionA,OptionB,OptionC,OptionD,CorrectLetter(A/B/C/D)";
            //
            // tabPageQuiz
            //
            this.tabPageQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tabPageQuiz.Controls.Add(this.grpRandomization);
            this.tabPageQuiz.Controls.Add(this.grpTimeLimit);
            this.tabPageQuiz.Location = new System.Drawing.Point(4, 24);
            this.tabPageQuiz.Name = "tabPageQuiz";
            this.tabPageQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuiz.Size = new System.Drawing.Size(552, 410);
            this.tabPageQuiz.TabIndex = 1;
            this.tabPageQuiz.Text = "Quiz Rules";
            //
            // grpRandomization
            //
            this.grpRandomization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRandomization.Controls.Add(this.chkRandomizeQuestions);
            this.grpRandomization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.grpRandomization.Location = new System.Drawing.Point(15, 95); // Position below time limit
            this.grpRandomization.Name = "grpRandomization";
            this.grpRandomization.Size = new System.Drawing.Size(521, 65);
            this.grpRandomization.TabIndex = 1;
            this.grpRandomization.TabStop = false;
            this.grpRandomization.Text = "Question Order";
            //
            // chkRandomizeQuestions
            //
            this.chkRandomizeQuestions.AutoSize = true;
            this.chkRandomizeQuestions.Location = new System.Drawing.Point(18, 28);
            this.chkRandomizeQuestions.Name = "chkRandomizeQuestions";
            this.chkRandomizeQuestions.Size = new System.Drawing.Size(218, 19);
            this.chkRandomizeQuestions.TabIndex = 0;
            this.chkRandomizeQuestions.Text = "Randomize question order during quiz";
            this.chkRandomizeQuestions.UseVisualStyleBackColor = true;
            // CheckedChanged handler assigned in code-behind
            //
            // grpTimeLimit
            //
            this.grpTimeLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimeLimit.Controls.Add(this.labelMinutes);
            this.grpTimeLimit.Controls.Add(this.numTimeLimit);
            this.grpTimeLimit.Controls.Add(this.labelTimeLimit);
            this.grpTimeLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.grpTimeLimit.Location = new System.Drawing.Point(15, 15);
            this.grpTimeLimit.Name = "grpTimeLimit";
            this.grpTimeLimit.Size = new System.Drawing.Size(521, 65);
            this.grpTimeLimit.TabIndex = 0;
            this.grpTimeLimit.TabStop = false;
            this.grpTimeLimit.Text = "Quiz Duration";
            //
            // labelMinutes
            //
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(204, 30);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(101, 15);
            this.labelMinutes.TabIndex = 2;
            this.labelMinutes.Text = "minutes (0 = none)";
            //
            // numTimeLimit
            //
            this.numTimeLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numTimeLimit.ForeColor = System.Drawing.Color.White;
            this.numTimeLimit.Location = new System.Drawing.Point(131, 28);
            this.numTimeLimit.Maximum = new decimal(new int[] {
            180, // Max 3 hours
            0,
            0,
            0});
            this.numTimeLimit.Name = "numTimeLimit";
            this.numTimeLimit.Size = new System.Drawing.Size(67, 23);
            this.numTimeLimit.TabIndex = 1;
            this.numTimeLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // ValueChanged handler assigned in code-behind
            //
            // labelTimeLimit
            //
            this.labelTimeLimit.AutoSize = true;
            this.labelTimeLimit.Location = new System.Drawing.Point(15, 30);
            this.labelTimeLimit.Name = "labelTimeLimit";
            this.labelTimeLimit.Size = new System.Drawing.Size(110, 15);
            this.labelTimeLimit.TabIndex = 0;
            this.labelTimeLimit.Text = "Default Time Limit:";
            //
            // btnClose
            //
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(456, 465); // Position at bottom right
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // Click handler assigned in code-behind
            //
            // openFileDialogImport
            //
            this.openFileDialogImport.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            this.openFileDialogImport.Title = "Select Question File to Import";
            //
            // saveFileDialogExport
            //
            this.saveFileDialogExport.DefaultExt = "csv";
            this.saveFileDialogExport.FileName = "quizier_questions.csv";
            this.saveFileDialogExport.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            this.saveFileDialogExport.Title = "Export Questions As";
            //
            // SettingsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))); // Dark background
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(584, 512); // Adjusted form size
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControlSettings);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220))))); // Default text color
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Settings";
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            this.grpClearData.ResumeLayout(false);
            this.grpClearData.PerformLayout();
            this.grpExport.ResumeLayout(false);
            this.grpExport.PerformLayout();
            this.grpImport.ResumeLayout(false);
            this.grpImport.PerformLayout();
            this.tabPageQuiz.ResumeLayout(false);
            this.grpRandomization.ResumeLayout(false);
            this.grpRandomization.PerformLayout();
            this.grpTimeLimit.ResumeLayout(false);
            this.grpTimeLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.TabPage tabPageQuiz;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpImport;
        private System.Windows.Forms.Label labelImportFormat;
        private System.Windows.Forms.GroupBox grpExport;
        private System.Windows.Forms.GroupBox grpClearData;
        private System.Windows.Forms.GroupBox grpRandomization;
        private System.Windows.Forms.GroupBox grpTimeLimit;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnBrowseImport;
        private System.Windows.Forms.TextBox txtImportFilePath;
        private System.Windows.Forms.Label labelImportPath;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnBrowseExport;
        private System.Windows.Forms.TextBox txtExportFilePath;
        private System.Windows.Forms.Label labelExportPath;
        private System.Windows.Forms.Label labelClearWarning;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnClearQuestions;
        private System.Windows.Forms.CheckBox chkRandomizeQuestions;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.NumericUpDown numTimeLimit;
        private System.Windows.Forms.Label labelTimeLimit;
        private System.Windows.Forms.OpenFileDialog openFileDialogImport;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
    }
}