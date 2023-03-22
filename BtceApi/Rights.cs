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
	public class Rights
	{
		public bool Info { get; private set; }
		public bool Trade { get; private set; }
		public static Rights ReadFromJObject(JObject o) {
			if ( o == null )
				return null;
			return new Rights() {
				Info = o.Value<int>("info") == 1,
				Trade = o.Value<int>("trade") == 1
			};
		}
	}
}
