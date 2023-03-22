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
    public class Transaction
    {
        public int Type { get; private set; }
        public decimal Amount { get; private set; }
        public BitstampCurrency Currency { get; private set; }
        public string Description { get; private set; }
        public int Status { get; private set; }
        public UInt32 Timestamp { get; private set; }

        public static Transaction ReadFromJObject(JObject o)
        {
            if (o == null)
                return null;
			return new Transaction()
            {
                Type = o.Value<int>("type"),
                Amount = o.Value<decimal>("amount"),
                Currency = BtceCurrencyHelper.FromString(o.Value<string>("currency")),
                Timestamp = o.Value<UInt32>("timestamp"),
                Status = o.Value<int>("status"),
                Description = o.Value<string>("desc")
            };
        }
    }

    public class TransHistory {
        public Dictionary<int, Transaction> List { get; private set; }
        public static TransHistory ReadFromJObject(JObject o)
        {
            var list = new TransHistory();
            list.List=new Dictionary<int, Transaction>();
            foreach (var VARIABLE in o)
            {
                list.List.Add(key: int.Parse(VARIABLE.Key.ToString()), value: Transaction.ReadFromJObject(VARIABLE.Value as JObject));
            }
            return list;
            //return new TransHistory() {
            //    List = o.OfType<KeyValuePair<string,JToken>>().ToDictionary(a=>int.Parse(a.Key), a=>Transaction.ReadFromJObject(a.Value as JObject))
            //};
        }
    }
}
