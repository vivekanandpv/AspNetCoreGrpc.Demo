using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        [HttpGet("random")]
        public async Task<IActionResult> GetRandom()
        {
            return Ok();
        }

        [HttpGet("model")]
        public async Task<IActionResult> GetModel()
        {
            return Ok();
        }
    }
}
