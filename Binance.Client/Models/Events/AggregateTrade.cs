using System;

namespace Binance.Client.Models.Events
{
    internal class AggregateTrade : BinanceEvent, IAggregateTrade
    {
        public string? s { get; set; }
        public long a { get; set; }
        public string? p { get; set; }
        public string? q { get; set; }
        public long f { get; set; }
        public long l { get; set; }
        public long T { get; set; }
        public bool m { get; set; }

        string? IAggregateTrade.Symbol => this.s;
        long IAggregateTrade.AggregateTradeId => this.a;
        decimal IAggregateTrade.Price => decimal.TryParse(this.p, out decimal value) ? value : throw new InvalidCastException($"The value '{this.p}' cannot be parsed to decimal.");
        decimal IAggregateTrade.Quantity => decimal.TryParse(this.q, out decimal value) ? value : throw new InvalidCastException($"The value '{this.q}' cannot be parsed to decimal.");
        long IAggregateTrade.FirstTradeId => this.f;
        long IAggregateTrade.LastTradeId => this.l;
        DateTimeOffset IAggregateTrade.TradeTime => DateTimeOffset.FromUnixTimeMilliseconds(this.T);
        bool IAggregateTrade.IsMaker => this.m;
    }
}
