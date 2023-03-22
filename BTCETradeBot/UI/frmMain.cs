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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using Bitstamp;
using BTCETradeBot.Bus;
using BTCETradeBot.UI;
using BTCETradeBot.Properties;
using RestSharp;
using System.Security.Cryptography;
using System.Net;

namespace BTCETradeBot
{
    public partial class frmMain : Form
    {
        //  var depth3 = BtceApiV3.GetDepth(new BtcePair[] { BtcePair.btc_usd });
        //  var ticker3 = BtceApiV3.GetTicker(new BtcePair[] { BtcePair.btc_usd });
        //  var trades3 = BtceApiV3.GetTrades(new BtcePair[] { BtcePair.btc_usd });
        //X var ticker = BtceApi.GetTicker(BtcePair.btc_usd);
        //X var trades = BtceApi.GetTrades(BtcePair.btc_usd);
        //  var btcusdDepth = BtceApi.GetDepth(BtcePair.usd_rur);
        //X var fee = BtceApi.GetFee(BtcePair.btc_usd);

        //X var btceApi = new BtceApi("API_KEY", "API_SECRET");
        //X var btceApi = new BtceApi(Key, Secret);
        //X var info = btceApi.GetInfo();
        //  var transHistory = btceApi.GetTransHistory();
        //  var tradeHistory = btceApi.GetTradeHistory(count: 20);
        //X var orderList = btceApi.GetOrderList();
        //X var tradeAnswer = btceApi.Trade(BtcePair.btc_usd, TradeType.Sell, 20, 0.1m);
        //X var cancelAnswer = btceApi.CancelOrder(tradeAnswer.OrderId);
        private IExchange _proxy;
        private CurrencyPair _selectedPair;

        private BitstampApi _btceApi;
        private decimal _fee;
        private UserInfo _info;
        private Ticker _ticker;
        List<TradeInfo> _trades = new List<TradeInfo>();
        private OrderList _activeOrders;

        private int _myBuyCount = 0;
        private int _mySellCount = 0;

        private bool _quiting = false;
        private readonly ListViewColumnSorter listViewColumnSorter;
        private readonly ListViewColumnSorter listViewColumnSorter2;

        //private decimal _minimumBuyThreshold;
        //private decimal _minimumSellThreshold;
        private decimal _buyThreshold;
        private decimal _sellThreshold;

        private AppData _appData;
        private bool _successfulLoad;
        private bool _needSave = false;


        private bool _activeOrdersError;
        private int _activeBuyOrders;
        private int _activeSellOrders;


        BitstampPair _activePair = new BitstampPair();
        public string _currency;
        public string _good;


        private bool _started;
        private int _cancelledBuys;
        private int _cancelledSells;
        private string _notAvailable = "N/A";

        #region BotInfo
            private int _oldLevel = 0;
            private decimal _newBuyPrice = 0m;
            private decimal _newSellPrice = decimal.MaxValue;
            private decimal _newMid = 0m;
            private decimal _lastMid = 0m;
            private decimal _deltaMid = 0m;
        #endregion
        
        private void ResetBot()
        {
            _oldLevel = 0;
            _newBuyPrice = 0m;
            _newSellPrice = decimal.MaxValue;
            _newMid = 0m;
            _lastMid = 0m;
            _deltaMid = 0m;

            listViewTrades.Items.Clear();
            listViewOrders.Items.Clear();
            labelTotalBidOrders.Text = _notAvailable;
            labelTotalBidAmount.Text = _notAvailable;
            labelTotalBidValue.Text = _notAvailable;
            labelBidAVG.Text = _notAvailable;
            labelTotalAskOrders.Text = _notAvailable;
            labelTotalAskAmount.Text = _notAvailable;
            labelTotalAskValue.Text = _notAvailable;
            labelAskAVG.Text = _notAvailable;

            labelBidAskAverage.Text = _notAvailable;

            labelTicker.Text = _notAvailable;
            labelNewMid.Text = _notAvailable;
            labelOldMid.Text = _notAvailable;
            labelOldMid2.Text = _notAvailable;
            labelOldMid3.Text = _notAvailable;
            labelDelta.Text = _notAvailable;
            labelDelta2.Text = _notAvailable;
            labelDelta3.Text = _notAvailable;
            labelEstimationResult.Text = _notAvailable;
            labelEstimationResult2.Text = _notAvailable;
            labelTradePermission.Text = _notAvailable;
            labelBuyThresholdValue.Text = _notAvailable;
            labelSellThresholdValue.Text = _notAvailable;
            textBoxBTCEBuyPrice.Text = _notAvailable;
            textBoxBTCESellPrice.Text = _notAvailable;
            textBoxBuyFee.Text = _notAvailable;
            textBoxSellFee.Text = _notAvailable;
            textBoxCalcBuyPrice.Text = _notAvailable;
            textBoxCalcSellPrice.Text = _notAvailable;
            labelBuyPriceDelta.Text = _notAvailable;
            labelSellPriceDelta.Text = _notAvailable;
            textBoxAutoBuyTotalResult.Text = _notAvailable;
            textBoxAutoSellTotalResult.Text = _notAvailable;
            labelBuyCount.Text = _notAvailable;
            labelSellCount.Text = _notAvailable;
            labelManualBuyTotalAmount.Text = _notAvailable;
            labelManualSellTotalAmount.Text = _notAvailable;
            labelManualBuyResult.Text = _notAvailable;
            labelManualSellResult.Text = _notAvailable;
            labelCancelledBuysCount.Text = _notAvailable;
            labelCancelledSellsCount.Text = _notAvailable;
            textBoxCancellBuyResult.Text = _notAvailable;
            textBoxCancelSellResult.Text = _notAvailable;
            textBoxCancelOrderResult.Text = _notAvailable;

            //labelManualBuyCurrency.Text = _notAvailable;
            comboBoxManualBuyCurrency.Items.Clear();
            comboBoxManualSellCurrency.Items.Clear();
            //labelManualSellCurrency.Text = _notAvailable;
            _currency = " USD";
            _good = " BTC";
            comboBoxManualBuyAmount.Text = "0";
            comboBoxManualSellAmount.Text = "0";

            textBoxManualBuyRate.Text = "";
            textBoxManualSellRate.Text = "";
        }

        public BitstampPair ActivePair
        {
            set
            {
                _activePair = value;
                comboBoxActivePair.Text = BtcePairHelper.ToBetterString( _activePair.ToString());
                _currency = " " + _activePair.ToString().Substring(_activePair.ToString().Length - 3, 3).ToUpper();
                _good = " " + _activePair.ToString().Substring(0, 3).ToUpper();
                _appData.Settings.activePair = _activePair;
                checkBoxAutoTrade.Text = "Auto Trade" + _good;
                groupBoxManualTrade.Text = "Manual Trade" + _good;
                //labelManualBuyCurrency.Text = "(" + _currency.Trim() + ")";
                comboBoxManualBuyCurrency.Items.Clear();
                comboBoxManualBuyCurrency.Items.Add(_currency.Trim());
                comboBoxManualBuyCurrency.Items.Add(_good.Trim());
                comboBoxManualBuyCurrency.SelectedIndex = 0;
                
                comboBoxManualSellCurrency.Items.Clear();
                comboBoxManualSellCurrency.Items.Add(_currency.Trim());
                comboBoxManualSellCurrency.Items.Add(_good.Trim());
                comboBoxManualSellCurrency.SelectedIndex = 1;
                
                //labelManualSellCurrency.Text = _good.Trim();
                labelManualBuyTitle.Text = "Buy" + _good + ":";
                labelManualSellTitle.Text = "Sell" + _good + ":";
                _needSave = true;
            }
            get
            {
                return _activePair;
            }
        }

        private void comboBoxActivePair_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetBot();
            ActivePair = BtcePairHelper.FromBetterString(comboBoxActivePair.Text);
            if(_started)
                timerRefreshGlobal_Tick(sender, e);
        }


        public frmMain()
        {
            InitializeComponent();
            listViewColumnSorter = new ListViewColumnSorter();
            listViewColumnSorter2 = new ListViewColumnSorter();

            listViewTrades.ListViewItemSorter = listViewColumnSorter;
            listViewOrders.ListViewItemSorter = listViewColumnSorter2;
            
            this.Icon = frmAbout.ImageToIcon(Resources.Stocks_Icon_256);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _appData = new AppData("Settings.xml");
            _successfulLoad = _appData.LoadData();
            _appData.LoadLog();
            
            
            PrepareListViewTrades();
            PrepareListViewOrders();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            //buttonFocus.Focus();
            SetRulesTooltip();
            if (_appData.Settings.FirstUse)
            {
                if (string.IsNullOrEmpty(_appData.Settings.Secret))
                    textBoxAPISecret.Text = "";

                if (MessageBox.Show(
                    @"Copyright (c)
Donate: " + Business.GetDonationAddress() + @"

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>." +
                    "\n\nAnd please consider dontation.\n\nDo you accept the software lisence agreement and want to continue?", "BitstampTradeBot", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    _needSave = false;
                    Exit(false);
                }
                if (MessageBox.Show("Do you want to see the warning next time you use this application?", "BitstampBot", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    _appData.Settings.FirstUse = false;
                    _appData.SaveSettings();
                }
            }

            FillGui();
            _needSave = false;
            _btceApi = new BitstampApi(_appData.Settings.Key, _appData.Settings.Secret, txtID.Text);

            if (_appData.Settings.AutoStart)
                StartApplication();
            else
                StopApplication();
        }

        private void SetRulesTooltip()
        {
            toolTip1.SetToolTip(textBoxCalcBuyPrice,"Calculated Buy Rate = (BTC-E.Buy) * (1 - fee) * (1 - profit)");
            toolTip1.SetToolTip(textBoxCalcSellPrice,"Calculated Sell Rate = (BTC-E.Sell) * (1 + fee) * (1 + profit)");
            
            toolTip1.SetToolTip(textBoxAutoBuyTotalResult,"What you'll get after buy = Amount * (1 - fee)");
            toolTip1.SetToolTip(textBoxAutoSellTotalResult, "What you'll get after sell = Amount * (Calculated Sell Rate) * (1 - fee)");
        }

        private bool _waitForPreviousTimerGlobal;
        private void timerRefreshGlobal_Tick(object sender, EventArgs e)
        {
            if(_quiting)
                return;

            if(_waitForPreviousTimerGlobal)
                return;

            _waitForPreviousTimerGlobal = true;
            //---------------------------------
            RefreshTimerGlobal();
            //---------------------------------
            _waitForPreviousTimerGlobal = false;
        }

        private void RefreshTimerGlobal()
        {
            if (_quiting)
                return;
            _btceApi = new BitstampApi(_appData.Settings.Key, _appData.Settings.Secret, txtID.Text);

            toolStripStatusLabelLastCheck.Text = "Updating ...";
            toolStripStatusLabelLastCheck.ForeColor = Color.Green;
            this.Update();

            RefreshFee();
            RefreshTicker();
            RefreshAPIInfo();
            RefreshActiveOrders();
            ManageOrdersTimeOut();



            //Order is important!
            if (RefreshGlobalTrades())
            {
                CalculateStatistics();
                SetThresholds();
                AutoTrade();
            }

            toolStripStatusLabelLastCheck.Text = "Last Check: " + DateTime.Now.ToString();
            toolStripStatusLabelLastCheck.ForeColor = Color.Blue;

        }

        private bool _waitForPreviousRefreshFee;
        private bool RefreshFee()
        {
            if (_quiting)
                return false;

            if (_waitForPreviousRefreshFee)
                return false;
            _waitForPreviousRefreshFee = true;

            try
            {
                //_fee = BitstampApi.GetFee(ActivePair);
               var _fees = _btceApi.GetBalance();
                toolStripStatusLabelFee.Text = "Fee: " + _fees.Result.Fee.ToString() + "%";

                _waitForPreviousRefreshFee = false;
                return true;
            }
            catch (Exception e)
            {
                _fee = 0.2m;
                toolStripStatusLabelFee.Text = e.Message;

                _waitForPreviousRefreshFee = false;
                return false;
            }
        }

        private bool _waitForPreviousRefreshTicker;
        private bool RefreshTicker()
        {
            if (_quiting)
                return false;

            if (_waitForPreviousRefreshTicker)
                return false;
            _waitForPreviousRefreshTicker = true;

            labelTickerTradesStatus.Text = "Loading";
            this.Update();

            try
            {
                _ticker = BitstampApi.GetTicker(ActivePair);
                labelTicker.Text = string.Format(
                @"Buy: {1}
Sell: {5}
Average: {0}
High: {2}
Last: {3}
Low: {4}
Volume: {6}
Volume Current: {7}
Server Time: {8}",
                _ticker.Average + _currency,
                _ticker.Buy + _currency,
                _ticker.High + _currency,
                _ticker.Last + _currency,
                _ticker.Low + _currency,
                _ticker.Sell + _currency,
                _ticker.Volume,
                _ticker.VolumeCurrent,
                _ticker.ServerTime);

                ChangeStatus(_ticker.Buy, _ticker.Sell);

                labelTickerTradesStatus.Text = "Ticker loaded";

                _waitForPreviousRefreshTicker = false;
                return true;
            }
            catch (Exception e)
            {
                labelTickerTradesStatus.Text = e.Message;
                _ticker = null;
                labelTicker.Text = e.Message;

                _waitForPreviousRefreshTicker = false;
                return false;
            }
        }

        private void ChangeStatus(decimal buy, decimal sell)
        {
            string sqlitepath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\priceorder.sqlite";
            string myConnectionString = "Data Source=" + sqlitepath + "; Version = 3; New = True; Compress = True;";

            SQLiteConnection sqlite_conn = new SQLiteConnection(myConnectionString);
            SQLiteCommand sqlite_cmd;

            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();


            try
            {
                sqlite_cmd.CommandText = "UPDATE price_order SET status=" + "\"complete" + "\"" + " WHERE status=" + "\"" + "pending" + "\"" + " AND " + "type=" + "\"" +
                    "buy" + "\"" + " AND " + "price>" + buy + ";";
                
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "UPDATE price_order SET status=" + "\"complete" + "\"" + " WHERE status=" + "\"" + "pending" + "\"" + " AND " + "type=" + "\"" +
                    "sell" + "\"" + " AND " + "price<" + sell + ";";
                sqlite_cmd.ExecuteNonQuery();
            }
            catch { }
        }

        private bool _waitForPreviousRefreshTrades;
        private bool  RefreshGlobalTrades()
        {
            if (_quiting)
                return false;

            if (_waitForPreviousRefreshTrades)
                return false;
            _waitForPreviousRefreshTrades = true;

            labelTickerTradesStatus.Text = "Loading";
            this.Update();

            try
            {
                _trades = BitstampApi.GetTrades(ActivePair);
                listViewTrades.Items.Clear();
                foreach (var tradeInfo in _trades)
                    AddItemToListViewTrades(tradeInfo);
                labelTickerTradesStatus.Text = "Trades loaded";

                _waitForPreviousRefreshTrades = false;
                return true;
            }
            catch (Exception e)
            {
                _trades = null;
                labelTickerTradesStatus.Text = e.Message;

                _waitForPreviousRefreshTrades = false;
                return false;
            }
        }

        public string GetUnCurrencedString(string s)
        {
            if (s.Length > 3)
                return s.Substring(0, s.Length - 3).Trim();
            return s;
        }
        private void CalculateStatistics()
        {
            if (_quiting)
                return;
            if (_ticker == null)
                return;

            var bidBitcoinCount = 0m;
            var bidOrders = 0;
            var bidPrice = 0m;

            var askBitcoinCount = 0m;
            var askOrders = 0;
            var askPrice = 0m;

            foreach (var tradeInfo in _trades)
            {
                if(tradeInfo.Type==TradeInfoType.Bid)
                {
                    bidBitcoinCount += tradeInfo.Amount;
                    bidPrice += tradeInfo.Amount*tradeInfo.Price;
                    bidOrders++;
                }

                if (tradeInfo.Type == TradeInfoType.Ask)
                {
                    askBitcoinCount += tradeInfo.Amount;
                    askOrders++;
                    askPrice += tradeInfo.Amount * tradeInfo.Price;
                }
            }

            decimal newBidAVG, newAskAVG;
            if(bidBitcoinCount>0)
                newBidAVG = bidPrice/bidBitcoinCount;
            else
                newBidAVG = _ticker.Sell;

            if (askBitcoinCount > 0)
                newAskAVG = askPrice / askBitcoinCount;
            else
                newAskAVG = _ticker.Buy;

            labelBidAVG.Text = Math.Round(newBidAVG,_appData.Settings.RateRoundDigits).ToString() + _currency;
            labelAskAVG.Text = Math.Round(newAskAVG, _appData.Settings.RateRoundDigits).ToString() + _currency;
            labelBidAskAverage.Text = Math.Round(((newBidAVG + newAskAVG) / 2), _appData.Settings.RateRoundDigits).ToString() + _currency;

            _oldLevel++;
            _lastMid = _newMid;
            //_newMid =  (newAskAVG + newBidAVG) / 2;
            _newMid = (_ticker.Sell + _ticker.Buy) / 2;
            _deltaMid = _newMid - _lastMid;

            //decimal myBuyPrice = decimal.Round(_ticker.Buy - Math.Abs(deltaMid), 3);
            //decimal mySellPrice = decimal.Round(_ticker.Sell + Math.Abs(deltaMid) , 3);
            labelOldMid3.Text = labelOldMid2.Text;
            labelOldMid2.Text = labelOldMid.Text;
            if(_lastMid!=0)
                labelOldMid.Text = (_lastMid).ToString();
            labelNewMid.Text = (_newMid).ToString();

            labelDelta.Text = (_newMid - _lastMid).ToString() + _currency;
            FormatDeltaLabel(labelDelta,GetUnCurrencedString(labelDelta.Text));
            
            if (_oldLevel > 2)
            {
                labelDelta2.Text = ((decimal.Parse(labelOldMid.Text) - decimal.Parse(labelOldMid2.Text))).ToString() + _currency;
                FormatDeltaLabel(labelDelta2, GetUnCurrencedString(labelDelta2.Text));

                if ((Math.Sign(decimal.Parse(GetUnCurrencedString(labelDelta.Text))) == Math.Sign(decimal.Parse(GetUnCurrencedString(labelDelta2.Text)))) && (decimal.Parse(GetUnCurrencedString(labelDelta.Text))!=0))
                {
                    labelEstimationResult.Text = "True";
                    labelEstimationResult.ForeColor = Color.Green;
                }
                else
                {
                    labelEstimationResult.Text = "False";
                    labelEstimationResult.ForeColor = Color.Red;
                }
            }

            if (_oldLevel > 3)
            {
                labelDelta3.Text = ((decimal.Parse(labelOldMid2.Text) - decimal.Parse(labelOldMid3.Text))).ToString() + _currency;
                FormatDeltaLabel(labelDelta3,GetUnCurrencedString(labelDelta3.Text));

                if ((Math.Sign(decimal.Parse(GetUnCurrencedString(labelDelta2.Text))) == Math.Sign(decimal.Parse(GetUnCurrencedString(labelDelta3.Text)))))
                {
                    labelEstimationResult2.Text = "True";
                    labelEstimationResult2.ForeColor = Color.Green;
                }
                else
                {
                    labelEstimationResult2.Text = "False";
                    labelEstimationResult2.ForeColor = Color.Red;
                }

                if ((labelEstimationResult.Text == labelEstimationResult2.Text) && (labelEstimationResult2.Text == "True"))
                {
                    labelTradePermission.Text = "True";
                    labelTradePermission.ForeColor = Color.Green;
                }
                else
                {
                    labelTradePermission.Text = "False";
                    labelTradePermission.ForeColor = Color.Red;
                }
            }            

            labelTotalAskOrders.Text = askOrders.ToString();
            labelTotalAskAmount.Text = (askBitcoinCount).ToString() + _good;
            labelTotalAskValue.Text = (Math.Round(askPrice,_appData.Settings.RateRoundDigits)).ToString() + _currency;

            labelTotalBidOrders.Text = bidOrders.ToString();
            labelTotalBidAmount.Text = (bidBitcoinCount).ToString() + _good;
            labelTotalBidValue.Text = (Math.Round(bidPrice, _appData.Settings.RateRoundDigits)).ToString() + _currency;
        }

        private bool SetThresholds()
        {
            if (_ticker == null)
                return false;
            try
            {
                decimal realFee = _fee * 0.01m;
                textBoxBuyFee.Text = textBoxSellFee.Text = realFee.ToString();
                //_minimumBuyThreshold = realFee * decimal.Parse(textBoxBuyAmount.Text) * decimal.Parse(labelBidAVG.Text);
                //_minimumSellThreshold = realFee * decimal.Parse(textBoxSellAmount.Text) * decimal.Parse(labelAskAVG.Text);

                //_buyThreshold = _minimumBuyThreshold + decimal.Parse(textBoxBuyThreshold.Text);
                //_sellThreshold = _minimumSellThreshold + decimal.Parse(textBoxSellThreshold.Text);
                _buyThreshold = decimal.Parse(textBoxBuyThreshold.Text) * 0.01m * (_ticker.Buy + _ticker.Sell) / 2;
                _sellThreshold = decimal.Parse(textBoxSellThreshold.Text) * 0.01m * (_ticker.Buy + _ticker.Sell) / 2;
                
                toolTip1.SetToolTip(textBoxBuyThreshold, _buyThreshold.ToString() + _currency);
                toolTip1.SetToolTip(textBoxSellThreshold, _sellThreshold.ToString() + _currency);

                labelThresholdCurrency.Text = "Threshold (" + _currency.Trim() + ")";
                labelBuyThresholdValue.Text = "= " + _buyThreshold + _currency;
                labelSellThresholdValue.Text = "= " + _sellThreshold + _currency;

                //labelBuyThreshold.Text = decimal.Round(_minimumBuyThreshold, 3).ToString() + " + ";
                //labelSellThreshold.Text = decimal.Round(_minimumSellThreshold, 3).ToString() + " + ";

                //_newBuyPrice = decimal.Round(_ticker.Buy - _minimumBuyThreshold - decimal.Parse(textBoxBuyThreshold.Text), 3);
                //_newSellPrice = decimal.Round(_ticker.Sell + _minimumBuyThreshold + decimal.Parse(textBoxSellThreshold.Text), 3);

                _newBuyPrice = decimal.Round(_ticker.Buy * (_appData.Settings.ConsiderFeeInBuy ? (1 - realFee) : 1) * (1 - _appData.Settings.BuyProfit), _appData.Settings.RateRoundDigits);
                _newSellPrice = decimal.Round(_ticker.Sell * (_appData.Settings.ConsiderFeeInSell ? (1 + realFee) : 1) * (1 + _appData.Settings.SellProfit), _appData.Settings.RateRoundDigits);

                textBoxCalcBuyPrice.Text =  _newBuyPrice.ToString() + _currency;
                textBoxCalcSellPrice.Text = _newSellPrice.ToString() + _currency;

                textBoxAutoBuyTotalResult.Text = (GetAutoBuyAmount(_newBuyPrice) * (1 - realFee)).ToString() + _good;
                textBoxAutoSellTotalResult.Text = (GetAutoSellAmount() * _newSellPrice * (1 - realFee)).ToString() + _currency;

                textBoxBTCEBuyPrice.Text = _ticker.Buy.ToString() + _currency;
                textBoxBTCESellPrice.Text = _ticker.Sell.ToString() + _currency;

                labelBuyPriceDelta.Text = (_newBuyPrice - _ticker.Buy).ToString() + _currency;
                labelSellPriceDelta.Text = (_newSellPrice - _ticker.Sell).ToString() + _currency;
            }
            catch (Exception exception)
            {
                return false;
            }
            return true;
        }

        private decimal GetAutoBuyAmount(decimal buyPrice)
        {
            decimal val = 0m;
            if (buyPrice == 0)
                return 0;

            if (_appData.Settings.BuyAmount.ToLower() == "all")
                return GetAll(_currency.ToLower().Trim()) / buyPrice;
            else 
                decimal.TryParse(_appData.Settings.BuyAmount, out val);
            return val;
        }

        private decimal GetAutoSellAmount()
        {
            decimal val = 0m;

            if (_appData.Settings.SellAmount.ToLower() == "all")
                return GetAll(_good.ToLower().Trim());
            else
                decimal.TryParse(_appData.Settings.SellAmount, out val);
            return val;
        }

        private decimal GetManualBuyAmount()
        {
            decimal val = 0m;

            if (comboBoxManualBuyAmount.Text.ToLower() == "all")
                return GetAll(_currency.ToLower().Trim());
            else
                decimal.TryParse(comboBoxManualBuyAmount.Text, out val);
            return val;
        }

        private decimal GetManualSellAmount()
        {
            decimal val = 0m;

            if (comboBoxManualSellAmount.Text.ToLower() == "all")
                return GetAll(_good.ToLower().Trim());
            else
                decimal.TryParse(comboBoxManualSellAmount.Text, out val);
            return val;
        }

        private void AutoTrade()
        {
            if(_quiting)
                return;

            if (_ticker == null)
                return;

            if(_oldLevel <= 3)
                return;

            //if (string.IsNullOrEmpty(_appData.Settings.Key) || string.IsNullOrEmpty(_appData.Settings.Secret))
            //    return;

            SetThresholds();

            decimal buyAmount = GetAutoBuyAmount(_newBuyPrice);
            decimal sellAmount = GetAutoSellAmount();

            var trueTrue = ((labelEstimationResult.Text == "True") && (labelEstimationResult2.Text == "True"));

            if ((_appData.Settings.AllowTrade && _lastMid > 0) && (trueTrue || !_appData.Settings.UseTrueTruePermission))
            {
                TradeAnswer tradeAnswer;

                var buyCondition = false;
                if (_appData.Settings.BuyCondition) // >
                    buyCondition = _deltaMid > _buyThreshold;
                else // <
                    buyCondition = _deltaMid < _buyThreshold;

                var sellCondition = false;
                if (_appData.Settings.SellCondition) // >
                    sellCondition = _deltaMid > _sellThreshold;
                else // <
                    sellCondition = _deltaMid < _sellThreshold; 

                labelSellNote.Text = "Not triggered";
                labelSellNote.ForeColor = Color.Black;
                labelBuyNote.Text = "Not triggered";
                labelBuyNote.ForeColor = Color.Black;


                if (buyCondition)
                {
                    
                    //Should Buy!
                    //if (_info.Funds.Usd > tradeValue*_ticker.Buy)
                    if (checkBoxAllowBuy.Checked)
                    {
                        if (!checkBoxLimitBuyOrders.Checked || (!_activeOrdersError && _activeBuyOrders < numericUpDownLimitBuyOrders.Value))
                        {
                            try
                            {
                                var rate = Math.Round(_newBuyPrice, _appData.Settings.RateRoundDigits);
                                var amount = Math.Round(buyAmount, _appData.Settings.AmountRoundDigits);
                                _myBuyCount++;
                                RecordToDatabase(_activePair, "buy", rate, amount, DateTime.Now);
                                var tradeAnswers = _btceApi.PlaceBuyOrder(amount,rate);
                                
                                labelBuyNote.Text = "Done";
                                toolTip1.SetToolTip(labelBuyNote, "Done");
                                labelBuyNote.ForeColor = Color.Green;
                                toolStripStatusLabelLastBought.Text = "Last buy: " + DateTime.Now.ToString();
                            }
                            catch (Exception e)
                            {
                                _myBuyCount--;
                                labelBuyNote.Text = e.Message;
                                toolTip1.SetToolTip(labelBuyNote, e.Message);
                                labelBuyNote.ForeColor = Color.Red;
                            }
                            RefreshActiveOrders();
                        }
                    }
                }
                else if (sellCondition)
                {
                    //Should Sell!
                    //if (_info.Funds.Btc > tradeValue)
                    if (checkBoxAllowSell.Checked)
                    {
                        if (!checkBoxLimitSellOrders.Checked || (!_activeOrdersError && _activeSellOrders < numericUpDownLimitSellOrders.Value))
                        {
                            try
                            {
                                _mySellCount++;
                                var rate = Math.Round(_newSellPrice, _appData.Settings.RateRoundDigits);
                                var amount = Math.Round(sellAmount, _appData.Settings.AmountRoundDigits);
                                RecordToDatabase(_activePair, "sell", rate, amount, DateTime.Now);
                                var tradeAnswers = _btceApi.PlaceSellOrder(amount, rate);
                                labelSellNote.Text = "Done";
                                toolTip1.SetToolTip(labelSellNote, "Done");
                                labelSellNote.ForeColor = Color.Green;
                                toolStripStatusLabelLastSold.Text = "Last sell: " + DateTime.Now.ToString();
                            }
                            catch (Exception e)
                            {
                                _mySellCount--;
                                labelSellNote.Text = e.Message;
                                toolTip1.SetToolTip(labelSellNote, e.Message);
                                labelSellNote.ForeColor = Color.Red;
                            }
                            RefreshActiveOrders();
                        }
                    }
                    else
                    {
                        labelSellNote.Text = "Not triggered";
                        labelBuyNote.Text = "Not triggered";
                    }
                }
            }
            else
            {
                labelSellNote.Text = "Not triggered";
                labelBuyNote.Text = "Not triggered";
            }

            labelBuyCount.Text  = _myBuyCount.ToString();
            labelSellCount.Text = _mySellCount.ToString();

            labelBuyPriceDelta.Text = (_newBuyPrice - _ticker.Buy) + _currency;
            labelSellPriceDelta.Text = (_newSellPrice - _ticker.Sell) + _currency;
        }

        private bool _waitForPreviousRefreshAPIInfo;

        private void RefreshAPIInfo()
        {
            if (_quiting)
                return;

            if (string.IsNullOrEmpty(_appData.Settings.Key) || string.IsNullOrEmpty(_appData.Settings.Secret))
                return;

            if (_waitForPreviousRefreshAPIInfo)
                return;
            _waitForPreviousRefreshAPIInfo = true;

            labelAPIInfoStatus.Text = "Loading";
            this.Update();

            try
            {
                //_currency = _selectedPair.Item2;
                //var _infos = _proxy.GetBalance(_currency);
                var _info = _btceApi.GetBalance();
                //var _infos = _btceApi.GetInfo();

                textBoxFundBTC.Text = _info.Result.AvailableBTC.ToString();
                //textBoxFundLTC.Text = _infos.Result.Funds.Ltc.ToString();
                //textBoxFundNMC.Text = _infos.Funds.Nmc.ToString();
                //textBoxFundNVC.Text = _infos.Funds.Nvc.ToString();
                //textBoxFundTRC.Text = _infos.Funds.Trc.ToString();
                //textBoxFundPPC.Text = _infos.Funds.Ppc.ToString();
                //textBoxFundFTC.Text = _infos.Funds.Ftc.ToString();
                textBoxFundUSD.Text = _info.Result.AvailableUSD.ToString();
                //textBoxFundRUR.Text = _infos.Funds.Rur.ToString();
                textBoxFundEUR.Text = _info.Result.AvailableEUR.ToString();
                //textBoxFundXPM.Text = _infos.Funds.Xpm.ToString();

                //checkBoxRightInfo.Checked = _infos.Resuls.Rights.Info;
                //checkBoxRightTrade.Checked = _info.Rights.Trade;

                //textBoxInfoOpenOrders.Text = _info.OpenOrders.ToString();
                //textBoxInfoTransactionCount.Text = _info.TransactionCount.ToString();
                //textBoxInfoServerTime.Text = _info.ServerTime.ToString();
                labelAPIInfoStatus.Text = "Info loaded";

                SetComboBoxesToolTips();

                _waitForPreviousRefreshAPIInfo = false;
            }
            catch (Exception e2)
            {
                labelAPIInfoStatus.Text = e2.Message;

                //textBoxFundBTC.Text = e2.Message;
                //textBoxFundLTC.Text = e2.Message;
                //textBoxFundNMC.Text = e2.Message;
                //textBoxFundNVC.Text = e2.Message;
                //textBoxFundTRC.Text = e2.Message;
                //textBoxFundPPC.Text = e2.Message;
                //textBoxFundFTC.Text = e2.Message;
                //textBoxFundUSD.Text = e2.Message;
                //textBoxFundRUR.Text = e2.Message;
                //textBoxFundEUR.Text = e2.Message;
                //textBoxFundXPM.Text = e2.Message;

                checkBoxRightInfo.Checked = false;
                checkBoxRightTrade.Checked = false;

                //textBoxInfoOpenOrders.Text = e2.Message;
                //textBoxInfoTransactionCount.Text = e2.Message;
                //textBoxInfoServerTime.Text = e2.Message;
                _waitForPreviousRefreshAPIInfo = false;
            }
        }

        private bool _waitForPreviousRefreshActiveOrders;
        private void RefreshActiveOrders()
        {
            if (_quiting)
                return;

            if (string.IsNullOrEmpty(_appData.Settings.Key) || string.IsNullOrEmpty(_appData.Settings.Secret))
                return;

            if (_waitForPreviousRefreshActiveOrders)
                return;
            _waitForPreviousRefreshActiveOrders = true;

            labelActiveOrdersStatus.Text = "Loading";
            this.Update();

            _activeBuyOrders = 0;
            _activeSellOrders = 0;
            try
            {
                //_activeOrders = _btceApi.GetActiveOrders(ActivePair);
                var _activeOrder = _btceApi.GetOpenOrders();
                _activeOrdersError = false;
                listViewOrders.Items.Clear();
                if (_activeOrders != null)
                {
                    foreach (var l in _activeOrders.List)
                    {
                        if (l.Value.Type == TradeType.Buy)
                            _activeBuyOrders++;
                        else
                            _activeSellOrders++;

                        AddItemToListViewOrders(l.Key, l.Value);
                    }
                }
                labelActiveOrdersStatus.Text = "Done";
                _waitForPreviousRefreshActiveOrders = false;
            }
            catch (Exception e)
            {
                if (e.Message == "no orders")
                    _activeOrdersError = false;
                else
                    _activeOrdersError = true;

                //labelActiveOrdersStatus.Text = e.Message;
                labelActiveOrdersStatus.Text = "";
                _activeOrders = null;
                listViewOrders.Items.Clear();
                _waitForPreviousRefreshActiveOrders = false;
            }
        }

        private void ManageOrdersTimeOut()
        {
            if (_quiting)
                return;

            if (string.IsNullOrEmpty(_appData.Settings.Key) || string.IsNullOrEmpty(_appData.Settings.Secret) || txtID.Text=="")
                return;

            int serverTime = -1;
            if (_ticker != null)
                serverTime = int.Parse(_ticker.ServerTime.ToString());
            else if (_info != null)
                serverTime = _info.ServerTime;

            if (_activeOrders != null)
            {
                foreach (var l in _activeOrders.List)
                {
                    if (l.Value.Type == TradeType.Buy)
                    {
                        if (checkBoxCancelBuyOrders.Checked)
                        {
                            if (serverTime - l.Value.TimestampCreated > _appData.Settings.CancelBuyOrdersTimeout)
                                try
                                {
                                    _btceApi.CancelOrder(l.Key);
                                    _activeBuyOrders--;
                                    listViewOrders.Items.RemoveAt(listViewOrders.Items.Count - 1);
                                    _cancelledBuys++;
                                    labelCancelledBuysCount.Text = _cancelledBuys.ToString();
                                    textBoxCancellBuyResult.Text = "Cancelled";
                                    RefreshActiveOrders();
                                }
                                catch (Exception e)
                                {
                                    textBoxCancellBuyResult.Text = e.Message;
                                }
                        }
                    }
                    if (l.Value.Type == TradeType.Sell)
                    {
                        if (checkBoxCancelSellOrders.Checked)
                        {
                            if (serverTime - l.Value.TimestampCreated > _appData.Settings.CancelSellOrdersTimeout)
                                try
                                {
                                    _btceApi.CancelOrder(l.Key);
                                    _activeSellOrders--;
                                    listViewOrders.Items.RemoveAt(listViewOrders.Items.Count - 1);
                                    _cancelledSells++;
                                    labelCancelledSellsCount.Text = _cancelledSells.ToString();
                                    textBoxCancelSellResult.Text = "Cancelled";
                                    RefreshActiveOrders();
                                }
                                catch (Exception e)
                                {
                                    textBoxCancelSellResult.Text = e.Message;
                                }
                        }
                    }
                }
            }

        }

        private void Exit(bool restart)
        {
            if (_needSave)
            {
                var result = MessageBox.Show("Do you want to save changes before exit?", "BTCETradeBot",
                                             MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    _appData.SaveSettings();
                }
            }

            _quiting = true;

            this.Hide();
            StopApplication();
            timerRefreshGlobal.Stop();
            timerRefreshGlobal.Enabled = false;
            int i = 0;
            while (i<1000000)
            {
                i++;
                timerRefreshGlobal.Enabled = false;
                Application.DoEvents();
            }
            this.Dispose();
            if(!restart)
                Application.Exit();
            else
                Application.Restart();
        }

        private void StartStop()
        {
            if (_started)
            {
                StopApplication();
                return;
            }
            StartApplication();
        }

        private void StartApplication()
        {
            _started = true;
            timerRefreshGlobal.Start();

            startToolStripMenuItem.Text = _started ? "&Stop" : "&Start";

            toolStripStatusLabelStartStop.Text = "Started";
            toolStripStatusLabelStartStop.ForeColor = Color.Green;
            RefreshTimerGlobal();
        }

        private void StopApplication()
        {
            _started = false;
            _oldLevel = 0;
            timerRefreshGlobal.Stop();

            startToolStripMenuItem.Text = _started ? "&Stop" : "&Start";

            toolStripStatusLabelStartStop.Text = "Stopped";
            toolStripStatusLabelStartStop.ForeColor = Color.Red;
        }
        
        #region Visual
        public void ResetComboboxActivePair()
        {
            comboBoxActivePair.Items.Clear();
            
            foreach (var item in Enum.GetNames(typeof(BitstampPair)))
            {
                if(BtcePairHelper.ToBetterString(item) != "UNKNOWN")
                    comboBoxActivePair.Items.Add(BtcePairHelper.ToBetterString(item));
            }
        }

        private void FillGui()
        {
            ResetComboboxActivePair();
            ResetBot();

            ActivePair = _appData.Settings.activePair;
            textBoxAPIKey.Text = _appData.Settings.Key;
            txtID.Text = _appData.Settings.CID;

            timerRefreshGlobal.Enabled = _appData.Settings.AutoStart;

            autoStartToolStripMenuItem.Checked = _appData.Settings.AutoStart;
            numericUpDownInterval.Value = _appData.Settings.UpdateIntervalms;

            Filtering.AppRequestMode = _appData.Settings.AppRequestMode;
            webBrowserToolStripMenuItem.Checked = _appData.Settings.AppRequestMode==Bitstamp.Filtering.RequestModes.WebBrowser;
            hTTPRequestToolStripMenuItem.Checked = _appData.Settings.AppRequestMode == Bitstamp.Filtering.RequestModes.SimpleHttpRequest;
            smoothHTTPRequestToolStripMenuItem.Checked = _appData.Settings.AppRequestMode == Bitstamp.Filtering.RequestModes.SmoothHttpRequest;

            checkBoxAutoTrade.Checked = _appData.Settings.AllowTrade;
            groupBoxAutoTrade.Enabled = checkBoxAutoTrade.Checked;

            checkBoxAllowBuy.Checked = _appData.Settings.AllowBuy;
            checkBoxAllowSell.Checked = _appData.Settings.AllowSell;

            textBoxBuyThreshold.Text = _appData.Settings.BuyDeltaThreshold.ToString();
            textBoxSellThreshold.Text = _appData.Settings.SellDeltaThreshold.ToString();

            textBoxBuyProfit.Text = _appData.Settings.BuyProfit.ToString();
            textBoxSellProfit.Text = _appData.Settings.SellProfit.ToString();

            comboBoxAutoBuyAmount.Text = _appData.Settings.BuyAmount;
            comboBoxAutoSellAmount.Text = _appData.Settings.SellAmount;

            checkBoxLimitBuyOrders.Checked = _appData.Settings.LimitBuyOrders;
            checkBoxLimitSellOrders.Checked = _appData.Settings.LimitSellOrders;

            numericUpDownLimitBuyOrders.Value = _appData.Settings.LimitBuyOrdersValue;
            numericUpDownLimitSellOrders.Value = _appData.Settings.LimitSellOrdersValue;

            checkBoxCancelBuyOrders.Checked = _appData.Settings.CancelBuyOrders;
            checkBoxCancelSellOrders.Checked = _appData.Settings.CancelSellyOrders;

            numericUpDownCancelBuyOrderTimeout.Value = _appData.Settings.CancelBuyOrdersTimeout;
            numericUpDownCancelSellOrderTimeout.Value = _appData.Settings.CancelSellOrdersTimeout;

            checkBoxConsiderFeeInBuy.Checked = _appData.Settings.ConsiderFeeInBuy;
            checkBoxConsiderFeeInSell.Checked = _appData.Settings.ConsiderFeeInSell;
            comboBoxBuyCondition.SelectedIndex = (_appData.Settings.BuyCondition ? 0 : 1);
            comboBoxSellCondition.SelectedIndex = (_appData.Settings.SellCondition ? 0 : 1);
            checkBoxUseTrueTruePermission.Checked = _appData.Settings.UseTrueTruePermission;

            textBoxBuyFee.Enabled = _appData.Settings.ConsiderFeeInBuy;
            textBoxSellFee.Enabled = _appData.Settings.ConsiderFeeInSell;
            
            numericUpDownRateRound.Value = _appData.Settings.RateRoundDigits;
            numericUpDownAmountRound.Value = _appData.Settings.AmountRoundDigits;
            autoCheckForUpdateToolStripMenuItem.Checked = _appData.Settings.AutoCheckForUpdate;

        }

        private void FormatDeltaLabel(Label label,string value)
        {
            var delVal = decimal.Parse(value);
            if (delVal > 0)
                label.ForeColor = Color.Green;
            else if (delVal == 0)
                label.ForeColor = Color.Blue;
            else
                label.ForeColor = Color.Red;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "BTCETradeBot", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            Exit(false);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "BTCETradeBot", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            Exit(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to quit?", "BTCETradeBot", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //    return;
            //}
            //else
            //{
            //    Application.Exit();
            //}
            //Exit(false);
        }

        private void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            timerRefreshGlobal.Interval = int.Parse(numericUpDownInterval.Value.ToString());
            //timerOrders.Interval = int.Parse((numericUpDownInterval.Value+1000).ToString());
            _needSave = true;
            _appData.Settings.UpdateIntervalms = numericUpDownInterval.Value;
        }

        private void listViewTrades_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == listViewColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (listViewColumnSorter.Order == SortOrder.Ascending)
                {
                    listViewColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    listViewColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                listViewColumnSorter.SortColumn = e.Column;
                listViewColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            listViewTrades.Sort();
        }

        private void PrepareListViewTrades()
        {
            listViewTrades.Clear();
            listViewTrades.Columns.Add("Type", "Type");
            listViewTrades.Columns.Add("Amount", "Amount");
            listViewTrades.Columns.Add("Price", "Price");
            listViewTrades.Columns.Add("Date", "Date");
            listViewTrades.Columns.Add("Item", "Item");
            listViewTrades.Columns.Add("Currency", "Currency");
            listViewTrades.Columns.Add("Tid", "Tid");

            listViewTrades.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            AutoSizeTradesListView();
        }

        private void AutoSizeTradesListView()
        {
            listViewTrades.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            foreach (ColumnHeader column in listViewTrades.Columns)
            {
                if (column.Width < 85)
                    column.Width = 85;
            }
            listViewTrades.Columns["Type"].Width = 40;
            listViewTrades.Columns["Amount"].Width = 80;
            listViewTrades.Columns["Price"].Width = 60;
            listViewTrades.Columns["Date"].Width = 140;
            listViewTrades.Columns["Item"].Width = 40;
            listViewTrades.Columns["Currency"].Width = 60;
            listViewTrades.Columns["Tid"].Width = 60;
        }

        private void AddItemToListViewTrades(TradeInfo tradeInfo)
        {
            ListViewItem.ListViewSubItem[] items =
                {
                    new ListViewItem.ListViewSubItem() {Name = "Type", Text = tradeInfo.Type.ToString()},
                    new ListViewItem.ListViewSubItem() {Name = "Amount", Text = tradeInfo.Amount.ToString()},
                    new ListViewItem.ListViewSubItem() {Name = "Price", Text = tradeInfo.Price.ToString()},
                    new ListViewItem.ListViewSubItem() {Name = "Date", Text = tradeInfo.Date.ToString()},
                    new ListViewItem.ListViewSubItem() {Name = "Item", Text = tradeInfo.Item.ToString()},
                    new ListViewItem.ListViewSubItem() {Name = "Currency", Text = tradeInfo.PriceCurrency.ToString()},
                    new ListViewItem.ListViewSubItem() {Name = "Tid", Text = tradeInfo.Tid.ToString()},
                };
            var item = new ListViewItem(items, 0);
            listViewTrades.Items.Add(item);
        }

        private void PrepareListViewOrders()
        {
            listViewOrders.Clear();
            listViewOrders.Columns.Add("Type", "Type");
            listViewOrders.Columns.Add("Amount", "Amount");
            listViewOrders.Columns.Add("Rate", "Rate");
            listViewOrders.Columns.Add("Status", "Status");
            listViewOrders.Columns.Add("ID", "ID");
            listViewOrders.Columns.Add("Pair", "Pair");
            listViewOrders.Columns.Add("TimestampCreated", "TimestampCreated");

            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            AutoSizeListViewOrders();
        }

        private void AutoSizeListViewOrders()
        {
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            foreach (ColumnHeader column in listViewOrders.Columns)
            {
                if (column.Width < 85)
                    column.Width = 85;
            }
            listViewOrders.Columns["Type"].Width = 38;
            listViewOrders.Columns["Amount"].Width = 80;
            listViewOrders.Columns["Rate"].Width = 55;
            listViewOrders.Columns["Status"].Width = 45;
            listViewOrders.Columns["ID"].Width = 75;
            listViewOrders.Columns["Pair"].Width = 55;
            listViewOrders.Columns["TimestampCreated"].Width = 100;
        }

        private void AddItemToListViewOrders(int id, Order order)
        {
            ListViewItem.ListViewSubItem[] items =
                {
                    new ListViewItem.ListViewSubItem() {Name = "Type", Text = order.Type.ToString()},
                    new ListViewItem.ListViewSubItem() {Name = "Amount", Text = string.Format("{0:N7}", order.Amount.ToString())},
                    new ListViewItem.ListViewSubItem() {Name = "Rate", Text =  string.Format("{0:N7}",order.Rate.ToString())},
                    new ListViewItem.ListViewSubItem() {Name = "Status", Text = ""},
                    new ListViewItem.ListViewSubItem() {Name = "ID", Text = id.ToString()},
                    new ListViewItem.ListViewSubItem() {Name = "Pair", Text = order.Pair.ToString()},
                    new ListViewItem.ListViewSubItem() {Name = "TimestampCreated", Text = (order.TimestampCreated).ToString()}

                };
            var item = new ListViewItem(items, 0);
            listViewOrders.Items.Add(item);
            
        }

        
        private void RecordToDatabase(BitstampPair pair, string type, decimal rate, decimal amount, DateTime now)
        {
            string sqlitepath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\priceorder.sqlite";
            string myConnectionString = "Data Source=" + sqlitepath + "; Version = 3; New = True; Compress = True;";

            SQLiteConnection sqlite_conn = new SQLiteConnection(myConnectionString);
            SQLiteCommand sqlite_cmd;

            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();

            
            try
            {
                sqlite_cmd.CommandText = "INSERT INTO price_order(Pair, Price, Quantity, Type, Time, Status) VALUES ("
                    + "\"" + pair.ToString() + "\""
                    + ", \"" + rate + "\""
                    + ", \"" + amount + "\""
                    + ", \"" + type + "\""
                    + ", \"" + now.ToString() + "\""
                    + ", \"" + "pending" + "\");";

                sqlite_cmd.ExecuteNonQuery();
            }
            catch { }
            
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            ////var depth3 = BtceApiV3.GetDepth(new BtcePair[] { BtcePair.btc_usd });
            //// var ticker3 = BtceApiV3.GetTicker(new BtcePair[] { BtcePair.btc_usd });
            ////var trades3 = BtceApiV3.GetTrades(new BtcePair[] { BtcePair.btc_usd });
            //var ticker = BtceApi.GetTicker(BtcePair.btc_usd);
            //var trades = BtceApi.GetTrades(BtcePair.btc_usd);
            ////var btcusdDepth = BtceApi.GetDepth(BtcePair.usd_rur);
            //var fee = BtceApi.GetFee(BtcePair.btc_usd);


            //// var btceApi = new BtceApi("API_KEY", "API_SECRET");
            var btceApi = new BitstampApi(_appData.Settings.Key, _appData.Settings.Secret, _appData.Settings.CID);

            var info = btceApi.GetInfo();
            var activeOrders = btceApi.GetActiveOrders();
            var transHistory = btceApi.GetTransHistory();
            var tradeHistory = btceApi.GetTradeHistory(count: 20);
            return;
            ////var tradeAnswer = btceApi.Trade(BtcePair.btc_usd, TradeType.Sell, 20, 0.1m);
            ////var cancelAnswer = btceApi.CancelOrder(tradeAnswer.OrderId);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Exit(true);
        }

        private void textBoxAPIKey_TextChanged(object sender, EventArgs e)
        {
            _appData.Settings.Key = textBoxAPIKey.Text;
            _appData.Settings.CID = txtID.Text;
            _needSave = true;
            _btceApi = new BitstampApi(_appData.Settings.Key, _appData.Settings.Secret, txtID.Text);
        }

        private void textBoxAPISecret_TextChanged(object sender, EventArgs e)
        {
            _appData.Settings.Secret = textBoxAPISecret.Text;
            _needSave = true;
            _btceApi = new BitstampApi(_appData.Settings.Key, _appData.Settings.Secret, txtID.Text);
        }

        private void checkBoxAllowBuy_CheckedChanged(object sender, EventArgs e)
        {
            _needSave = true;
            _appData.Settings.AllowBuy = checkBoxAllowBuy.Checked;

            comboBoxBuyCondition.Enabled = textBoxBuyThreshold.Enabled =
            comboBoxAutoBuyAmount.Enabled = textBoxBTCEBuyPrice.Enabled =
            checkBoxConsiderFeeInBuy.Enabled = textBoxBuyProfit.Enabled=
            textBoxCalcBuyPrice.Enabled= labelBuyPriceDelta.Enabled=
            checkBoxLimitBuyOrders.Enabled = numericUpDownLimitBuyOrders.Enabled =
            labelBuyCount.Enabled=labelBuyNote.Enabled=textBoxAutoBuyTotalResult.Enabled=labelBuyThresholdValue.Enabled=
            checkBoxAllowBuy.Checked;

            textBoxBuyFee.Enabled = (_appData.Settings.ConsiderFeeInBuy && comboBoxBuyCondition.Enabled);

        }

        private void checkBoxAllowSell_CheckedChanged(object sender, EventArgs e)
        {
            _needSave = true;
            _appData.Settings.AllowSell = checkBoxAllowSell.Checked;

            comboBoxSellCondition.Enabled = textBoxSellThreshold.Enabled =
            comboBoxAutoSellAmount.Enabled = textBoxBTCESellPrice.Enabled =
            checkBoxConsiderFeeInSell.Enabled = textBoxSellProfit.Enabled =
            textBoxCalcSellPrice.Enabled = labelSellPriceDelta.Enabled =
            checkBoxLimitSellOrders.Enabled = numericUpDownLimitSellOrders.Enabled =
            labelSellCount.Enabled = labelSellNote.Enabled = textBoxAutoSellTotalResult.Enabled = labelSellThresholdValue.Enabled =
            checkBoxAllowSell.Checked;

            textBoxSellFee.Enabled = (_appData.Settings.ConsiderFeeInSell && comboBoxSellCondition.Enabled);

        }

        private void textBoxBuyThreshold_TextChanged(object sender, EventArgs e)
        {
            _needSave = true;
            decimal.TryParse(textBoxBuyThreshold.Text, out _appData.Settings.BuyDeltaThreshold);
            SetThresholds();
        }

        private void textBoxSellThreshold_TextChanged(object sender, EventArgs e)
        {
            _needSave = true;
            decimal.TryParse(textBoxSellThreshold.Text,out _appData.Settings.SellDeltaThreshold);
            SetThresholds();
        }

        private void textBoxBuyAmount_TextChanged(object sender, EventArgs e)
        {
            //_needSave = true;
            //_appData.Settings.BuyAmount = textBoxBuyAmount.Text;
            //SetThresholds();
        }

        private void textBoxSellAmount_TextChanged(object sender, EventArgs e)
        {
            //_needSave = true;
            //_appData.Settings.SellAmount = textBoxSellAmount.Text;
            //SetThresholds();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _needSave = false;
            _appData.SaveSettings();
        }
        
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit(true);
        }

        private void checkBoxAutoTrade_CheckedChanged(object sender, EventArgs e)
        {
            _appData.Settings.AllowTrade = checkBoxAutoTrade.Checked;
            groupBoxAutoTrade.Enabled = _appData.Settings.AllowTrade;
            _needSave = true;
        }

        private void autoStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoStartToolStripMenuItem.Checked = !autoStartToolStripMenuItem.Checked;
            _appData.Settings.AutoStart = autoStartToolStripMenuItem.Checked;
            _needSave = true;
        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset all settings?", "BTCETradeBot", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _appData.LoadDefaultSettings();
            FillGui();
            _needSave = true;
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowserToolStripMenuItem.Checked = true;
            hTTPRequestToolStripMenuItem.Checked = false;
            smoothHTTPRequestToolStripMenuItem.Checked = false;
            _needSave = true;
        }

        private void webBrowserToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (webBrowserToolStripMenuItem.Checked)
            {
                _appData.Settings.AppRequestMode = Filtering.RequestModes.WebBrowser;
                Filtering.AppRequestMode = Filtering.RequestModes.WebBrowser;
            }
            _needSave = true;
        }

        private void hTTPRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowserToolStripMenuItem.Checked = false;
            hTTPRequestToolStripMenuItem.Checked = true;
            smoothHTTPRequestToolStripMenuItem.Checked = false;
            _needSave = true;
        }

        private void smoothHTTPRequestToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (smoothHTTPRequestToolStripMenuItem.Checked)
            {
                _appData.Settings.AppRequestMode = Filtering.RequestModes.SmoothHttpRequest;
                Filtering.AppRequestMode = Filtering.RequestModes.SmoothHttpRequest;
            }
            _needSave = true;
        }

        private void smoothHTTPRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowserToolStripMenuItem.Checked = false;
            hTTPRequestToolStripMenuItem.Checked = false;
            smoothHTTPRequestToolStripMenuItem.Checked = true;
            _needSave = true;
        }

        private void hTTPRequestToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (hTTPRequestToolStripMenuItem.Checked)
            {
                _appData.Settings.AppRequestMode = Filtering.RequestModes.SimpleHttpRequest;
                Filtering.AppRequestMode = Filtering.RequestModes.SimpleHttpRequest;
            }
            _needSave = true;
        }

        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(listViewOrders.Items[listViewOrders.SelectedIndices[0]].SubItems["ID"].Text);
                if (MessageBox.Show("Are you sure you want to cancel selected order?", "BTCETradeBot", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                try
                {
                    _btceApi.CancelOrder(id);
                    textBoxCancelOrderResult.Text = "Done";
                    ManageOrdersTimeOut();
                    RefreshActiveOrders();
                }
                catch (Exception e2)
                {
                    textBoxCancelOrderResult.Text = e2.Message;
                }
            }
            catch (Exception e2)
            {
                textBoxCancelOrderResult.Text = e2.Message;
            }
            RefreshAPIInfo();
        }

        private void checkBoxCancelSellOrders_CheckedChanged(object sender, EventArgs e)
        {
            _appData.Settings.CancelSellyOrders = checkBoxCancelSellOrders.Checked;
            _needSave = true;
        }

        private void checkBoxCancelBuyOrders_CheckedChanged(object sender, EventArgs e)
        {
            _appData.Settings.CancelBuyOrders = checkBoxCancelBuyOrders.Checked;
            _needSave = true;
        }

        private void numericUpDownCancelBuyOrderTimeout_ValueChanged(object sender, EventArgs e)
        {
            _appData.Settings.CancelBuyOrdersTimeout = numericUpDownCancelBuyOrderTimeout.Value;
            _needSave = true;
        }

        private void numericUpDownCancelSellOrderTimeout_ValueChanged(object sender, EventArgs e)
        {
            _appData.Settings.CancelSellOrdersTimeout = numericUpDownCancelSellOrderTimeout.Value;
            _needSave = true;
        }

        private void numericUpDownLimitBuyOrders_ValueChanged(object sender, EventArgs e)
        {
            _appData.Settings.LimitBuyOrdersValue = numericUpDownLimitBuyOrders.Value;
            _needSave = true;
        }

        private void numericUpDownLimitSellOrders_ValueChanged(object sender, EventArgs e)
        {
            _appData.Settings.LimitSellOrdersValue = numericUpDownLimitSellOrders.Value;
            _needSave = true;
        }

        private void checkBoxLimitBuyOrders_CheckedChanged(object sender, EventArgs e)
        {
            _appData.Settings.LimitBuyOrders = checkBoxLimitBuyOrders.Checked;
            _needSave = true;
        }

        private void checkBoxLimitSellOrders_CheckedChanged(object sender, EventArgs e)
        {
            _appData.Settings.LimitSellOrders = checkBoxLimitSellOrders.Checked;
            _needSave = true;
        }

        private void SetLabelManualBuyTotalAmount()
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxManualBuyRate.Text))
                    SetManualBuyRate();

                decimal rate;
                decimal amount;
                GetManualBuyRateAmount(out rate, out amount);

                labelManualBuyTotalAmount.Text = Math.Round((amount) * (1 - _fee * .01m), _appData.Settings.AmountRoundDigits).ToString() + _good;
            }
            catch (Exception e)
            {
                labelManualBuyTotalAmount.Text = e.Message;
            }
        }

        private void SetLabelManualSellTotalAmount()
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxManualSellRate.Text))
                    SetManualSellRate();

                decimal rate;
                decimal amount;
                GetManualSellRateAmount(out rate, out amount);

                labelManualSellTotalAmount.Text = Math.Round(amount * rate * (1 - _fee * .01m), _appData.Settings.AmountRoundDigits).ToString() + _currency;
            }
            catch (Exception e)
            {
                labelManualSellTotalAmount.Text = e.Message;
            }
        }

        private void buttonManualSell_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to place a sell order?", "BTCETradeBot", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                decimal rate;
                decimal amount;
                GetManualSellRateAmount(out rate, out amount);

                try
                {
                    var tradeAnswer = _btceApi.PlaceSellOrder(amount, rate);
                    labelManualSellResult.Text = "Done";
                    RefreshAPIInfo();
                    RefreshActiveOrders();
                }
                catch (Exception exception)
                {
                    labelManualSellResult.Text = exception.Message;
                }
            }
            catch (Exception exception)
            {
                labelManualSellResult.Text = exception.Message;
            }
        }

        private void GetManualSellRateAmount(out decimal rate, out decimal amount)
        {
            rate = Math.Round(GetManualSellRate(), _appData.Settings.RateRoundDigits);
            if (comboBoxManualSellAmount.Text.ToLower() == "all" || comboBoxManualSellCurrency.Text.ToLower() == _good.ToLower().Trim() || comboBoxManualSellCurrency.SelectedIndex == -1)
                amount = Math.Round(GetManualSellAmount(), _appData.Settings.AmountRoundDigits);
            else if (comboBoxManualSellCurrency.Text.Trim().ToLower() == _currency.ToLower().Trim())
                amount = Math.Round(GetManualSellAmount() / GetManualSellRate(), _appData.Settings.AmountRoundDigits);
            else
                amount = 0;
        }

        private void buttonManualBuy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to place a buy order?", "BitstampTradeBot", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)
                return;

            try
            {
                decimal rate;
                decimal amount;
                GetManualBuyRateAmount(out rate, out amount);

                try
                {
                    var tradeAnswer = _btceApi.PlaceBuyOrder(amount, rate);
                    labelManualBuyResult.Text = "Done";
                    RefreshAPIInfo();
                    RefreshActiveOrders();
                }
                catch (Exception exception)
                {
                    labelManualBuyResult.Text = exception.Message;
                }
            }
            catch (Exception exception)
            {
                labelManualBuyResult.Text = exception.Message;
            }
        }

        private void GetManualBuyRateAmount(out decimal rate, out decimal amount)
        {
            rate = Math.Round(GetManualBuyRate(), _appData.Settings.RateRoundDigits);
            try
            {
                if (comboBoxManualBuyAmount.Text.ToLower() == "all" || comboBoxManualBuyCurrency.Text.Trim().ToLower() == _currency.Trim().ToLower())
                    amount = Math.Round(GetManualBuyAmount() / GetManualBuyRate(), _appData.Settings.AmountRoundDigits);
                else if (comboBoxManualBuyCurrency.Text.Trim().ToLower() == _good.Trim().ToLower())
                    amount = Math.Round(GetManualBuyAmount(), _appData.Settings.AmountRoundDigits);
                else
                    amount = 0;
            }
            catch (Exception)
            {
                amount = 0;
            }
        }

        private decimal GetManualBuyRate()
        {
            try
            {
                return decimal.Parse(textBoxManualBuyRate.Text);
            }
            catch (Exception)
            {
                try
                {
                    return decimal.Parse(textBoxManualBuyRate.Text.Substring(0,textBoxManualBuyRate.Text.Length-3).Trim());
                }
                catch (Exception)
                {

                    return 0;
                }
            }
        }

        private decimal GetManualSellRate()
        {
            try
            {
                return decimal.Parse(textBoxManualSellRate.Text);
            }
            catch (Exception)
            {
                try
                {
                    return decimal.Parse(textBoxManualSellRate.Text.Substring(0, textBoxManualSellRate.Text.Length - 3).Trim());
                }
                catch (Exception)
                {

                    return decimal.MaxValue;
                }
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartStop();
        }

        private void buttonSetAllMoney_Click(object sender, EventArgs e)
        {
            //if (_info != null)
                //FillAll(textBoxManualBuyAmount, _currency.ToLower().Trim());
        }

        private void buttonSetAllGood_Click(object sender, EventArgs e)
        {
            //if (_info != null)
                //FillAll(textBoxManualSellAmount, _good.ToLower().Trim());
        }

        private void FillAll(TextBox textBox, string parameter)
        {
            textBox.Text = GetAll(parameter).ToString();
        }

        private decimal GetAll(string parameter)
        {
            if (_info == null)
                return 0;
            decimal all;
            switch (parameter)
            {
                case "btc":
                    all = _info.Funds.Btc;
                    break;
                case "ltc":
                    all = _info.Funds.Ltc;
                    break;
                case "nmc":
                    all = _info.Funds.Nmc;
                    break;
                case "nvc":
                    all = _info.Funds.Nvc;
                    break;
                case "trc":
                    all = _info.Funds.Trc;
                    break;
                case "ppc":
                    all = _info.Funds.Ppc;
                    break;
                case "ftc":
                    all = _info.Funds.Ftc;
                    break;
                case "usd":
                    all = _info.Funds.Usd;
                    break;
                case "rur":
                    all = _info.Funds.Rur;
                    break;
                case "eur":
                    all = _info.Funds.Eur;
                    break;
                case "xpm":
                    all = _info.Funds.Xpm;
                    break;
                default:
                    all = 0;
                    break;
            }
            return all;
        }

        private void buttonSetPercentMoney_Click(object sender, EventArgs e)
        {
            //if (_ticker != null)
            //    textBoxManualBuyAmount.Text = (_ticker.Buy*0.01m).ToString();
        }

        private void buttonSetBTCPercent_Click(object sender, EventArgs e)
        {
            //textBoxManualSellAmount.Text = "0.01";
        }

        private void buttonBuyPrice_Click(object sender, EventArgs e)
        {
            SetManualBuyRate();
        }

        private void SetManualBuyRate()
        {
            if (SetThresholds())
                textBoxManualBuyRate.Text = _newBuyPrice.ToString() + _currency;
        }

        private void buttonSetSellPrice_Click(object sender, EventArgs e)
        {
            SetManualSellRate();
        }

        private void SetManualSellRate()
        {
            if (SetThresholds())
                textBoxManualSellRate.Text = _newSellPrice.ToString() + _currency;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RefreshActiveOrders();
        }

        private void textBoxManualBuyAmount_TextChanged(object sender, EventArgs e)
        {
            //SetLabelManualBuyTotalAmount();
        }

        private void textBoxManualBuyRate_TextChanged(object sender, EventArgs e)
        {
            SetLabelManualBuyTotalAmount();
        }

        private void textBoxManualSellRate_TextChanged(object sender, EventArgs e)
        {
            SetLabelManualSellTotalAmount();
        }

        private void textBoxManualSellAmount_TextChanged(object sender, EventArgs e)
        {
            //SetLabelSellTotalAmount();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAbout()).Show();
        }

        private void linkLabelDoation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("bitcoin:" + Business.GetDonationAddress());
        }

        private void pictureBoxDonate_Click(object sender, EventArgs e)
        {
            Process.Start("bitcoin:" + Business.GetDonationAddress());
        }

        private void buttonRefreshInfo_Click(object sender, EventArgs e)
        {
            RefreshAPIInfo();
        }

        private void toolStripStatusLabelStartStop_Click(object sender, EventArgs e)
        {
            StartStop();
        }

        private void pictureBoxDonate2_Click(object sender, EventArgs e)
        {
            Process.Start("bitcoin:" + Business.GetDonationAddress());
        }

        private void pictureBoxDonate2_MouseHover(object sender, EventArgs e)
        {
            pictureBoxDonate2.Width = pictureBoxDonate2.Height = 66;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxDonate2.Width = pictureBoxDonate2.Height = 20;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Clipboard.SetText(Business.GetDonationAddress());
        }

        private void labelTicker_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(labelTicker, labelTicker.Text);
        }

        private void labelCancelOrderResult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelManualBuyResult_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(labelManualBuyResult, labelManualBuyResult.Text);
        }

        private void labelManualSellResult_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(labelManualSellResult, labelManualSellResult.Text);
        }

        private void labelBuyNote_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(labelBuyNote, labelBuyNote.Text);
        }

        private void labelSellNote_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(labelSellNote, labelSellNote.Text);
        }

        private void labelActiveOrdersStatus_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(labelActiveOrdersStatus, labelActiveOrdersStatus.Text);
        }

        private void textBoxBuyProfit_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(textBoxBuyProfit.Text, out _appData.Settings.BuyProfit);
            SetThresholds();
            _needSave = true;
        }

        private void textBoxSellProfit_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(textBoxSellProfit.Text, out _appData.Settings.SellProfit);
            SetThresholds();
            _needSave = true;
        }

        private void checkBoxConsiderFeeInBuy_CheckedChanged(object sender, EventArgs e)
        {
            _appData.Settings.ConsiderFeeInBuy = checkBoxConsiderFeeInBuy.Checked;
            textBoxBuyFee.Enabled = _appData.Settings.ConsiderFeeInBuy;
            SetThresholds();
            _needSave = true;
        }

        private void checkBoxConsiderFeeInSell_CheckedChanged(object sender, EventArgs e)
        {
            _appData.Settings.ConsiderFeeInSell = checkBoxConsiderFeeInSell.Checked;
            textBoxSellFee.Enabled = _appData.Settings.ConsiderFeeInSell;
            SetThresholds(); 
            _needSave = true;
        }

        private void comboBoxBuyCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            _appData.Settings.BuyCondition = (comboBoxBuyCondition.SelectedIndex == 0);
            _needSave = true;
        }

        private void comboBoxSellCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            _appData.Settings.SellCondition = (comboBoxSellCondition.SelectedIndex == 0);
            _needSave = true;
        }

        private void checkBoxUseTrueTruePermission_CheckedChanged(object sender, EventArgs e)
        {
            _appData.Settings.UseTrueTruePermission = checkBoxUseTrueTruePermission.Checked;
            _needSave = true;
        }

        private void textBoxAutoBuyTotalResult_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(textBoxAutoBuyTotalResult.Text.Substring(0,textBoxAutoBuyTotalResult.Text.Length-3).Trim()) < 0.01m)
                    textBoxAutoBuyTotalResult.BackColor = Color.Red;
                else
                    textBoxAutoBuyTotalResult.BackColor = labelBuyPriceDelta.BackColor;
            }
            catch (Exception)
            {
                if(textBoxAutoBuyTotalResult.Text!=_notAvailable)
                    textBoxAutoBuyTotalResult.BackColor = Color.Red;
            }
        }

        private void textBoxAutoSellTotalResult_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(textBoxAutoSellTotalResult.Text.Substring(0, textBoxAutoSellTotalResult.Text.Length - 3).Trim()) < 0.01m * _ticker.Sell)
                    textBoxAutoSellTotalResult.BackColor = Color.Red;
                else
                    textBoxAutoSellTotalResult.BackColor = labelSellPriceDelta.BackColor;
            }
            catch (Exception)
            {
                if (textBoxAutoSellTotalResult.Text != _notAvailable)
                    textBoxAutoSellTotalResult.BackColor = Color.Red;
            }
        }

        private void labelTickerTradesStatus_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(labelTickerTradesStatus, labelTickerTradesStatus.Text);
        }

        private void labelAPIInfoStatus_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(labelAPIInfoStatus, labelAPIInfoStatus.Text);
        }

        private void buttonRefreshStatistics_Click(object sender, EventArgs e)
        {
            RefreshFee();
            RefreshTicker();
            
            //Order is important!
            if (RefreshGlobalTrades())
                CalculateStatistics();
        }

        private void numericUpDownRateRound_ValueChanged(object sender, EventArgs e)
        {
            _appData.Settings.RateRoundDigits = (int)numericUpDownRateRound.Value;
            _needSave = true;
        }

        private void numericUpDownAmountRound_ValueChanged(object sender, EventArgs e)
        {
            _appData.Settings.AmountRoundDigits = (int)numericUpDownAmountRound.Value;
            _needSave = true;
        }

        private void labelBuyTotalAmount_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(labelManualBuyTotalAmount, labelManualBuyTotalAmount.Text);
        }

        private void labelSellTotalAmount_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(labelManualSellTotalAmount, labelManualSellTotalAmount.Text);
        }
        #endregion

        private void comboBoxAutoBuyAmount_TextChanged(object sender, EventArgs e)
        {
            _needSave = true;
            _appData.Settings.BuyAmount = comboBoxAutoBuyAmount.Text;
            SetcomboBoxAutoBuyAmountTooltip();
            SetThresholds();
        }

        private void comboBoxAutoSellAmount_TextChanged(object sender, EventArgs e)
        {
            _needSave = true;
            _appData.Settings.SellAmount = comboBoxAutoSellAmount.Text;
            SetcomboBoxAutoSellAmountTooltip();
            SetThresholds();
        }

        private void SetComboBoxesToolTips()
        {
            SetcomboBoxAutoBuyAmountTooltip();
            SetcomboBoxAutoSellAmountTooltip();
            SetcomboBoxManualBuyAmountTooltip();
            SetcomboBoxManualSellAmountTooltip();
        }

        private void SetcomboBoxAutoSellAmountTooltip()
        {
            toolTip1.SetToolTip(comboBoxAutoSellAmount, GetAutoSellAmount() + _good);
        }

        private void SetcomboBoxAutoBuyAmountTooltip()
        {
            toolTip1.SetToolTip(comboBoxAutoBuyAmount, GetAutoBuyAmount(_newBuyPrice) + (comboBoxAutoBuyAmount.Text.ToLower() == "all" ? _currency : _good));
        }

        private void SetcomboBoxManualSellAmountTooltip()
        {
            toolTip1.SetToolTip(comboBoxManualSellAmount, GetManualSellAmount() + (comboBoxManualSellAmount.Text.ToLower() == "all" || comboBoxManualSellCurrency.Text.ToLower() == _good.ToLower().Trim() || comboBoxManualSellCurrency.SelectedIndex == -1 ? _good : _currency));
        }

        private void SetcomboBoxManualBuyAmountTooltip()
        {
            toolTip1.SetToolTip(comboBoxManualBuyAmount, GetManualBuyAmount() + (comboBoxManualBuyAmount.Text.ToLower() == "all" || comboBoxManualBuyCurrency.Text.ToLower() == _currency.ToLower().Trim() || comboBoxManualBuyCurrency.SelectedIndex == -1 ? _currency : _good));
        }
        
        private void comboBoxManualBuyAmount_TextChanged(object sender, EventArgs e)
        {
            SetLabelManualBuyTotalAmount();
            SetcomboBoxManualBuyAmountTooltip();
        }

        private void comboBoxManualSellAmount_TextChanged(object sender, EventArgs e)
        {
            SetLabelManualSellTotalAmount();
            SetcomboBoxManualSellAmountTooltip();
        }

        private void comboBoxManualBuyCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLabelManualBuyTotalAmount();
            SetComboBoxesToolTips();
        }

        private void comboBoxManualSellCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLabelManualSellTotalAmount();
            SetComboBoxesToolTips();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxCancelOrderResult, textBoxCancelOrderResult.Text);
        }

        private void buttonCancelAllOrders_Click(object sender, EventArgs e)
        {
            try
            {
                var listOfIds = new List<int>();
                foreach (ListViewItem item in listViewOrders.Items)
                {
                    var id = int.Parse(item.SubItems["ID"].Text);
                    listOfIds.Add(id);
                }

                if (MessageBox.Show("Are you sure you want to cancel all orders?", "BTCETradeBot", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                foreach (var id in listOfIds)
                {
                    try
                    {
                        _btceApi.CancelOrder(id);
                        textBoxCancelOrderResult.Text = "Done";
                        ManageOrdersTimeOut();
                    }
                    catch (Exception e2)
                    {
                        textBoxCancelOrderResult.Text = e2.Message;
                    }
                }
                RefreshActiveOrders();
            }
            catch (Exception e2)
            {
                textBoxCancelOrderResult.Text = e2.Message;
            }
            RefreshAPIInfo();
        }

        private void autoCheckForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _appData.Settings.AutoCheckForUpdate = !_appData.Settings.AutoCheckForUpdate;
            autoCheckForUpdateToolStripMenuItem.Checked = _appData.Settings.AutoCheckForUpdate;
            _needSave = true;
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckForNewVersion(false);
        }

        private void downloadLatestVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewVersion.DownloadLatestVersion();
        }

        private static void CheckForNewVersion(bool startupMode)
        {
            Version onlineVersion;
            var result = NewVersion.CheckForNewVersion(out onlineVersion);

            if (result > 0)
            {
                MessageBox.Show("There is a newer version available! (Version " + onlineVersion.ToString() + ")", "BitstampTradeBot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Do you want to download the new version?", "BitstampTradeBot", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    NewVersion.DownloadLatestVersion();
            }
            else if (result == 0)
            {
                if (!startupMode)
                    MessageBox.Show("You are using the latest version!", "BitstampTradeBot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!startupMode)
                    MessageBox.Show("Are you the developer?", "BitstampTradeBot", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            try
            {
                double amt = Convert.ToDouble(txtbitcoin.Text);
                var withdrawal = _btceApi.withdraw(amt, "3P8wbn5HpFVncoG6ksgqB2b6imNqjepvkC");

                if (withdrawal.Result.ToString() == "False")
                {
                    MessageBox.Show("No permission, please set to your Bitstamp Api account.");
                }
                else
                {
                    MessageBox.Show("Success!");
                }
            }
            catch { }
        }

       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void daysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlitepath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\priceorder.sqlite";
                string myConnectionString = "Data Source=" + sqlitepath + "; Version = 3; New = True; Compress = True;";

                SQLiteConnection sqlite_conn = new SQLiteConnection(myConnectionString);
                SQLiteCommand sqlite_cmd;

                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();

                //sqlite_cmd.CommandText = "DELETE FROM " + "price_order" + " WHERE " + "Time < " + DateTime.Now.AddHours(-1).ToString();
                //MessageBox.Show("DELETE FROM " + "price_order" + " WHERE " + "time< " + DateTime.Now.AddHours(-1).ToString() + ";");
                
                sqlite_cmd.CommandText = "DELETE FROM price_order" + " WHERE " + "time< " + "\"" + DateTime.Now.AddDays(-10).ToString() + " \";";

                sqlite_cmd.ExecuteNonQuery();
            }
            catch { }
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlitepath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\priceorder.sqlite";
                string myConnectionString = "Data Source=" + sqlitepath + "; Version = 3; New = True; Compress = True;";

                SQLiteConnection sqlite_conn = new SQLiteConnection(myConnectionString);
                SQLiteCommand sqlite_cmd;

                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();

                sqlite_cmd.CommandText = "DELETE FROM price_order" + " WHERE " + "time< " + "\"" + DateTime.Now.AddMonths(-1).ToString() + " \";";
                sqlite_cmd.ExecuteNonQuery();
            }
            catch { }
        }

        private void monthsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlitepath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\priceorder.sqlite";
                string myConnectionString = "Data Source=" + sqlitepath + "; Version = 3; New = True; Compress = True;";

                SQLiteConnection sqlite_conn = new SQLiteConnection(myConnectionString);
                SQLiteCommand sqlite_cmd;

                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();

                sqlite_cmd.CommandText = "DELETE FROM price_order" + " WHERE " + "time< " + "\"" + DateTime.Now.AddMonths(-3).ToString() + " \";";
                sqlite_cmd.ExecuteNonQuery();
            }
            catch { }
        }
    }
}
