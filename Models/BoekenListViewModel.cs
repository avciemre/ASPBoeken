namespace ASPBoeken.Models
{
    public class BoekenListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
