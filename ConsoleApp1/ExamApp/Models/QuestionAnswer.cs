namespace ExamApp.Models
{
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