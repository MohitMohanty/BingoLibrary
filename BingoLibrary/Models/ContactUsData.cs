using System.ComponentModel.DataAnnotations;

namespace BingoLibrary.Models
{
    public class ContactUsData
    {
        [Key]
        public int contacterId { get; set; }
        [Required]
        public string SenderName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
