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
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BTCETradeBot
{
    public class AppData
    {
        public AppData(string fileName)
        {
            DataFileName = fileName;
        }

        public class LogObj
        {
            //Important
            public int Credit;
            public DateTime Date;
        }

        public string DataFileName = "Data.xml";
        public string LogFileName = "Log";


        public SettingsObject Settings;
        public class SettingsObject
        {
            public string Key;
            public string Secret;
            public string CID;
            public bool FirstUse;

            public Bitstamp.Filtering.RequestModes AppRequestMode;
            public bool AutoStart;
            public decimal UpdateIntervalms;
            public bool AllowTrade;
            public bool AllowSell;
            public bool AllowBuy;
            public decimal BuyDeltaThreshold;
            public decimal SellDeltaThreshold;
            public decimal BuyProfit;
            public decimal SellProfit;
            public bool ConsiderFeeInSell;
            public bool ConsiderFeeInBuy;
            public string BuyAmount;
            public string SellAmount;
            public int AmountRoundDigits;
            public int RateRoundDigits;
            public bool CancelOrders;
            public decimal CancelOrderTimeoutms;


            public string Username;
            public string Password;
            //public int Threshold;
            //public int Interval;
            public bool SeperateDays;

            public bool LimitBuyOrders;
            public decimal LimitBuyOrdersValue;
            public bool LimitSellOrders;
            public decimal LimitSellOrdersValue;
            public bool CancelBuyOrders;
            public decimal CancelBuyOrdersTimeout;
            public bool CancelSellyOrders;
            public decimal CancelSellOrdersTimeout;
            public bool BuyCondition; //True: > , False : < 
            public bool SellCondition; //True : > , False : <
            public bool UseTrueTruePermission;
            public Bitstamp.BitstampPair activePair;
            public List<LogObj> History = new List<LogObj>();
            //public bool ExecOnFreeEnabled;
            //public string ExecOnFree;
            //public string ExecOnFreeParameters;
            public bool AutoCheckForUpdate;
            //public bool ExecOnNotFreeEnabled;
            //public string ExecOnNotFree;
            //public string ExecOnNotFreeParameters;
        }

        public LogObject Logs;
        public class LogObject
        {
            public List<LogObj> Log = new List<LogObj>();
        }

        private string GetDataPath()
        {
            var path = Application.StartupPath;
            if (!path.EndsWith("\\"))
                path += "\\";
            return path;
        }

        public bool LoadData()
        {
            return LoadSettings() && LoadLog();
        }

        public bool LoadSettings()
        {
            try
            {
                var ser = new XmlSerializer(typeof(SettingsObject));
                // read
                using (var stream = File.OpenRead(GetDataPath() + DataFileName))
                {
                    Settings = (SettingsObject)ser.Deserialize(stream);
                }
                if (Settings == null)
                    throw new Exception();
                return true;
            }
            catch (Exception e2)
            {
                LoadDefaultSettings();
                return false;
            }
        }

        public void LoadDefaultSettings()
        {
            Settings = new SettingsObject();
            Settings.Key = "";
            Settings.Secret = "";
            Settings.CID = "";
            Settings.FirstUse = true;

            Settings.AppRequestMode = Bitstamp.Filtering.RequestModes.SmoothHttpRequest;
            Settings.AutoStart = true;
            Settings.UpdateIntervalms = 10000;
            Settings.AllowTrade = false;
            Settings.AllowSell = false;
            Settings.AllowBuy = false;
            Settings.BuyDeltaThreshold = 0.1m;
            Settings.SellDeltaThreshold = -0.1m;
            Settings.BuyProfit = 0.002m;
            Settings.SellProfit = 0.002m;
            Settings.BuyAmount = "0.0104";
            Settings.SellAmount = "0.0104";
            Settings.CancelOrders = true;
            Settings.CancelOrderTimeoutms = 10000;
            Settings.AutoCheckForUpdate = true;
            Settings.AmountRoundDigits = 8;
            Settings.RateRoundDigits = 3;

            Settings.ConsiderFeeInSell = true;
            Settings.ConsiderFeeInBuy = true;
            Settings.Username = "";
            Settings.Password = "";
            Settings.SeperateDays = true;

            Settings.LimitBuyOrders = true;
            Settings.LimitBuyOrdersValue = 1;
            Settings.LimitSellOrders = true;
            Settings.LimitSellOrdersValue = 1;
            Settings.CancelBuyOrders = false;
            Settings.CancelBuyOrdersTimeout = 240m;
            Settings.CancelSellyOrders = false;
            Settings.CancelSellOrdersTimeout = 240m;



            Settings.BuyCondition = true; //True: > , False : < 
            Settings.SellCondition = false; //True : > , False : <

            Settings.UseTrueTruePermission = true;
            Settings.activePair = Bitstamp.BtcePairHelper.FromString("eur_usd");

            Settings.History = new List<LogObj>();
        }

        public bool LoadLog()
        {
            try
            {
                var ser = new XmlSerializer(typeof(LogObject));
                // read
                using (var stream = File.OpenRead(GetLogPath()))
                {
                    Logs = (LogObject)ser.Deserialize(stream);
                }
                if (Logs == null)
                    throw new Exception();
                return true;
            }
            catch (Exception e2)
            {
                Logs = new LogObject();
                Logs.Log = new List<LogObj>();
                return false;
            }
        }

        private string GetLogPath()
        {
            var path = GetDataPath() + LogFileName + " " +
                DateTime.Now.Date.Year + "-" +
                DateTime.Now.Month + "-" +
                DateTime.Now.Day

                + ".xml";
            return path;
        }

        public void SaveData()
        {
            SaveSettings();
            SaveLogs();
        }

        public void SaveSettings()
        {
            try
            {
                var ser = new XmlSerializer(typeof(AppData.SettingsObject));
                // write
                using (var stream = File.Create(GetDataPath() + DataFileName))
                {
                    ser.Serialize(stream, Settings); // your instance
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in saving data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void SaveLogs()
        {
            try
            {
                var ser = new XmlSerializer(typeof(LogObject));
                // write
                using (var stream = File.Create(GetLogPath()))
                {
                    ser.Serialize(stream, Logs); // your instance
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in saving log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
