// Question.cs
using System; 
namespace QuizierApp
{

    public class Question
    {
        public string Subject { get; set; }

        public string QuestionText { get; set; }

       
        public string OptionA { get; set; }

        
        public string OptionB { get; set; }

       
        public string OptionC { get; set; }

        
        public string OptionD { get; set; }

        public char CorrectAnswerLetter { get; set; }

       
       /// <param name="subject"
        /// <param name="questionText"
        /// <param name="optA"
        /// <param name="optB"
        /// <param name="optC"
        /// <param name="optD"
        /// <param name="correct"
        public Question(string subject, string questionText, string optA, string optB, string optC, string optD, char correct)
        {
            
            this.Subject = subject;
            this.QuestionText = questionText;
            this.OptionA = optA;
            this.OptionB = optB;
            this.OptionC = optC;
            this.OptionD = optD;
            this.CorrectAnswerLetter = correct;
         
        }

       
        /// Initializes a new instance of the <see cref="Question"/> class. 
        /// </summary>
        public Question() { } 

       
        public override string ToString()
        {
           
            int maxLength = 70;
            string displayText = QuestionText ?? "[No Question Text]"; 
            if (displayText.Length > maxLength)
            {
                return displayText.Substring(0, maxLength) + "...";
            }
            return displayText;

            
        }
    }
}