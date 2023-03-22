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
	public class Funds
	{

        public decimal Btc { get; private set; }
        public decimal Ltc { get; private set; }
        public decimal Nmc { get; private set; }
        public decimal Nvc { get; private set; }
        public decimal Trc { get; private set; }
        public decimal Ppc { get; private set; }
        public decimal Ftc { get; private set; }
		public decimal Usd { get; private set; }
		public decimal Rur { get; private set; }
        public decimal Eur { get; private set; }
        public decimal Xpm { get; private set; }

		public static Funds ReadFromJObject(JObject o) {
			if ( o == null )
				return null;
			return new Funds() {
                Btc = o.Value<decimal>("btc"),
                Ltc = o.Value<decimal>("ltc"),
                Nmc = o.Value<decimal>("nmc"),
                Nvc = o.Value<decimal>("nvc"),
                Trc = o.Value<decimal>("trc"),
                Ppc = o.Value<decimal>("ppc"),
                Ftc = o.Value<decimal>("Ftc"),
                Usd = o.Value<decimal>("usd"),
                Rur = o.Value<decimal>("rur"),
                Eur = o.Value<decimal>("eur"),
                Xpm = o.Value<decimal>("xpm")
			};
		}
	};

}
