using System;
using System.Collections.Generic;

namespace Binance.Client.Models.Api
{
    public class Order
    {
        public string? symbol { get; set; }
        public long orderId { get; set; }
        public int? orderListId { get; set; }
        public string? clientOrderId { get; set; }
        public long? time { get; set; }
        public long? transactTime { get; set; }
        public string? price { get; set; }
        public decimal origQty { get; set; }
        public decimal executedQty { get; set; }
        public decimal cummulativeQuoteQty { get; set; }
        public OrderStatus status { get; set; }
        public TimeInForce? timeInForce { get; set; }
        public OrderType type { get; set; }
        public OrderSide side { get; set; }
        public ICollection<OrderFill>? fills { get; set; }

        public DateTimeOffset? _Time => this.time != null ? DateTimeOffset.FromUnixTimeMilliseconds(this.time.Value) : default(DateTimeOffset?);

        public class OrderFill
        {
            public string? price { get; set; }
            public string? qty { get; set; }
            public decimal commission { get; set; }
            public string? commissionAsset { get; set; }
        }
    }
}
