using System;

namespace Binance.Client.Models.Events
{
    internal class BinanceEvent : IBinanceEvent
    {
        public string? e { get; set; }
        public long E { get; set; }

        string? IBinanceEvent.EventType => this.e;
        DateTimeOffset IBinanceEvent.EventTime => DateTimeOffset.FromUnixTimeMilliseconds(this.E);
    }
}
