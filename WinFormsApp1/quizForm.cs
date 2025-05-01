// QuizForm.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing; 

namespace QuizierApp
{
   
    public partial class QuizForm : Form
    {
       
        private readonly string _subject;
        private readonly string _username;
        private readonly List<Question> _quizQuestions;
        private readonly Dictionary<int, char?> _userAnswers;

        private int _currentQuestionIndex = 0;
        private int _score = 0;

        // --- Timer Variables ---
        private System.Windows.Forms.Timer _quizTimer; 
        private int _remainingSeconds;
        private bool _timeUp = false;

       
        public QuizForm(string subject, string username, List<Question> questions)
        {
            
            InitializeComponent();

            _subject = subject;
            _username = username;
            _quizQuestions = questions ?? new List<Question>(); 
            _userAnswers = new Dictionary<int, char?>();

            
            InitializeQuizTimer();

           
            if (_quizQuestions.Any()) 
            {
                LoadQuestion(_currentQuestionIndex);
            }
            else
            {
              
                MessageBox.Show("No questions available for this quiz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                gbOptions.Enabled = false;
                btnNext.Enabled = false;
                lblQuestionText.Text = "No questions loaded.";
                
            }


            this.FormClosing -= QuizForm_FormClosing; // Prevent double subscription
            this.FormClosing += QuizForm_FormClosing;
        }

        // --- Timer Methods ---
        private void InitializeQuizTimer()
        {
            int timeLimitMinutes = AppData.QuizTimeLimitMinutes;

            if (this.lblTimer == null)
            {
                Console.WriteLine("ERROR: lblTimer control not found by InitializeQuizTimer.");
                return; 
            }

            if (timeLimitMinutes > 0)
            {
                _remainingSeconds = timeLimitMinutes * 60;
                lblTimer.Visible = true;
                UpdateTimerDisplay();

                _quizTimer = new System.Windows.Forms.Timer();
                _quizTimer.Interval = 1000;
                _quizTimer.Tick += QuizTimer_Tick;
                _quizTimer.Start();
            }
            else
            {
                lblTimer.Visible = false;
            }
        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            _remainingSeconds--;
            UpdateTimerDisplay();

            if (_remainingSeconds <= 0)
            {
                _quizTimer?.Stop(); 
                _timeUp = true;
                lblTimer.Text = "Time's Up!";
                lblTimer.ForeColor = Color.Red;
                gbOptions.Enabled = false;
                btnNext.Enabled = false;

                MessageBox.Show("Time's up! The quiz will now be submitted.", "Time Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                CalculateAndSaveScore();
                DisplayResults(true);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            else if (_remainingSeconds <= 30)
            {
                lblTimer.ForeColor = Color.OrangeRed;
            }
        }

        private void UpdateTimerDisplay()
        {
            if (lblTimer != null && lblTimer.Visible)
            {
                TimeSpan timeSpan = TimeSpan.FromSeconds(_remainingSeconds);
                lblTimer.Text = $"Time Left: {timeSpan:mm\\:ss}";
            }
        }

        // --- Question Loading & Handling Methods ---
        private void LoadQuestion(int index)
        {
            if (index < 0 || index >= _quizQuestions.Count) return; 

            Question currentQuestion = _quizQuestions[index];

            // Safety checks for controls before updating
            if (lblQuestionNumber != null) lblQuestionNumber.Text = $"Question {index + 1} / {_quizQuestions.Count}";
            if (lblQuestionText != null) lblQuestionText.Text = currentQuestion.QuestionText;
            if (rbOptionA != null) rbOptionA.Text = $"A) {currentQuestion.OptionA}";
            if (rbOptionB != null) rbOptionB.Text = $"B) {currentQuestion.OptionB}";
            if (rbOptionC != null) rbOptionC.Text = $"C) {currentQuestion.OptionC}";
            if (rbOptionD != null) rbOptionD.Text = $"D) {currentQuestion.OptionD}";

            ClearSelection();

            if (btnNext != null)
                btnNext.Text = (index == _quizQuestions.Count - 1) ? "Finish" : "Next";
            if (gbOptions != null) gbOptions.Enabled = true;
        }

        private void ClearSelection()
        {
            if (rbOptionA != null) rbOptionA.Checked = false;
            if (rbOptionB != null) rbOptionB.Checked = false;
            if (rbOptionC != null) rbOptionC.Checked = false;
            if (rbOptionD != null) rbOptionD.Checked = false;
        }

        private char? GetSelectedAnswer()
        {
            if (rbOptionA != null && rbOptionA.Checked) return 'A';
            if (rbOptionB != null && rbOptionB.Checked) return 'B';
            if (rbOptionC != null && rbOptionC.Checked) return 'C';
            if (rbOptionD != null && rbOptionD.Checked) return 'D';
            return null;
        }

        // --- Event Handlers ---
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_timeUp) return;

            char? selectedAnswer = GetSelectedAnswer();
            if (selectedAnswer == null)
            {
                MessageBox.Show("Please select an answer before proceeding.", "Answer Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _userAnswers[_currentQuestionIndex] = selectedAnswer;
            if (gbOptions != null) gbOptions.Enabled = false; 

            _currentQuestionIndex++;
            if (_currentQuestionIndex < _quizQuestions.Count)
            {
                LoadQuestion(_currentQuestionIndex);
            }
            else
            {
                _quizTimer?.Stop(); 
                CalculateAndSaveScore();
                DisplayResults(false);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _quizTimer?.Stop();
            _quizTimer?.Dispose(); 
        }


        // --- Scoring and Results Methods ---
        private void CalculateAndSaveScore()
        {
            _score = 0;
            if (_quizQuestions == null) return; 

            for (int i = 0; i < _quizQuestions.Count; i++)
            {
                if (_userAnswers.ContainsKey(i) && _userAnswers[i].HasValue)
                {
                    if (_userAnswers[i].Value == _quizQuestions[i].CorrectAnswerLetter)
                    {
                        _score++;
                    }
                }
            }

            QuizResult result = new QuizResult(_username, _subject, _score, _quizQuestions.Count, DateTime.Now);
            AppData.AllScores.Add(result); 
        }

        private void DisplayResults(bool timedOut)
        {
            int totalQuestions = _quizQuestions?.Count ?? 0; 
            double percentage = totalQuestions > 0 ? ((double)_score / totalQuestions) * 100.0 : 0.0;
            string timeMessage = timedOut ? "\n(Quiz ended because time ran out)" : "";

            MessageBox.Show(
                $"Quiz Complete!{timeMessage}\n\nSubject: {_subject}\nYour Score: {_score} / {totalQuestions} ({percentage:F1}%)\n\nYour results have been saved.",
                "Quiz Results",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    } 
} 