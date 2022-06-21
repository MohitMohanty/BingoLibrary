using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BingoLibrary.Models
{
    public class LogInData
    {
        [Key]
        public int LoggerId { get; set; }
        public string LoggerName { get; set; }
        [Required]
        [DisplayName("Email ID")]
        public string LoggerEmail { get; set; }
        [Required]
        public string Password { get; set; }
        public string CnfPassword { get; set; }
        public DateTime LoginTime { get; set; } = DateTime.Now;
        public DateTime LogoutTime { get; set; } = DateTime.Now;

    }
}
