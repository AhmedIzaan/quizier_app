// AppData.cs
using System.Collections.Generic;

namespace QuizierApp
{
    public static class AppData
    {
        public static List<Question> AllQuestions { get; private set; } = new List<Question>();
        public static List<QuizResult> AllScores { get; private set; } = new List<QuizResult>();

        
        public static int QuizTimeLimitMinutes { get; set; } = 10; 


        public static bool RandomizeQuestions { get; set; } = true; 

    
    }
}