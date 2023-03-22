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

namespace Bitstamp.Utils
{
    public static class UnixTime
    {
        static DateTime unixEpoch;
        static UnixTime()
        {
            unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        }

        public static UInt32 Now { get { return GetFromDateTime(DateTime.UtcNow); } }
        public static UInt32 GetFromDateTime(DateTime d) { return (UInt32)(d - unixEpoch).TotalSeconds; }
        public static DateTime ConvertToDateTime(UInt32 unixtime) { return unixEpoch.AddSeconds(unixtime); }
    }
}
