using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleGrpcService;
using static VehicleGrpcService.VehicleServiceContract;

namespace Vehicle.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        public readonly VehicleServiceContractClient _grpcClient;

        public VehiclesController(VehicleServiceContractClient grpcClient)
        {
            _grpcClient = grpcClient;
        }

        [HttpGet("random")]
        public async Task<IActionResult> GetRandom()
        {
            return Ok(await _grpcClient.GetRandomRecommendationAsync(new Empty()));
        }

        [HttpGet("model")]
        public async Task<IActionResult> GetModel()
        {
            return Ok(await _grpcClient.GetVehicleAsync(new VehicleRequest
            {
                Make = "Suzuki",
                Model = "Baleno"
            }));
        }
    }
}
