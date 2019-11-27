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
    public class PayloadsService : PayloadService.PayloadServiceBase
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
            SmallPayload sp = _db.GetSmallPayload(request.Id);
            return Task.FromResult(sp);
        }

        public override Task<MediumPayload> GetMediumPayload(PayloadId request, ServerCallContext context)
        {
            MediumPayload mp = _db.GetMediumPayload(request.Id);
            return Task.FromResult(mp);
        }

        public override Task<LargePayload> GetLargePayload(PayloadId request, ServerCallContext context)
        {
            LargePayload lp = _db.GetLargePayload(request.Id);
            return Task.FromResult(lp);
        }

        public override async Task GetAllSmallPayloads(EmptyRequest request, IServerStreamWriter<SmallPayload> responseStream, ServerCallContext context)
        {
            List<SmallPayload> sps = _db.GetAllSmallPayloads();

            foreach (SmallPayload sp in sps)
            {
                await responseStream.WriteAsync(sp);
            }
        }

        public override async Task GetAllMediumPayloads(EmptyRequest request, IServerStreamWriter<MediumPayload> responseStream, ServerCallContext context)
        {
            List<MediumPayload> mps = _db.GetAllMediumPayloads();

            foreach (MediumPayload mp in mps)
            {
                await responseStream.WriteAsync(mp);
            }
        }

        public override async Task GetAllLargePayloads(EmptyRequest request, IServerStreamWriter<LargePayload> responseStream, ServerCallContext context)
        {
            List<LargePayload> lps = _db.GetAllLargePayloads();

            foreach (LargePayload lp in lps)
            {
                await responseStream.WriteAsync(lp);
            }
        }
    }
}
