using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcServer.Database;
using Microsoft.Extensions.Logging;

namespace GrpcServer.Services
{
    public class PayloadsService : Payload.PayloadBase
    {
        private readonly ILogger<PayloadsService> _logger;
        private readonly DatabaseConnection _db;

        public PayloadsService(ILogger<PayloadsService> logger)
        {
            _logger = logger;
            _db = new DatabaseConnection();
        }

        public override Task<SmallPayload> GetSmallPayload(PayloadId request, ServerCallContext context)
        {
            SmallPayload sp = _db.GetSmallPayload(request);
            return Task.FromResult(sp);
        }

        public override async Task GetAllSmallPayloads(EmptyRequest request, IServerStreamWriter<SmallPayload> responseStream, ServerCallContext context)
        {
            List<SmallPayload> sps = _db.GetAllSmallPayloads();

            foreach (SmallPayload sp in sps)
            {
                await responseStream.WriteAsync(sp);
            }
        }
    }
}
