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
             new QuestionAnswer
            {
                Number = 4,
                Question = "Which EF Core component is primarily responsible for communicating with the database?",
                Options = new List<Option>
                {
                    new Option("A", "DbContext"),
                    new Option("B", "DbSetView"),
                    new Option("C", "ControllerContext"),
                    new Option("D", "RazorContext")
                },
                CorrectLetter = "A",
                Explanation = "DbContext manages the connection, change tracking, and querying against the database."
            },
             new QuestionAnswer
            {
                Number = 5,
                Question = "What does the following command primarily do?\n\ndotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                Options = new List<Option>
                {
                    new Option("A", "Deletes the database"),
                    new Option("B", "Creates a new MVC project"),
                    new Option("C", "Generates EF Core models and a DbContext from an existing database"),
                    new Option("D", "Starts the MVC application")
                },
                CorrectLetter = "C",
                Explanation = "This is the Database-First scaffolding command that reverse-engineers models and a DbContext."
            },
             new QuestionAnswer
            {
                Number = 6,
                Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                Options = new List<Option>
                {
                    new Option("A", "Program.cs only"),
                    new Option("B", "appsettings.json"),
                    new Option("C", "Index.cshtml"),
                    new Option("D", "Student.cs")
                },
                CorrectLetter = "B",
                Explanation = "Connection strings live in configuration (appsettings.json), not hard-coded in views or models."
            },
             new QuestionAnswer
            {
                Number = 7,
                Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                Options = new List<Option>
                {
                    new Option("A", "One-to-One"),
                    new Option("B", "One-to-Many"),
                    new Option("C", "Many-to-Many"),
                    new Option("D", "Many-to-One only")
                },
                CorrectLetter = "B",
                Explanation = "One Section has many Students, so from Section's side it's One-to-Many."
            },
             new QuestionAnswer
            {
                Number = 8,
                Question = "In the following example, what is SectionId?\n\npublic int SectionId { get; set; }\npublic Section Section { get; set; }",
                Options = new List<Option>
                {
                    new Option("A", "Primary key of Student"),
                    new Option("B", "Foreign key referencing Section"),
                    new Option("C", "Navigation property"),
                    new Option("D", "Database connection string")
                },
                CorrectLetter = "B",
                Explanation = "SectionId is the scalar foreign key column pointing back to the Section table."
            },
             new QuestionAnswer
            {
                Number = 9,
                Question = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                Options = new List<Option>
                {
                    new Option("A", "It stores the database password"),
                    new Option("B", "It represents a relationship to another entity"),
                    new Option("C", "It creates a new database"),
                    new Option("D", "It validates the student's name")
                },
                CorrectLetter = "B",
                Explanation = "Navigation properties let you traverse from one entity to its related entity in code."
            },
             new QuestionAnswer
            {
                Number = 10,
                Question = "What does .Include() generally allow EF Core to do?",
                Options = new List<Option>
                {
                    new Option("A", "Delete the Section table"),
                    new Option("B", "Load related Section data together with Students"),
                    new Option("C", "Create a new Student"),
                    new Option("D", "Validate Student input")
                },
                CorrectLetter = "B",
                Explanation = "Include() performs eager loading of a related entity in the same query."
            },
             new QuestionAnswer
            {
                Number = 11,
                Question = "Why might a ViewModel be used when displaying Student and Section information?",
                Options = new List<Option>
                {
                    new Option("A", "To replace the database"),
                    new Option("B", "To combine or shape the data specifically needed by the view"),
                    new Option("C", "To automatically create database tables"),
                    new Option("D", "To prevent controllers from using LINQ")
                },
                CorrectLetter = "B",
                Explanation = "ViewModels tailor/shape exactly the data a view needs, often combining multiple entities."
            },
             new QuestionAnswer
            {
                Number = 12,
                Question = "Consider this query:\n\nvar students = _context.Students.Include(s => s.Section).ToList();\n\nWhat is the main benefit of Include(s => s.Section)?",
                Options = new List<Option>
                {
                    new Option("A", "It loads the related Section navigation property"),
                    new Option("B", "It creates a Section object manually"),
                    new Option("C", "It removes the foreign key"),
                    new Option("D", "It prevents the query from accessing the database")
                },
                CorrectLetter = "A",
                Explanation = "Include(s => s.Section) eagerly loads each Student's related Section in the same query."
            },
             new QuestionAnswer
            {
                Number = 13,
                Question = "Which type of validation occurs in the browser before a request is sent to the server?",
                Options = new List<Option>
                {
                    new Option("A", "Database-level validation"),
                    new Option("B", "Client-side validation"),
                    new Option("C", "Server-side validation"),
                    new Option("D", "EF Core migration validation")
                },
                CorrectLetter = "B",
                Explanation = "Client-side validation runs in the browser (usually via JavaScript) before submission."
            },
        };
    }
}