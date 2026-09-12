using ExamApp.Models;

namespace ExamApp.Data
{
    /// <summary>
    /// Static, in-memory answer key for the IT Elective 2 prefinal exam.
    /// Intentionally NOT backed by a database or DbContext.
    /// </summary>
    public static class ExamData
    {
        public static List<QuestionAnswer> Questions { get; } = new()
        {
            new QuestionAnswer
            {
                Number = 1,
                Question = "What is the main problem solved by using a database instead of an in-memory collection?",
                Options = new List<Option>
                {
                    new Option("A", "It makes C# code shorter"),
                    new Option("B", "It prevents the application from restarting"),
                    new Option("C", "It allows data to persist after the application stops"),
                    new Option("D", "It removes the need for MVC")
                },
                CorrectLetter = "C",
                Explanation = "In-memory collections vanish once the app stops; a database keeps the data around between runs."
            },