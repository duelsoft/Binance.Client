using System;
using System.Net;
using System.Net.Http;

namespace CryptoTrader.Marketplace.Binance
{
    public class BinanceException : HttpRequestException
    {
        public BinanceErrorCode Code { get; }
        public bool IsRateLimited => this.StatusCode == HttpStatusCode.TooManyRequests || this.IsIpBan;
        public bool IsIpBan => (int?)this.StatusCode == 418;

        public BinanceException(BinanceErrorCode code, string? message, HttpStatusCode? httpStatusCode) : base(message, null, httpStatusCode)
        {
            this.Code = code;

            if ((int)this.Code < -9000)
                this.Code = BinanceErrorCode.FILTER_FAILURE_FLAG;
        }

        public BinanceException(int code, string? message, HttpStatusCode? httpStatusCode) : this((BinanceErrorCode)code, message, httpStatusCode)
        {
        }
    }
}
