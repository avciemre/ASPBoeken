using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPBoeken.Models
{
    public class BoekCreateViewModel
    {
        
        public int Id { get; set; }
        [Required, MaxLength (50), DisplayName("Naam van boek")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        public string Genre { get; set; }
        [Required]
        public int Rating { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
