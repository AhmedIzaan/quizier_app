// ViewScoresForm.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq; // For OrderBy

namespace QuizierApp
{
    public partial class ViewScoresForm : Form
    {
        // Store a reference or copy of the scores passed in
        private readonly List<QuizResult> _scores;

        public ViewScoresForm(List<QuizResult> allScores)
        {
            InitializeComponent();
            // It's often safer to work with a copy or filtered/ordered list
            _scores = allScores.OrderByDescending(s => s.DateTaken).ToList(); // Show newest first
            LoadScores();
        }

        private void LoadScores()
        {
            // Configure DataGridView columns (can also be done in designer)
            dgvScores.AutoGenerateColumns = false; // Important! Define columns manually
            dgvScores.Columns.Clear(); // Clear existing columns if any

            dgvScores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUsername",
                DataPropertyName = "Username",
                HeaderText = "User",
                Width = 120
            });
            dgvScores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSubject",
                DataPropertyName = "Subject",
                HeaderText = "Subject",
                Width = 120
            });
            dgvScores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colScore",
                DataPropertyName = "Score",
                HeaderText = "Score",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvScores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTotal",
                DataPropertyName = "TotalQuestions",
                HeaderText = "Total",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvScores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPercentage",
                DataPropertyName = "Percentage",
                HeaderText = "%",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "F1", Alignment = DataGridViewContentAlignment.MiddleCenter } // Format as 1 decimal place
            });
            dgvScores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDate",
                DataPropertyName = "DateTaken",
                HeaderText = "Date Taken",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "g" } // General date/time short time
            });


            // Set the DataSource
            dgvScores.DataSource = _scores;

            // Optional: Adjust other grid properties
            dgvScores.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            dgvScores.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvScores.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(55, 55, 55); // Darker alternating rows
            dgvScores.BackgroundColor = System.Drawing.Color.FromArgb(60, 60, 60);
            dgvScores.GridColor = System.Drawing.Color.Gray;

        }

        private void btnCloseScores_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Windows Form Designer generated code
        // (Generate via designer)
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvScores = new System.Windows.Forms.DataGridView();
            this.btnCloseScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz Scores";
            //
            // dgvScores
            //
            this.dgvScores.AllowUserToAddRows = false;
            this.dgvScores.AllowUserToDeleteRows = false;
            this.dgvScores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvScores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvScores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvScores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScores.ColumnHeadersHeight = 30;
            this.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScores.EnableHeadersVisualStyles = false;
            this.dgvScores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgvScores.Location = new System.Drawing.Point(30, 60);
            this.dgvScores.MultiSelect = false;
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.ReadOnly = true;
            this.dgvScores.RowHeadersVisible = false;
            this.dgvScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScores.Size = new System.Drawing.Size(720, 350); // Example size
            this.dgvScores.TabIndex = 1;
            //
            // btnCloseScores
            //
            this.btnCloseScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCloseScores.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseScores.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCloseScores.ForeColor = System.Drawing.Color.White;
            this.btnCloseScores.Location = new System.Drawing.Point(650, 425); // Position bottom right
            this.btnCloseScores.Name = "btnCloseScores";
            this.btnCloseScores.Size = new System.Drawing.Size(100, 35);
            this.btnCloseScores.TabIndex = 2;
            this.btnCloseScores.Text = "Close";
            this.btnCloseScores.UseVisualStyleBackColor = false;
            this.btnCloseScores.Click += new System.EventHandler(this.btnCloseScores_Click);
            //
            // ViewScoresForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CancelButton = this.btnCloseScores;
            this.ClientSize = new System.Drawing.Size(784, 481); // Example size
            this.Controls.Add(this.btnCloseScores);
            this.Controls.Add(this.dgvScores);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(600, 400); // Minimum size
            this.Name = "ViewScoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Scores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvScores;
        private System.Windows.Forms.Button btnCloseScores;
    }
}