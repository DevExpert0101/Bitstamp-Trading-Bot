using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTCETradeBot.UI
{
    /// <summary>
    /// Holds the user's balance in multiple currencies
    /// </summary>
    public class Balance
    {
        /// <summary>
        /// Initialises a new instance of the class
        /// </summary>
        public Balance()
        {
            Balances = new Dictionary<string, decimal>();
        }
        /// <summary>
        /// Holds balances per currency
        /// </summary>
        public Dictionary<string, decimal> Balances { get; private set; }

        /// <summary>
        /// Gets the balance for the specified currency
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public decimal this[string currency]
        {
            get { return Balances[currency]; }
        }
    }
}
