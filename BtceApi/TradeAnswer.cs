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
namespace Bitstamp
{
	public class TradeAnswer {
		public decimal Received { get; private set; }
		public decimal Remains { get; private set; }
		public int OrderId { get; private set; }
		public Funds Funds { get; private set; }

		private TradeAnswer() { }
		public static TradeAnswer ReadFromJObject(JObject o) {
			if ( o == null )
				return null;
			return new TradeAnswer() {
				Funds = Funds.ReadFromJObject(o["funds"] as JObject),
				Received = o.Value<decimal>("received"),
				Remains = o.Value<decimal>("remains"),
				OrderId = o.Value<int>("order_id")
			};
		}
	}
}
