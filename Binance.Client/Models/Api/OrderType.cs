using System;
using System.Text.Json.Serialization;

namespace Binance.Client.Models.Api
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OrderType
    {
        LIMIT = 1,
        MARKET = 2,

        //STOP_LOSS = 3,
        //STOP_LOSS_LIMIT = 4,
        //TAKE_PROFIT = 5,
        //TAKE_PROFIT_LIMIT = 6,
        //LIMIT_MAKER = 7
    }
}
