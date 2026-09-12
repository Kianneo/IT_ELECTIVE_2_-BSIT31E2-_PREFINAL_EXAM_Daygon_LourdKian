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
            new QuestionAnswer
            {
                Number = 2,
                Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                Options = new List<Option>
                {
                    new Option("A", "Code-First"),
                    new Option("B", "Database-First"),
                    new Option("C", "Model-First"),
                    new Option("D", "Controller-First")
                },
                CorrectLetter = "B",
                Explanation = "Reverse-engineering models from an existing schema is the Database-First workflow."
            },
             new QuestionAnswer
            {
                Number = 3,
                Question = "What is the primary purpose of Entity Framework Core?",
                Options = new List<Option>
                {
                    new Option("A", "To create HTML pages automatically"),
                    new Option("B", "To replace the MVC Controller"),
                    new Option("C", "To map objects in code to relational database data"),
                    new Option("D", "To replace the C# compiler")
                },
                CorrectLetter = "C",
                Explanation = "EF Core is an object-relational mapper (ORM) -- it maps C# classes to tables and rows."
            },
        };
    }
}