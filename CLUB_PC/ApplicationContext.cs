using Microsoft.EntityFrameworkCore;
using System;

public class ApplicationContext : DbContext
{
    public DbSet<User> User { get; set; } = null!;
    public DbSet<Table> Table { get; set; } = null!;
    public DbSet<Reservation> Reservation { get; set; } = null!;
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;DataBase=postgres;Username=postgres;Password=lololoshka123");
    }
}