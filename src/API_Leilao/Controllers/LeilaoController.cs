using API_Leilao.Entities;
using API_Leilao.UseCases.Leiloes.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace API_Leilao.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LeilaoController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public ActionResult GetLeilao()
    {
        var useCase = new GetCurrentLeilaoUseCase();

        
        var result = useCase.Execute();

        if (result != null)
            return NoContent();

        return Ok(result);
    }
}
