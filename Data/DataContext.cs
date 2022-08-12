using AuntieDot.Models;
using Microsoft.EntityFrameworkCore;

namespace AuntieDot.Data;

// This class acts as model for the database. Fields get turned into SQL tables. 
public class DataContext : DbContext
{
    
    public DataContext(){}
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<UserAccount> Users { get; set; }
    public DbSet<OauthState> LoginStates { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserAccount>().ToTable("Accounts");
        modelBuilder.Entity<OauthState>().ToTable("OauthState");
    }
}