namespace PrefinalExam.Models
{
    /// <summary>
    /// Represents one multiple-choice item from the prefinal exam,
    /// together with the answer that was chosen for it.
    /// No database is involved -- this is a plain in-memory model.
    /// </summary>
    public class QuestionAnswer
    {
        public int Number { get; set; }
        public string Question { get; set; } = string.Empty;
        public List<Option> Options { get; set; } = new();
        public string CorrectLetter { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;

        public Option? CorrectOption => Options.FirstOrDefault(o => o.Letter == CorrectLetter);
    }

    public class Option
    {
        public string Letter { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;

        public Option() { }

        public Option(string letter, string text)
        {
            Letter = letter;
            Text = text;
        }
    }
}