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
	public class Order
	{
        public int Id { get; private set; }
		public BitstampPair Pair { get; private set; }
		public TradeType Type { get; private set; }
		public decimal Amount { get; private set; }
		public decimal Rate { get; private set; }
		public UInt32 TimestampCreated { get; private set; }
		public int Status { get; private set; }
		public static Order ReadFromJObject(JObject o) {
			if ( o == null )
				return null;
			return new Order() {
				Pair = BtcePairHelper.FromString(o.Value<string>("pair")),
				Type = TradeTypeHelper.FromString(o.Value<string>("type")),
				Amount = o.Value<decimal>("amount"),
				Rate = o.Value<decimal>("rate"),
				TimestampCreated = o.Value<UInt32>("timestamp_created"),
				Status = o.Value<int>("status")
			};
		}
	}

	public class OrderList
	{
		public Dictionary<int, Order> List { get; private set; }
		public static OrderList ReadFromJObject(JObject o)
		{

		    var list = new OrderList();
            list.List = new Dictionary<int, Order>();
		    foreach (var VARIABLE in o)
		    {
                list.List.Add(key: int.Parse(VARIABLE.Key.ToString()), value: Order.ReadFromJObject(VARIABLE.Value as JObject));
		    }
		    return list;
		    //return new OrderList()
		    //           {
		    //               List =
		    //                   o.OfType<KeyValuePair<string, JToken>>().ToDictionary(item => int.Parse(item.Key),
		    //                                                                         item => Order.ReadFromJObject(item.Value as JObject))
		    //           };
		}
	}
}
