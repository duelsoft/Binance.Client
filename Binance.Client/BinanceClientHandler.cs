using Binance.Client.Models.Api;
using Binance.Client.Models.Exceptions;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Binance.Client
{
    internal class BinanceClientHandler : HttpClientHandler
    {
        private readonly ILogger _logger;

        public BinanceClientHandler(ILogger logger)
        {
            this._logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            using (this._logger.BeginScope(new Dictionary<string, object?>
            {
                ["RequestMethod"] = request.Method,
                ["RequestUri"] = request.RequestUri
            }))
            {
                if (request.Content != null && this._logger.IsEnabled(LogLevel.Trace))
                {
                    string requestBody = await request.Content.ReadAsStringAsync(CancellationToken.None);
                    this._logger.LogTrace($"Binance Client Request Body: {requestBody}");
                }

                HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

                this._logger.LogDebug($"Binance Client Response Code '{(int)response.StatusCode}'.");

                if (response.Content != null && this._logger.IsEnabled(LogLevel.Trace))
                {
                    string responseBody = await response.Content.ReadAsStringAsync(CancellationToken.None);
                    this._logger.LogTrace($"Binance Client Request Body: {responseBody}");
                }

                if (!response.IsSuccessStatusCode)
                {
                    BinanceError? error = await (response.Content?.ReadFromJsonAsync<BinanceError>(cancellationToken: CancellationToken.None) ?? Task.FromResult(default(BinanceError)));

                    throw new BinanceException(error?.code ?? -1, error?.msg, response.StatusCode);
                }

                return response;
            }
        }
    }
}
