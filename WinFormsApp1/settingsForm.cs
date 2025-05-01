using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text; 
using System.Windows.Forms;

namespace QuizierApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
            AttachEventHandlers();
        }

        
        private void LoadSettings()
        {
            numTimeLimit.Value = Math.Max(numTimeLimit.Minimum, Math.Min(numTimeLimit.Maximum, AppData.QuizTimeLimitMinutes)); 
            chkRandomizeQuestions.Checked = AppData.RandomizeQuestions;
        }

     
        private void AttachEventHandlers()
        {
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // Data Tab
            this.btnBrowseImport.Click += new System.EventHandler(this.btnBrowseImport_Click);
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            this.btnBrowseExport.Click += new System.EventHandler(this.btnBrowseExport_Click);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            this.btnClearQuestions.Click += new System.EventHandler(this.btnClearQuestions_Click);
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // Quiz Tab
            this.numTimeLimit.ValueChanged += new System.EventHandler(this.numTimeLimit_ValueChanged);
            this.chkRandomizeQuestions.CheckedChanged += new System.EventHandler(this.chkRandomizeQuestions_CheckedChanged);
        }


        // --- Data Management Tab ---

        private void btnBrowseImport_Click(object sender, EventArgs e)
        {
            if (openFileDialogImport.ShowDialog() == DialogResult.OK)
            {
                txtImportFilePath.Text = openFileDialogImport.FileName;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string filePath = txtImportFilePath.Text;
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Please select a valid CSV file to import.", "File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int importedCount = 0;
            int errorCount = 0;
            List<Question> questionsToAdd = new List<Question>();
            List<string> errorMessages = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length <= 1) 
                {
                    MessageBox.Show("The selected file is empty or contains only a header row.", "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                for (int i = 0; i < lines.Length; i++)
                {
                    
                    if (i == 0 && lines[i].ToLowerInvariant().Contains("subject") && lines[i].ToLowerInvariant().Contains("questiontext"))
                    {
                        Console.WriteLine("Skipping detected header row.");
                        continue; 
                    }

                    string line = lines[i];
                    if (string.IsNullOrWhiteSpace(line)) continue; 

                    string[] parts = line.Split(','); 


                    if (parts.Length != 7)
                    {
                        errorMessages.Add($"Line {i + 1}: Invalid number of columns (Expected 7, Found {parts.Length}). Line skipped.");
                        errorCount++;
                        continue;
                    }

                    string subject = parts[0].Trim();
                    string qText = parts[1].Trim();
                    string optA = parts[2].Trim();
                    string optB = parts[3].Trim();
                    string optC = parts[4].Trim();
                    string optD = parts[5].Trim();
                    string correctLetterStr = parts[6].Trim().ToUpper();

                    // Basic validation
                    if (string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(qText) ||
                        string.IsNullOrWhiteSpace(optA) || string.IsNullOrWhiteSpace(optB) ||
                        string.IsNullOrWhiteSpace(optC) || string.IsNullOrWhiteSpace(optD))
                    {
                        errorMessages.Add($"Line {i + 1}: One or more fields are empty. Line skipped.");
                        errorCount++;
                        continue;
                    }

                    if (correctLetterStr.Length != 1 || !"ABCD".Contains(correctLetterStr))
                    {
                        errorMessages.Add($"Line {i + 1}: Invalid correct answer letter ('{correctLetterStr}'). Must be A, B, C, or D. Line skipped.");
                        errorCount++;
                        continue;
                    }

                    char correctLetter = correctLetterStr[0];

                   
             
                    questionsToAdd.Add(new Question(subject, qText, optA, optB, optC, optD, correctLetter));
                    importedCount++;
                }

              
                AppData.AllQuestions.AddRange(questionsToAdd);

                StringBuilder report = new StringBuilder();
                report.AppendLine($"Import process finished.");
                report.AppendLine($"Successfully imported: {importedCount} question(s).");
                report.AppendLine($"Errors encountered (lines skipped): {errorCount}.");

                if (errorMessages.Any())
                {
                    report.AppendLine("\nErrors:");
                    errorMessages.Take(10).ToList().ForEach(em => report.AppendLine($"- {em}"));
                    if (errorMessages.Count > 10) report.AppendLine("... (more errors truncated)");
                }

                MessageBox.Show(report.ToString(), "Import Report", MessageBoxButtons.OK, errorCount > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during import:\n{ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                txtExportFilePath.Text = saveFileDialogExport.FileName;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string filePath = txtExportFilePath.Text;
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Please select a file path to export to.", "File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!AppData.AllQuestions.Any())
            {
                MessageBox.Show("There are no questions to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Subject,QuestionText,OptionA,OptionB,OptionC,OptionD,CorrectAnswerLetter");

                    foreach (var q in AppData.AllQuestions)
                    {
                       
                        writer.WriteLine(string.Join(",",
                            EscapeCsvField(q.Subject),
                            EscapeCsvField(q.QuestionText), 
                            EscapeCsvField(q.OptionA),      
                            EscapeCsvField(q.OptionB),      
                            EscapeCsvField(q.OptionC),      
                            EscapeCsvField(q.OptionD),      
                            q.CorrectAnswerLetter           
                        ));
                    }
                } 

                MessageBox.Show($"Successfully exported {AppData.AllQuestions.Count} questions to:\n{filePath}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during export:\n{ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field)) return "";
            
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n") || field.Contains("\r"))
            {
                
                return $"\"{field.Replace("\"", "\"\"")}\"";
            }
            return field;
        }


        private void btnClearQuestions_Click(object sender, EventArgs e)
        {
            if (!AppData.AllQuestions.Any())
            {
                MessageBox.Show("There are no questions to clear.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm1 = MessageBox.Show(
                "Are you sure you want to delete ALL questions?\nThis action cannot be undone.",
                "Confirm Clear Questions (1/2)",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (confirm1 == DialogResult.Yes)
            {
                var confirm2 = MessageBox.Show(
                   "FINAL WARNING:\nReally delete every question in the application?",
                   "Confirm Clear Questions (2/2)",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (confirm2 == DialogResult.Yes)
                {
                    AppData.AllQuestions.Clear();
                    MessageBox.Show("All questions have been cleared.", "Questions Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            if (!AppData.AllScores.Any())
            {
                MessageBox.Show("There are no scores to clear.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm1 = MessageBox.Show(
               "Are you sure you want to delete ALL recorded scores?\nThis action cannot be undone.",
               "Confirm Clear Scores (1/2)",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (confirm1 == DialogResult.Yes)
            {
                var confirm2 = MessageBox.Show(
                   "FINAL WARNING:\nReally delete every score record in the application?",
                   "Confirm Clear Scores (2/2)",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (confirm2 == DialogResult.Yes)
                {
                    AppData.AllScores.Clear();
                    MessageBox.Show("All scores have been cleared.", "Scores Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
        }

        // --- Quiz Rules Tab ---

        private void numTimeLimit_ValueChanged(object sender, EventArgs e)
        {
            
            AppData.QuizTimeLimitMinutes = (int)numTimeLimit.Value;
        }

        private void chkRandomizeQuestions_CheckedChanged(object sender, EventArgs e)
        {
            
            AppData.RandomizeQuestions = chkRandomizeQuestions.Checked;
        }


        // --- Common ---

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}