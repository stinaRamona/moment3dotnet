using Microsoft.EntityFrameworkCore;
using moment3dotnet.Models;

namespace moment3dotnet.Data; 

public class ApplicationDbContext : DbContext {

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

    }

    public DbSet<GenreModel> Genres { get; set; }

    public DbSet<BookModel> Books { get; set; }
}