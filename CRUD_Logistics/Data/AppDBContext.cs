using CRUD_Logistics.Models;
using CRUD_Logistics.Models.JobClass;
using Microsoft.EntityFrameworkCore;
using CRUD_Logistics.Models;

public class AppDbContext : DbContext
{
    public DbSet<People>? People { get; set; }
    public DbSet<Job>? Job { get; set; }
    public String username { get; set; }
    public String password { get; set; }

    public AppDbContext(string username, string password)
    {
        this.username = username;
        this.password = password;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the MySQL database connection string
        optionsBuilder.UseMySQL($"Server=DESKTOP-JVOF1K5;Database=test_db;User ID={this.username};Password={this.password};");
    }
}