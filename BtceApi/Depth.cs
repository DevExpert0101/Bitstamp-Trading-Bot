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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
namespace Bitstamp
{
	public class OrderInfo
	{
		public decimal Price { get; private set; }
		public decimal Amount { get; private set; }
		public static OrderInfo ReadFromJObject(JArray o) {
			if ( o == null )
				return null;
			return new OrderInfo() {
				Price = o.Value<decimal>(0),
				Amount = o.Value<decimal>(1),
			};
		}
	}
	public class Depth
	{
		public List<OrderInfo> Asks { get; private set; }
		public List<OrderInfo> Bids { get; private set; }
		public static Depth ReadFromJObject(JObject o) {
			return new Depth() {
				Asks = o["asks"].OfType<JArray>().Select(order => OrderInfo.ReadFromJObject(order as JArray)).ToList(),
				Bids = o["bids"].OfType<JArray>().Select(order => OrderInfo.ReadFromJObject(order as JArray)).ToList()
			};
		}
	}
}
