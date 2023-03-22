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

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bitstamp
{
	public class Trade
	{
		public BitstampPair Pair { get; private set; }
		public TradeType Type { get; private set; }
		public decimal Amount { get; private set; }
		public decimal Rate { get; private set; }
		public int OrderId { get; private set; }
		public bool IsYourOrder { get; private set; }
		public UInt32 Timestamp { get; private set; }
		public static Trade ReadFromJObject(JObject o) {
			if ( o == null )
				return null;
			return new Trade() {
				Pair = BtcePairHelper.FromString(o.Value<string>("pair")),
				Type = TradeTypeHelper.FromString(o.Value<string>("type")),
				Amount = o.Value<decimal>("amount"),
				Rate = o.Value<decimal>("rate"),
				Timestamp = o.Value<UInt32>("timestamp"),
				IsYourOrder = o.Value<int>("is_your_order") == 1,
				OrderId = o.Value<int>("order_id")
			};
		}
	}
	public class TradeHistory
	{
		public Dictionary<int, Trade> List { get; private set; }
		public static TradeHistory ReadFromJObject(JObject o)
		{
		    var list = new TradeHistory();
            list.List=new Dictionary<int, Trade>();
		    foreach (var VARIABLE in o)
		    {
                list.List.Add(key: int.Parse(VARIABLE.Key.ToString()), value: Trade.ReadFromJObject(VARIABLE.Value as JObject));
		    }
		    return list;
		    //return new TradeHistory() {
		    //    List = o.OfType<KeyValuePair<string, JToken>>().ToDictionary(item => int.Parse(item.Key), item => Trade.ReadFromJObject(item.Value as JObject))
		    //};
		}
	}
}
