using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Bitstamp
{
    public class OrderDetails
    {
        /// <summary>
        /// Gets or sets the order ID
        /// </summary>
        public long Id { get; private set; }
        /// <summary>
        /// Gets or sets the date the order was created
        /// </summary>
        public DateTime DateTime { get; private set; }
        /// <summary>
        /// Gets or sets the type of order
        /// </summary>
        //public int Type { get; private set; }
        /// <summary>
        /// Gets or sets the order price
        /// </summary>
        public decimal Price { get; private set; }
        /// <summary>
        /// Gets or sets the order's amount
        /// </summary>
        public decimal Amount { get; private set; }
        public BitstampPair Pair { get; private set; }
        public TradeType Type { get; private set; }
        /// <summary>
        /// The limit price (for user orders only)
        /// </summary>
        /// 
        public decimal LimitPrice { get; private set; }

        public static OrderDetails CreateFromJObject(JObject o)
        {
            if (o == null)
            {
                return null;
            }

            var od = new OrderDetails()
            {
                Pair =  BtcePairHelper.FromString(o.Value<string>("currency_pair")),
                Type = TradeTypeHelper.FromString(o.Value<string>("type")),
                Price = o.Value <decimal> ("price"),
                Amount = o.Value<decimal>("amount"),
                DateTime = DateTime.Parse(o.Value<string>("datetime")),
                LimitPrice = o.Value<decimal>("limit_price")
            };

            return od;
        }
    }
}
