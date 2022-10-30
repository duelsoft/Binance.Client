using System.Collections.Generic;

namespace Binance.Client.Models.Api
{
    public class Account
    {
        public int makerCommission { get; set; }
        public int takerCommission { get; set; }
        public int buyerCommission { get; set; }
        public int sellerCommission { get; set; }
        public bool canTrade { get; set; }
        public bool canWithdraw { get; set; }
        public bool canDeposit { get; set; }
        public long updateTime { get; set; }
        public string? accountType { get; set; }
        public IReadOnlyCollection<AccountBalance>? balances { get; set; }
        public IReadOnlyCollection<string>? permissions { get; set; }

        public class AccountBalance
        {
            public string? asset { get; set; }
            public decimal free { get; set; }
            public string? locked { get; set; }
        }
    }
}
