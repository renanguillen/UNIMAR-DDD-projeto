namespace LibraryCatalog___Domain.Author
{
    using LibraryCatalog___Domain.Book;

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Book>? Books { get; set; }
    }
}
