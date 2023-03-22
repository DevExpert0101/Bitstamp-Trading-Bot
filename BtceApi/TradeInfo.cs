// copyright (c) 2014 Sayyid Mohammad Saleh Samimi
// Donate: 1NBakuExebh2M9atfS3QuSmRPPtYU398VN
// 
// this file is part of BTCETradeBot.
// 
// BTCETradeBot is free software: you can redistribute it and/or modify
// it under the terms of the gnu general public license as published by
// the free software foundation, either version 3 of the license, or
// (at your option) any later version.
// 
// BTCETradeBot is distributed in the hope that it will be useful,
// but without any warranty; without even the implied warranty of
// merchantability or fitness for a particular purpose.  see the
// gnu general public license for more details.
// 
// you should have received a copy of the gnu general public license
// along with BTCETradeBot.  if not, see <http://www.gnu.org/licenses/>.

using Bitstamp.Utils;
using Newtonsoft.Json.Linq;
using System;
namespace Bitstamp
{
	public class TradeInfo
	{
		public decimal Amount { get; private set; }
		public DateTime Date { get; private set; }
		public BitstampCurrency Item { get; private set; }
		public decimal Price { get; private set; }
		public BitstampCurrency PriceCurrency { get; private set; }
		public UInt32 Tid { get; private set; }
		public TradeInfoType Type { get; private set; }

		public static TradeInfo ReadFromJObject(JObject o)
        {
            if (o == null)
                return null;

			return new TradeInfo()
            {
                //Amount = o.Value<decimal>("amount"),
                //Price = o.Value<decimal>("price"),
                //Date = UnixTime.ConvertToDateTime(o.Value<UInt32>("date")),
                //Item = BtceCurrencyHelper.FromString(o.Value<string>("amount")),
                //PriceCurrency = BtceCurrencyHelper.FromString(o.Value<string>("price")),
                //Tid = o.Value<UInt32>("tid"),
                //Type = TradeInfoTypeHelper.FromString(o.Value<string>("type"))
                Item = BtceCurrencyHelper.FromString(o.Value<string>("amount")),
                Amount = o.Value<decimal>("amount"),
                Price = o.Value<decimal>("price"),
                Date = UnixTime.ConvertToDateTime(o.Value<UInt32>("date")),
                Tid = o.Value<UInt32>("tid"),
                Type = TradeInfoTypeHelper.FromString(o.Value<string>("type"))
            };
        }
	}

    public class TradeInfoV3
    {
        public decimal Amount { get; private set; }
        public DateTime Timestamp { get; private set; }
        public decimal Price { get; private set; }
        public UInt32 Tid { get; private set; }
        public TradeInfoType Type { get; private set; }

        public static TradeInfoV3 ReadFromJObject(JObject o)
        {
            if (o == null)
                return null;

            return new TradeInfoV3()
            {
                Amount = o.Value<decimal>("amount"),
                Price = o.Value<decimal>("price"),
                Timestamp = UnixTime.ConvertToDateTime(o.Value<UInt32>("date")),
                Tid = o.Value<UInt32>("tid"),
                Type = TradeInfoTypeHelper.FromString(o.Value<string>("type"))
            };
        }
    }
}
