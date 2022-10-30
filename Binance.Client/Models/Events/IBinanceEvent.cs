using System;

namespace Binance.Client.Models.Events
{
    public interface IBinanceEvent
    {
        string? EventType { get; }
        DateTimeOffset EventTime { get; }
    }
}
