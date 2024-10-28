using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<DiaryEntry> DiaryEntries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<DiaryEntry>().HasData(
            new DiaryEntry
            {
                Id = 1,
                Title = "Went Hiking",
                Content = "Went hiking to Whistlers Mountain",
                Created = DateTime.Now
            },
            new DiaryEntry
            {
                Id = 2,
                Title = "Went Shopping",
                Content = "Went shopping to Hinton",
                Created = DateTime.Now
            },
            new DiaryEntry
            {
                Id = 3,
                Title = "Went Driving",
                Content = "Went driving to Jasper Driver's school",
                Created = DateTime.Now
            }
            );
    }
}