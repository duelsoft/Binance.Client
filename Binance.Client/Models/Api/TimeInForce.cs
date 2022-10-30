using System.Text.Json.Serialization;

namespace Binance.Client.Models.Api
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TimeInForce
    {
        // Good Til Canceled
        // An order will be on the book unless the order is canceled.
        GTC = 1,

        // Immediate Or Cancel
        // An order will try to fill the order as much as it can before the order expires.
        IOC = 2,

        // Fill or Kill
        //An order will expire if the full order cannot be filled upon execution.
        FOK = 3
    }
}
