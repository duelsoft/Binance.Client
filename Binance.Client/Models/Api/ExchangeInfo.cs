using System.Collections.Generic;

namespace Binance.Client.Models.Api
{
    public class ExchangeInfo
    {
        public string? timezone { get; set; }
        public long serverTime { get; set; }
        public IReadOnlyCollection<Symbol>? symbols { get; set; }

        public class Symbol
        {
            public string? symbol { get; set; }
            public string? baseAsset { get; set; }
            public string? quoteAsset { get; set; }
            public IReadOnlyCollection<Filter>? filters { get; set; }

            public class Filter
            {
                public string? filterType { get; set; }
                public decimal? minPrice { get; set; }
                public decimal? maxPrice { get; set; }
                public decimal? tickSize { get; set; }
                public decimal? minQty { get; set; }
                public decimal? maxQty { get; set; }
                public decimal? stepSize { get; set; }
                public decimal? minNotional { get; set; }
                public bool? applyToMarket { get; set; }
                public decimal? avgPriceMins { get; set; }
            }
        }
    }
}
