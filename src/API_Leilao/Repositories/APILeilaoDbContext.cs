using API_Leilao.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Leilao.Repositories;

public class APILeilaoDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source =D:\DEV\c#\Rocket\JTMJ_Solution\src\API_Leilao\leilaoDbNLW.db");
    }
}
