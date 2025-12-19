using EntityFramework_Task.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Task.Data.Contexts;

public class AppDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-41GG1BB\SQLEXPRESS;Database=BE303TaskDb;Integrated Security=True;TrustServerCertificate=True;");
    }

    public DbSet<Student> Students { get; set; } = null!;
}
