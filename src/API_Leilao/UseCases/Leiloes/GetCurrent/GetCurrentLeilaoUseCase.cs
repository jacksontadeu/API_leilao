using API_Leilao.Entities;
using API_Leilao.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API_Leilao.UseCases.Leiloes.GetCurrent;

public class GetCurrentLeilaoUseCase
{
    public Auction? Execute()
    {
        var repo = new APILeilaoDbContext();

        return repo
            .Auctions
            .Include(leilao => leilao.Items)
            .FirstOrDefault();
            
    }
}
