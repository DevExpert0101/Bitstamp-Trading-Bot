using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTCETradeBot
{
    public class Rule
    {
        public int Priority;
        public bool Enable;
        public bool ConsiderProfit;
        public bool ConsiderFee;
        public decimal Profit;

        public enum IfFirstPart
        {
            MarketLastPrice,
            MarketBuyPrice,
            MarketSellPrice,
            MarketHighPrice,
            MarketLowPrice,
            OrdersLastBuyPrice,//?
            OrdersLastSellPrice,//?
            MoneyBalance,
            GoodBalance,
            TotalToBuyAtMarketLastPrice,
            TotalToBuyAtMarketBuyPrice,
            MoneyToReceiveAtMarketLastPrice,
            MoneyToReceiveAtMarketSellPrice
        }

        public enum IfFirstCondition
        {
            GoesMoreThan,
            EqualsTo,
            GoesLessThan
        }

        public enum IFSecondCondition
        {
            Exact,
            Percent
        }

        public enum ThenFirstPart
        {
            SellAmount,
            BUyAmount,
            SellAll,
            SellHalf,
            SpendAllMyFunds,
            SpendHalfMyFunds,
            CancelAllOrders,
            CancelAllSellOrders,
            CancelAllBUyOrders,
            EnableAllRules,
            DisableAllRules,
            Beep
        }

        public enum ThenSecondPart
        {
            MarketLastPrice,
            MarketBuyPrice,
            MarketSellPrice,
            MarketHighPrice,
            MarketLowPrice,
            OrdersLastBuyPrice,//?
            OrdersLastSellPrice,//?
            ExactPrice
        }


    }
}
