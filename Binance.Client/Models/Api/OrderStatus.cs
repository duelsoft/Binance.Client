using System;
using System.Text.Json.Serialization;

namespace Binance.Client.Models.Api
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OrderStatus
    {
        NEW,
        PARTIALLY_FILLED,
        FILLED,
        CANCELED,
        PENDING_CANCEL,
        REJECTED,
        EXPIRED
    }
}
