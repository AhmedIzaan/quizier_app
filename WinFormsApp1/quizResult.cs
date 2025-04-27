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

        // Optional: Calculated property for percentage
        public double Percentage
        {
            get
            {
                return TotalQuestions > 0 ? ((double)Score / TotalQuestions) * 100.0 : 0.0;
            }
        }

        // Constructor (optional but helpful)
        public QuizResult(string username, string subject, int score, int totalQuestions, DateTime dateTaken)
        {
            Username = username;
            Subject = subject;
            Score = score;
            TotalQuestions = totalQuestions;
            DateTaken = dateTaken;
        }

        // Parameterless constructor (needed for some scenarios)
        public QuizResult() { }

        // Override ToString for potential simple display later
        public override string ToString()
        {
            return $"{Username} - {Subject}: {Score}/{TotalQuestions} ({Percentage:F1}%) on {DateTaken:g}";
        }
    }
}