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
namespace Bitstamp
{
    public enum TradeInfoType
    {
        Ask,
        Bid
    }
    public class TradeInfoTypeHelper
    {
        public static TradeInfoType FromString(string s)
        {
            switch (s)
            {
                case "0":
                    return TradeInfoType.Ask;
                case "1":
                    return TradeInfoType.Bid;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
