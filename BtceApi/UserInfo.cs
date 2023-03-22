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
    public class UserInfo
    {
        public Funds Funds { get; private set; }
        public Rights Rights { get; private set; }
        public int TransactionCount { get; private set; }
        public int OpenOrders { get; private set; }
        public int ServerTime { get; private set; }

        private UserInfo(){}
        public static UserInfo ReadFromJObject(JObject o)
        {
            var funds = Funds.ReadFromJObject(o["funds"] as JObject);
            var userInfo= new UserInfo()
            {
                Funds = funds,
                Rights = Rights.ReadFromJObject(o["rights"] as JObject),
                TransactionCount = o.Value<int>("transaction_count"),
                OpenOrders = o.Value<int>("open_orders"),
                ServerTime = o.Value<int>("server_time")
            };
            return userInfo;
        }
    }
}
