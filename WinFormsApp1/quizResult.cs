// QuizResult.cs
using System;

namespace QuizierApp
{
    public class QuizResult
    {
        public string Username { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }
        public int TotalQuestions { get; set; }
        public DateTime DateTaken { get; set; }

       
        public double Percentage
        {
            get
            {
                return TotalQuestions > 0 ? ((double)Score / TotalQuestions) * 100.0 : 0.0;
            }
        }

       
        public QuizResult(string username, string subject, int score, int totalQuestions, DateTime dateTaken)
        {
            Username = username;
            Subject = subject;
            Score = score;
            TotalQuestions = totalQuestions;
            DateTaken = dateTaken;
        }

        
        public QuizResult() { }

        public override string ToString()
        {
            return $"{Username} - {Subject}: {Score}/{TotalQuestions} ({Percentage:F1}%) on {DateTaken:g}";
        }
    }
}