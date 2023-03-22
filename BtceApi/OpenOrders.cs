using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Bitstamp
{
    public class OpenOrdersContainer
    {
        /// <summary>
        /// The list of open orders
        /// </summary>
        public List<OrderDetails> Orders { get; private set; }

        public OpenOrdersContainer()
        {
            Orders = new List<OrderDetails>();
        }

        public static OpenOrdersContainer CreateFromJObject(JArray array)
        {
            if (array == null)
            {
                return null;
            }

            OpenOrdersContainer result = new OpenOrdersContainer();

            foreach (var item in array)
            {
                result.Orders.Add(OrderDetails.CreateFromJObject(item as JObject));
            }

            return result;
        }
    }
}
