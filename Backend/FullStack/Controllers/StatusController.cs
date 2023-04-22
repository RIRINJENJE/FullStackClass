using FullStack.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStack.Controllers
{
    [Route("")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet("status")] //  rechterhaakjes zijn Annotatie 
        public String status()
        {
            return "OK";
        }

        [HttpGet("whatisgroot")]
        public Plantje MaakPlantje()
        {
            Plantje p = new Plantje();
            p.Id = 1;
            p.Name = "Groot";
            p.Age = 30;

            Plantje p2 = new Plantje() { Id = 2, Name = "Groot", Age = 2 };

            return p;
        }
    }
}
