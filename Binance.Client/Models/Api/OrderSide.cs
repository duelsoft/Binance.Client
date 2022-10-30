using System.Text.Json.Serialization;

namespace Binance.Client.Models.Api
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OrderSide
    {
        BUY = 1,
        SELL = 2
    }
}
