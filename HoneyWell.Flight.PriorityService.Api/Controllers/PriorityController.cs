using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HoneyWell.Flight.PriorityService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriorityController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPriority(int flighId, string flightTypes, string passengerclass)
        {
            return Ok();
        }
    }
}
