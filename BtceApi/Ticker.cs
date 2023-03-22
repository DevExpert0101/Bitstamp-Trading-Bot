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

namespace Bitstamp
{
	public class Ticker
	{
		public decimal Average { get; private set; }
		public decimal Buy { get; private set; }
		public decimal High { get; private set; }
		public decimal Last { get; private set; }
		public decimal Low { get; private set; }
		public decimal Sell { get; private set; }
		public decimal Volume { get; private set; }
		public decimal VolumeCurrent { get; private set; }
		public UInt32 ServerTime { get; private set; }

		public static Ticker ReadFromJObject(JObject o) 
        {
            if (o == null)
                return null;
			return new Ticker() {
                Average = o.Value<decimal>("vwap"),
				Buy = o.Value<decimal>("ask"),
				High = o.Value<decimal>("high"),
				Last = o.Value<decimal>("last"),
				Low = o.Value<decimal>("low"),
				Sell = o.Value<decimal>("bid"),
				Volume = o.Value<decimal>("volume"),
				VolumeCurrent = o.Value<decimal>("volume"),
                ServerTime = o.Value<UInt32>("timestamp"),
			};
		}
	}
}
