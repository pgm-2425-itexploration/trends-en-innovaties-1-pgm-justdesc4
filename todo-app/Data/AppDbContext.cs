using Microsoft.EntityFrameworkCore;
using Models;

public class AppDbContext : DbContext
{
    public DbSet<TaskItem> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=tasks.db");
    }
}