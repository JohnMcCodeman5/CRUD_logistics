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

    public String db_name { get; set; }

    public AppDbContext(string username, string password, string db_name)
    {
        this.username = username;
        this.password = password;
        this.db_name = db_name;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the MySQL database connection string
        optionsBuilder.UseMySQL($"Server=DESKTOP-JVOF1K5;Database={this.db_name};User ID={this.username};Password={this.password};");
    }
}