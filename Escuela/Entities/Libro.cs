namespace Entities
{
    public class Libro
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int numPage { get; set; }
        public int stock { get; set; }
        public DateTime date { get; set; }
        public Libro(int id, string title, string authorName, DateTime date, int numPage, int stock)
        {
            Id = id;
            Title = title;
            Author = authorName;
            this.numPage = numPage;
            this.stock = stock;
            this.date = date;
        }
        
    }
}