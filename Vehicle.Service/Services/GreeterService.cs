using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleGrpcService;

namespace Vehicle.Service
{
    public class VehicleService : VehicleServiceContract.VehicleServiceContractBase
    {
        private readonly ILogger<VehicleService> _logger;

        public VehicleService(ILogger<VehicleService> logger)
        {
            _logger = logger;
        }

        public override Task<VehicleResponse> GetVehicle(VehicleRequest request, ServerCallContext context)
        {
            return Task.FromResult(new VehicleResponse
            {
                Make = request.Make,
                Year = 2020,
                Fuel = "Petrol",
                Model = request.Model,
                Transmission = "DCT Auto"
            });
        }

        public override Task<VehicleResponse> GetRandomRecommendation(Empty request, ServerCallContext context)
        {
            return Task.FromResult(new VehicleResponse
            {
                Make = "MG",
                Year = 2021,
                Fuel = "Petrol",
                Model = "Hector Plus",
                Transmission = "DCT Auto"
            });
        }
    }
}
