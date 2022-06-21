using System.ComponentModel.DataAnnotations;

namespace BingoLibrary.Models
{
    public class BookDetail
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookTitle { get; set; }
        public string BookDescription { get; set; }

    }
}
