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
	public enum BitstampPair
	{
eurusd,
btcusd,
btceur,
ltcbtc,
ltcusd,
ltcrur,
ltceur,
Unknown
	}

	public class BtcePairHelper
	{
		public static BitstampPair FromString(string s) {
			BitstampPair ret = BitstampPair.Unknown;
			Enum.TryParse<BitstampPair>(s.ToLowerInvariant(), out ret);
			return ret;
		}

		public static string ToString(BitstampPair v) {
			return Enum.GetName(typeof(BitstampPair), v).ToLowerInvariant();
		}

        public static string ToBetterString(BitstampPair v)
        {
            //return Enum.GetName(typeof(BtcePair), v).ToLowerInvariant().ToUpper().Replace('_','/');
            return Enum.GetName(typeof(BitstampPair), v).ToLowerInvariant().ToUpper();
        }

        public static string ToBetterString(string v)
        {
            //return v.ToLowerInvariant().ToUpper().Replace('_', '/');
            return v.ToLowerInvariant().ToUpper();
        }

        public static BitstampPair FromBetterString(string s)
        {
            BitstampPair ret = BitstampPair.Unknown;
            Enum.TryParse<BitstampPair>(s.ToLowerInvariant(), out ret);
            //Enum.TryParse<BtcePair>(s.ToLowerInvariant().Replace('/', '_'), out ret);
            return ret;
        }


	}
}
