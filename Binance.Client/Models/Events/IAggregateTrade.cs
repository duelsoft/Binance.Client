using System;

namespace Binance.Client.Models.Events
{
    public interface IAggregateTrade : IBinanceEvent
    {
        string? Symbol { get; }
        long AggregateTradeId { get; }
        decimal Price { get; }
        decimal Quantity { get; }
        long FirstTradeId { get; }
        long LastTradeId { get; }
        DateTimeOffset TradeTime { get; }
        bool IsMaker { get; }
    }
}
