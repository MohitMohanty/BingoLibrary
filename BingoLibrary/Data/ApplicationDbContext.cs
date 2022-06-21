using BingoLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BingoLibrary.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactUsData> ContactUsData { get; set; }
        public DbSet<BookDetail> BooksDetail { get; set; }
        public DbSet<LogInData> Logindata { get; set; }
        public DbSet<RegisterData> Registerdata { get; set; }
    }
}
