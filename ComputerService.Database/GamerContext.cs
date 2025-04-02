using ComputerService.Models;
using Microsoft.EntityFrameworkCore;

namespace ComputerService.Database;

public class GamerContext : DbContext
{
    public DbSet<Gamer> Gamers { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<RecordOfGame> RecordOfGames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=Gamers.db");
    }
}