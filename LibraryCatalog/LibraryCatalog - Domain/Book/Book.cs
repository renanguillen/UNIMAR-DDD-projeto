namespace LibraryCatalog___Domain.Book
{
    public class Book
    {
        public int Id { get; set; }
        public string Title  { get; set; }
        public string Edition { get; set; }
        public DateTime PublicationDate { get; set; }
        public int Bookshelf { get; set; }
        public int Row { get; set; }
        public bool Available { get; set; }
        public DateTime? RentDate { get; set; }
        public DateTime? DevolutionDate { get; set; }
    }
}
