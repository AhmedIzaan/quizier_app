// Question.cs
using System; // Added for StringComparison, though not strictly needed just for properties/constructors

namespace QuizierApp
{
    /// <summary>
    /// Represents a single question in the quiz, including its text, options, subject, and correct answer.
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Gets or sets the subject category this question belongs to (e.g., "Math", "History").
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the main text of the question.
        /// </summary>
        public string QuestionText { get; set; }

        /// <summary>
        /// Gets or sets the text for the first multiple-choice option (A).
        /// </summary>
        public string OptionA { get; set; }

        /// <summary>
        /// Gets or sets the text for the second multiple-choice option (B).
        /// </summary>
        public string OptionB { get; set; }

        /// <summary>
        /// Gets or sets the text for the third multiple-choice option (C).
        /// </summary>
        public string OptionC { get; set; }

        /// <summary>
        /// Gets or sets the text for the fourth multiple-choice option (D).
        /// </summary>
        public string OptionD { get; set; }

        /// <summary>
        /// Gets or sets the letter representing the correct option ('A', 'B', 'C', or 'D').
        /// </summary>
        public char CorrectAnswerLetter { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Question"/> class with specified details.
        /// </summary>
        /// <param name="subject">The subject category.</param>
        /// <param name="questionText">The text of the question.</param>
        /// <param name="optA">The text for option A.</param>
        /// <param name="optB">The text for option B.</param>
        /// <param name="optC">The text for option C.</param>
        /// <param name="optD">The text for option D.</param>
        /// <param name="correct">The character ('A', 'B', 'C', 'D') indicating the correct answer.</param>
        public Question(string subject, string questionText, string optA, string optB, string optC, string optD, char correct)
        {
            // --- MODIFICATION: Implemented constructor body ---
            this.Subject = subject;
            this.QuestionText = questionText;
            this.OptionA = optA;
            this.OptionB = optB;
            this.OptionC = optC;
            this.OptionD = optD;
            this.CorrectAnswerLetter = correct;
            // --- END MODIFICATION ---
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Question"/> class. (Parameterless constructor needed for some operations like deserialization).
        /// </summary>
        public Question() { } // No changes needed here

        /// <summary>
        /// Returns a string that represents the current question, suitable for display in lists.
        /// Displays the question text, truncated if necessary.
        /// </summary>
        /// <returns>A string representation of the question (primarily its text).</returns>
        public override string ToString()
        {
            // This implementation is reasonable for the ListBox display. No change needed unless you prefer a different format.
            int maxLength = 70; // Increased length slightly for better readability
            string displayText = QuestionText ?? "[No Question Text]"; // Handle potential null, more descriptive placeholder
            if (displayText.Length > maxLength)
            {
                return displayText.Substring(0, maxLength) + "...";
            }
            return displayText;

            // Alternative: Include Subject (Uncomment if preferred)
            // return $"[{Subject}] {displayText}";
        }
    }
}