using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BingoLibrary.Models
{
    public class RegisterData
    {
        [Key]
        public int LoggerId { get; set; }
        [Required]
        public string LoggerName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string CnfPassword { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public DateTime DOB { get; set; }
    }
}
