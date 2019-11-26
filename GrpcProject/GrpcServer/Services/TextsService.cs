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
    public class TextsService : Text.TextBase
    {
        private readonly ILogger<TextsService> _logger;
        private readonly DatabaseConnection _db;

        public TextsService(ILogger<TextsService> logger)
        {
            _logger = logger;
            _db = new DatabaseConnection();
        }

        public override Task<TextModel> GetText(TextId request, ServerCallContext context)
        {
            TextModel t = _db.GetTextModel(request.Id);
            return Task.FromResult(t);
        }

        public override async Task GetAllTexts(EmptyRequest request, IServerStreamWriter<TextModel> responseStream, ServerCallContext context)
        {
            List<TextModel> ts = _db.GetAllTextModels();

            foreach (TextModel t in ts)
            {
                await responseStream.WriteAsync(t);
            }
        }
    }
}
