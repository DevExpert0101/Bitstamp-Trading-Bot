using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Bitstamp;
namespace BTCETradeBot.Bus
{
    class NewVersion
    {
        public static string GetOnlineVersion()
        {
            try
            {
                var sms = new SMSRequestSmoothHttpRequest();

                var response = sms.GetResponse("https://sourceforge.net/projects/btcetradebot/");

                var start = response.IndexOf("BTCETradeBot Version ") + ("BTCETradeBot Version ").Length;
                var str1 = response.Substring(start, 20);

                var end = str1.Length - 1;
                int output;
                while (!int.TryParse(str1[end].ToString(), out output))
                    end--;

                var version = str1.Substring(0, end + 1);
                return version;
            }
            catch (Exception e)
            {
                return "0.0.0.0";
            }
        }

        public static void DownloadLatestVersion()
        {
            System.Diagnostics.Process.Start("https://sourceforge.net/projects/btcetradebot/files/latest/download");
        }

        public static int CheckForNewVersion(out Version onlineVersion)
        {
            onlineVersion = Version.Parse(GetOnlineVersion());
            var thisVersion = Assembly.GetExecutingAssembly().GetName().Version;
            var result = onlineVersion.CompareTo(thisVersion);
            return result;
        }
    }
}
