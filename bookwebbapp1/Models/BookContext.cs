using Microsoft.EntityFrameworkCore;

namespace bookwebbapp1.Models
{
    public class BookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database = Booklist ; Trusted_Connection = True;");

        }

        public DbSet<Book> Booklist { get; set; }
    }
}
