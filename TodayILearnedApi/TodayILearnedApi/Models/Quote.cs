namespace TodayILearnedApi.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime? Date { get; set; }
        public string Text { get; set; }

        public Quote(int id, string author, string text) =>
            (Id, Author, Text) = (id, author, text);

        public void Deconstruct(out string author, out DateTime? date, out string text) =>
            (author, date, text) = (Author, Date, Text);
    }
}
