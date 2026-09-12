# Daygon, Lourd Kian Hayden M. — BSIT, Section 31E2

## IT Elective 2 – Prefinal Exam: Answer Key MVC App

This is an ASP.NET Core MVC application that displays all 20 multiple-choice
questions from the IT Elective 2 (Web System and Technologies) prefinal
exam, together with the answer chosen for each one and a short explanation.

**No database is used.** All 20 question/answer pairs live in memory in
`Data/ExamData.cs` and are served straight from the `HomeController` to
the view — nothing is persisted anywhere.

### Concept
Each question renders as a flip card: front shows the question and four
choices (correct one highlighted); tapping it flips to the letter answer
and a short explanation.

### Running it
\`\`\`bash
dotnet restore
dotnet run
\`\`\`
