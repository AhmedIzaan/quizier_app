// AppData.cs
using System.Collections.Generic;

namespace QuizierApp
{
    public static class AppData
    {
        public static List<Question> AllQuestions { get; private set; } = new List<Question>();
        public static List<QuizResult> AllScores { get; private set; } = new List<QuizResult>();

        // --- ADDED Settings Properties ---
        /// <summary>
        /// Default time limit for quizzes in minutes. 0 means no limit.
        /// </summary>
        public static int QuizTimeLimitMinutes { get; set; } = 30; // Default to 30 minutes

        /// <summary>
        /// Whether questions should be presented in a random order during a quiz.
        /// </summary>
        public static bool RandomizeQuestions { get; set; } = true; // Default to true (randomized)

        // --- End ADDED Settings ---
    }
}