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

namespace BTCETradeBot
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timerRefreshGlobal = new System.Windows.Forms.Timer(this.components);
            this.checkBoxAllowBuy = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowSell = new System.Windows.Forms.CheckBox();
            this.labelBuyCount = new System.Windows.Forms.Label();
            this.labelSellCount = new System.Windows.Forms.Label();
            this.textBoxBuyThreshold = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSellPriceDelta = new System.Windows.Forms.Label();
            this.labelBuyPriceDelta = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSellThreshold = new System.Windows.Forms.TextBox();
            this.labelBuyNote = new System.Windows.Forms.Label();
            this.labelSellNote = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRefreshInfo = new System.Windows.Forms.Button();
            this.buttonRefreshActiveOrders = new System.Windows.Forms.Button();
            this.pictureBoxDonate = new System.Windows.Forms.PictureBox();
            this.linkLabelDoation = new System.Windows.Forms.LinkLabel();
            this.pictureBoxDonate2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxUseTrueTruePermission = new System.Windows.Forms.CheckBox();
            this.checkBoxConsiderFeeInSell = new System.Windows.Forms.CheckBox();
            this.checkBoxConsiderFeeInBuy = new System.Windows.Forms.CheckBox();
            this.buttonRefreshStatistics = new System.Windows.Forms.Button();
            this.numericUpDownRateRound = new System.Windows.Forms.NumericUpDown();
            this.label53 = new System.Windows.Forms.Label();
            this.numericUpDownAmountRound = new System.Windows.Forms.NumericUpDown();
            this.label56 = new System.Windows.Forms.Label();
            this.textBoxBuyProfit = new System.Windows.Forms.TextBox();
            this.textBoxSellProfit = new System.Windows.Forms.TextBox();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStartStop = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFee = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLastBought = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLastSold = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLastCheck = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxAPISecret = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxAPIKey = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTTPRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothHTTPRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activePairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCheckForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadLatestVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAutoTrade = new System.Windows.Forms.GroupBox();
            this.textBoxBTCEBuyPrice = new System.Windows.Forms.TextBox();
            this.textBoxBTCESellPrice = new System.Windows.Forms.TextBox();
            this.comboBoxAutoSellAmount = new System.Windows.Forms.ComboBox();
            this.comboBoxAutoBuyAmount = new System.Windows.Forms.ComboBox();
            this.labelThresholdCurrency = new System.Windows.Forms.Label();
            this.labelBuyThresholdValue = new System.Windows.Forms.Label();
            this.labelSellThresholdValue = new System.Windows.Forms.Label();
            this.textBoxAutoBuyTotalResult = new System.Windows.Forms.TextBox();
            this.textBoxAutoSellTotalResult = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.comboBoxSellCondition = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.comboBoxBuyCondition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCalcBuyPrice = new System.Windows.Forms.TextBox();
            this.textBoxCalcSellPrice = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownLimitSellOrders = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLimitBuyOrders = new System.Windows.Forms.NumericUpDown();
            this.checkBoxLimitSellOrders = new System.Windows.Forms.CheckBox();
            this.checkBoxLimitBuyOrders = new System.Windows.Forms.CheckBox();
            this.textBoxBuyFee = new System.Windows.Forms.TextBox();
            this.textBoxSellFee = new System.Windows.Forms.TextBox();
            this.groupBoxApiInfo = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFundXPM = new System.Windows.Forms.TextBox();
            this.labelAPIInfoStatus = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.textBoxInfoServerTime = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBoxInfoTransactionCount = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxInfoOpenOrders = new System.Windows.Forms.TextBox();
            this.checkBoxRightTrade = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxFundEUR = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.checkBoxRightInfo = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxFundRUR = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxFundFTC = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxFundPPC = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxFundTRC = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxFundNVC = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxFundNMC = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxFundLTC = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxFundUSD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFundBTC = new System.Windows.Forms.TextBox();
            this.labelTotalAskAmount = new System.Windows.Forms.Label();
            this.labelTotalAskOrders = new System.Windows.Forms.Label();
            this.labelTotalAskValue = new System.Windows.Forms.Label();
            this.labelAskAVG = new System.Windows.Forms.Label();
            this.labelTotalBidAmount = new System.Windows.Forms.Label();
            this.labelTotalBidOrders = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.labelTotalBidValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBidAVG = new System.Windows.Forms.Label();
            this.labelOldMid2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDelta = new System.Windows.Forms.Label();
            this.labelOldMid = new System.Windows.Forms.Label();
            this.listViewTrades = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNewMid = new System.Windows.Forms.Label();
            this.labelTicker = new System.Windows.Forms.Label();
            this.labelDelta2 = new System.Windows.Forms.Label();
            this.labelOldMid3 = new System.Windows.Forms.Label();
            this.labelDelta3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTickerTradesStatus = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.labelBidAskAverage = new System.Windows.Forms.Label();
            this.labelTradePermission = new System.Windows.Forms.Label();
            this.labelEstimationResult2 = new System.Windows.Forms.Label();
            this.labelEstimationResult = new System.Windows.Forms.Label();
            this.buttonFocus = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxActivePair = new System.Windows.Forms.ComboBox();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.numericUpDownCancelBuyOrderTimeout = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCancelBuyOrders = new System.Windows.Forms.CheckBox();
            this.checkBoxCancelSellOrders = new System.Windows.Forms.CheckBox();
            this.numericUpDownCancelSellOrderTimeout = new System.Windows.Forms.NumericUpDown();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.checkBoxAutoTrade = new System.Windows.Forms.CheckBox();
            this.groupBoxManualTrade = new System.Windows.Forms.GroupBox();
            this.comboBoxManualSellCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxManualBuyCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxManualSellAmount = new System.Windows.Forms.ComboBox();
            this.comboBoxManualBuyAmount = new System.Windows.Forms.ComboBox();
            this.buttonSetSellPrice = new System.Windows.Forms.Button();
            this.buttonBuyPrice = new System.Windows.Forms.Button();
            this.labelManualSellTotalAmount = new System.Windows.Forms.Label();
            this.labelManualBuyTotalAmount = new System.Windows.Forms.Label();
            this.labelManualSellResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelManualBuyResult = new System.Windows.Forms.Label();
            this.buttonManualSell = new System.Windows.Forms.Button();
            this.buttonManualBuy = new System.Windows.Forms.Button();
            this.textBoxManualSellRate = new System.Windows.Forms.TextBox();
            this.textBoxManualBuyRate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.labelManualSellTitle = new System.Windows.Forms.Label();
            this.labelManualBuyTitle = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.labelActiveOrdersStatus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelCancelledBuysCount = new System.Windows.Forms.Label();
            this.labelCancelledSellsCount = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.textBoxCancellBuyResult = new System.Windows.Forms.TextBox();
            this.textBoxCancelSellResult = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCancelOrderResult = new System.Windows.Forms.TextBox();
            this.buttonCancelAllOrders = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.txtbitcoin = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRateRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxAutoTrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimitSellOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimitBuyOrders)).BeginInit();
            this.groupBoxApiInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCancelBuyOrderTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCancelSellOrderTimeout)).BeginInit();
            this.groupBoxManualTrade.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerRefreshGlobal
            // 
            this.timerRefreshGlobal.Interval = 10000;
            this.timerRefreshGlobal.Tick += new System.EventHandler(this.timerRefreshGlobal_Tick);
            // 
            // checkBoxAllowBuy
            // 
            this.checkBoxAllowBuy.AutoSize = true;
            this.checkBoxAllowBuy.Location = new System.Drawing.Point(7, 57);
            this.checkBoxAllowBuy.Name = "checkBoxAllowBuy";
            this.checkBoxAllowBuy.Size = new System.Drawing.Size(72, 17);
            this.checkBoxAllowBuy.TabIndex = 5;
            this.checkBoxAllowBuy.Text = "Allow Buy";
            this.checkBoxAllowBuy.UseVisualStyleBackColor = true;
            this.checkBoxAllowBuy.CheckedChanged += new System.EventHandler(this.checkBoxAllowBuy_CheckedChanged);
            // 
            // checkBoxAllowSell
            // 
            this.checkBoxAllowSell.AutoSize = true;
            this.checkBoxAllowSell.Location = new System.Drawing.Point(7, 76);
            this.checkBoxAllowSell.Name = "checkBoxAllowSell";
            this.checkBoxAllowSell.Size = new System.Drawing.Size(71, 17);
            this.checkBoxAllowSell.TabIndex = 13;
            this.checkBoxAllowSell.Text = "Allow Sell";
            this.checkBoxAllowSell.UseVisualStyleBackColor = true;
            this.checkBoxAllowSell.CheckedChanged += new System.EventHandler(this.checkBoxAllowSell_CheckedChanged);
            // 
            // labelBuyCount
            // 
            this.labelBuyCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBuyCount.Enabled = false;
            this.labelBuyCount.Location = new System.Drawing.Point(812, 55);
            this.labelBuyCount.Name = "labelBuyCount";
            this.labelBuyCount.Size = new System.Drawing.Size(32, 20);
            this.labelBuyCount.TabIndex = 21;
            this.labelBuyCount.Text = "N/A";
            // 
            // labelSellCount
            // 
            this.labelSellCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSellCount.Enabled = false;
            this.labelSellCount.Location = new System.Drawing.Point(812, 74);
            this.labelSellCount.Name = "labelSellCount";
            this.labelSellCount.Size = new System.Drawing.Size(32, 20);
            this.labelSellCount.TabIndex = 22;
            this.labelSellCount.Text = "N/A";
            // 
            // textBoxBuyThreshold
            // 
            this.textBoxBuyThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuyThreshold.Enabled = false;
            this.textBoxBuyThreshold.Location = new System.Drawing.Point(117, 55);
            this.textBoxBuyThreshold.Name = "textBoxBuyThreshold";
            this.textBoxBuyThreshold.Size = new System.Drawing.Size(35, 20);
            this.textBoxBuyThreshold.TabIndex = 7;
            this.textBoxBuyThreshold.Text = "0.1";
            this.textBoxBuyThreshold.TextChanged += new System.EventHandler(this.textBoxBuyThreshold_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Amount";
            // 
            // labelSellPriceDelta
            // 
            this.labelSellPriceDelta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSellPriceDelta.Enabled = false;
            this.labelSellPriceDelta.Location = new System.Drawing.Point(621, 74);
            this.labelSellPriceDelta.Name = "labelSellPriceDelta";
            this.labelSellPriceDelta.Size = new System.Drawing.Size(95, 20);
            this.labelSellPriceDelta.TabIndex = 28;
            this.labelSellPriceDelta.Text = "N/A";
            // 
            // labelBuyPriceDelta
            // 
            this.labelBuyPriceDelta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBuyPriceDelta.Enabled = false;
            this.labelBuyPriceDelta.Location = new System.Drawing.Point(621, 55);
            this.labelBuyPriceDelta.Name = "labelBuyPriceDelta";
            this.labelBuyPriceDelta.Size = new System.Drawing.Size(95, 20);
            this.labelBuyPriceDelta.TabIndex = 27;
            this.labelBuyPriceDelta.Text = "N/A";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(1000, 572);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 25);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(811, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Count";
            // 
            // textBoxSellThreshold
            // 
            this.textBoxSellThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSellThreshold.Enabled = false;
            this.textBoxSellThreshold.Location = new System.Drawing.Point(117, 74);
            this.textBoxSellThreshold.Name = "textBoxSellThreshold";
            this.textBoxSellThreshold.Size = new System.Drawing.Size(35, 20);
            this.textBoxSellThreshold.TabIndex = 15;
            this.textBoxSellThreshold.Text = "-0.1";
            this.textBoxSellThreshold.TextChanged += new System.EventHandler(this.textBoxSellThreshold_TextChanged);
            // 
            // labelBuyNote
            // 
            this.labelBuyNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBuyNote.Enabled = false;
            this.labelBuyNote.Location = new System.Drawing.Point(843, 55);
            this.labelBuyNote.Name = "labelBuyNote";
            this.labelBuyNote.Size = new System.Drawing.Size(79, 20);
            this.labelBuyNote.TabIndex = 41;
            this.labelBuyNote.Text = "Not triggered";
            this.toolTip1.SetToolTip(this.labelBuyNote, "Not triggered");
            this.labelBuyNote.TextChanged += new System.EventHandler(this.labelBuyNote_TextChanged);
            // 
            // labelSellNote
            // 
            this.labelSellNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSellNote.Enabled = false;
            this.labelSellNote.Location = new System.Drawing.Point(843, 74);
            this.labelSellNote.Name = "labelSellNote";
            this.labelSellNote.Size = new System.Drawing.Size(79, 20);
            this.labelSellNote.TabIndex = 42;
            this.labelSellNote.Text = "Not triggered";
            this.toolTip1.SetToolTip(this.labelSellNote, "Not triggered");
            this.labelSellNote.TextChanged += new System.EventHandler(this.labelSellNote_TextChanged);
            // 
            // buttonRefreshInfo
            // 
            this.buttonRefreshInfo.BackgroundImage = global::BTCETradeBot.Properties.Resources.Refresh128;
            this.buttonRefreshInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefreshInfo.Location = new System.Drawing.Point(47, 0);
            this.buttonRefreshInfo.Name = "buttonRefreshInfo";
            this.buttonRefreshInfo.Size = new System.Drawing.Size(18, 18);
            this.buttonRefreshInfo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonRefreshInfo, "Refresh API Info");
            this.buttonRefreshInfo.UseVisualStyleBackColor = true;
            this.buttonRefreshInfo.Click += new System.EventHandler(this.buttonRefreshInfo_Click);
            // 
            // buttonRefreshActiveOrders
            // 
            this.buttonRefreshActiveOrders.BackgroundImage = global::BTCETradeBot.Properties.Resources.Refresh128;
            this.buttonRefreshActiveOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefreshActiveOrders.Location = new System.Drawing.Point(555, 394);
            this.buttonRefreshActiveOrders.Name = "buttonRefreshActiveOrders";
            this.buttonRefreshActiveOrders.Size = new System.Drawing.Size(21, 21);
            this.buttonRefreshActiveOrders.TabIndex = 77;
            this.toolTip1.SetToolTip(this.buttonRefreshActiveOrders, "Refresh Active Orders");
            this.buttonRefreshActiveOrders.UseVisualStyleBackColor = true;
            this.buttonRefreshActiveOrders.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBoxDonate
            // 
            this.pictureBoxDonate.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDonate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDonate.Image")));
            this.pictureBoxDonate.Location = new System.Drawing.Point(45, 222);
            this.pictureBoxDonate.Name = "pictureBoxDonate";
            this.pictureBoxDonate.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDonate.TabIndex = 79;
            this.pictureBoxDonate.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxDonate, "Donate some bitcoins to help the developer!");
            this.pictureBoxDonate.Click += new System.EventHandler(this.pictureBoxDonate_Click);
            // 
            // linkLabelDoation
            // 
            this.linkLabelDoation.AutoSize = true;
            this.linkLabelDoation.Location = new System.Drawing.Point(67, 226);
            this.linkLabelDoation.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.linkLabelDoation.MaximumSize = new System.Drawing.Size(0, 17);
            this.linkLabelDoation.Name = "linkLabelDoation";
            this.linkLabelDoation.Size = new System.Drawing.Size(42, 13);
            this.linkLabelDoation.TabIndex = 78;
            this.linkLabelDoation.TabStop = true;
            this.linkLabelDoation.Text = "Donate";
            this.linkLabelDoation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.linkLabelDoation, "Donate some bitcoins to help the developer!");
            this.linkLabelDoation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDoation_LinkClicked);
            // 
            // pictureBoxDonate2
            // 
            this.pictureBoxDonate2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDonate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDonate2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDonate2.Image = global::BTCETradeBot.Properties.Resources.DonateAddress;
            this.pictureBoxDonate2.Location = new System.Drawing.Point(729, 284);
            this.pictureBoxDonate2.Name = "pictureBoxDonate2";
            this.pictureBoxDonate2.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxDonate2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDonate2.TabIndex = 80;
            this.pictureBoxDonate2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxDonate2, "Donate some bitcoins to help the developer!");
            this.pictureBoxDonate2.Click += new System.EventHandler(this.pictureBoxDonate2_Click);
            this.pictureBoxDonate2.MouseHover += new System.EventHandler(this.pictureBoxDonate2_MouseHover);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BTCETradeBot.Properties.Resources.Copy;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 80;
            this.toolTip1.SetToolTip(this.button1, "Copy Donation Address To Clipboard");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // checkBoxUseTrueTruePermission
            // 
            this.checkBoxUseTrueTruePermission.AutoSize = true;
            this.checkBoxUseTrueTruePermission.Location = new System.Drawing.Point(6, 21);
            this.checkBoxUseTrueTruePermission.Name = "checkBoxUseTrueTruePermission";
            this.checkBoxUseTrueTruePermission.Size = new System.Drawing.Size(148, 17);
            this.checkBoxUseTrueTruePermission.TabIndex = 4;
            this.checkBoxUseTrueTruePermission.Text = "Use True True Permission";
            this.toolTip1.SetToolTip(this.checkBoxUseTrueTruePermission, "Use this permission for auto trade");
            this.checkBoxUseTrueTruePermission.UseVisualStyleBackColor = true;
            this.checkBoxUseTrueTruePermission.CheckedChanged += new System.EventHandler(this.checkBoxUseTrueTruePermission_CheckedChanged);
            // 
            // checkBoxConsiderFeeInSell
            // 
            this.checkBoxConsiderFeeInSell.AutoSize = true;
            this.checkBoxConsiderFeeInSell.Location = new System.Drawing.Point(416, 78);
            this.checkBoxConsiderFeeInSell.Name = "checkBoxConsiderFeeInSell";
            this.checkBoxConsiderFeeInSell.Size = new System.Drawing.Size(15, 14);
            this.checkBoxConsiderFeeInSell.TabIndex = 17;
            this.toolTip1.SetToolTip(this.checkBoxConsiderFeeInSell, "Consider fee in sell price. (Sell with a higher price)");
            this.checkBoxConsiderFeeInSell.UseVisualStyleBackColor = true;
            this.checkBoxConsiderFeeInSell.CheckedChanged += new System.EventHandler(this.checkBoxConsiderFeeInSell_CheckedChanged);
            // 
            // checkBoxConsiderFeeInBuy
            // 
            this.checkBoxConsiderFeeInBuy.AutoSize = true;
            this.checkBoxConsiderFeeInBuy.Location = new System.Drawing.Point(416, 58);
            this.checkBoxConsiderFeeInBuy.Name = "checkBoxConsiderFeeInBuy";
            this.checkBoxConsiderFeeInBuy.Size = new System.Drawing.Size(15, 14);
            this.checkBoxConsiderFeeInBuy.TabIndex = 9;
            this.toolTip1.SetToolTip(this.checkBoxConsiderFeeInBuy, "Consider fee in calculated buy price. (Buy with a lower price)");
            this.checkBoxConsiderFeeInBuy.UseVisualStyleBackColor = true;
            this.checkBoxConsiderFeeInBuy.CheckedChanged += new System.EventHandler(this.checkBoxConsiderFeeInBuy_CheckedChanged);
            // 
            // buttonRefreshStatistics
            // 
            this.buttonRefreshStatistics.BackgroundImage = global::BTCETradeBot.Properties.Resources.Refresh128;
            this.buttonRefreshStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefreshStatistics.Location = new System.Drawing.Point(55, -1);
            this.buttonRefreshStatistics.Name = "buttonRefreshStatistics";
            this.buttonRefreshStatistics.Size = new System.Drawing.Size(18, 18);
            this.buttonRefreshStatistics.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonRefreshStatistics, "Refresh API Info");
            this.buttonRefreshStatistics.UseVisualStyleBackColor = true;
            this.buttonRefreshStatistics.Click += new System.EventHandler(this.buttonRefreshStatistics_Click);
            // 
            // numericUpDownRateRound
            // 
            this.numericUpDownRateRound.Location = new System.Drawing.Point(301, 6);
            this.numericUpDownRateRound.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRateRound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRateRound.Name = "numericUpDownRateRound";
            this.numericUpDownRateRound.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownRateRound.TabIndex = 100;
            this.toolTip1.SetToolTip(this.numericUpDownRateRound, "Changing these values may lead to this error: \"You incorrectly entered some value" +
        "s\" (For BTC = 3)");
            this.numericUpDownRateRound.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRateRound.ValueChanged += new System.EventHandler(this.numericUpDownRateRound_ValueChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(169, 9);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(132, 13);
            this.label53.TabIndex = 101;
            this.label53.Text = "Rate/Price Decimal Digits:";
            this.toolTip1.SetToolTip(this.label53, "Changing these values may lead to this error: \"You incorrectly entered some value" +
        "s\" (For BTC = 3)");
            // 
            // numericUpDownAmountRound
            // 
            this.numericUpDownAmountRound.Location = new System.Drawing.Point(473, 6);
            this.numericUpDownAmountRound.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAmountRound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmountRound.Name = "numericUpDownAmountRound";
            this.numericUpDownAmountRound.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownAmountRound.TabIndex = 102;
            this.toolTip1.SetToolTip(this.numericUpDownAmountRound, "Changing these values may lead to this error: \"You incorrectly entered some value" +
        "s\"");
            this.numericUpDownAmountRound.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownAmountRound.ValueChanged += new System.EventHandler(this.numericUpDownAmountRound_ValueChanged);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(356, 9);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(116, 13);
            this.label56.TabIndex = 103;
            this.label56.Text = "Amount Decimal Digits:";
            this.toolTip1.SetToolTip(this.label56, "Changing these values may lead to this error: \"You incorrectly entered some value" +
        "s\"");
            // 
            // textBoxBuyProfit
            // 
            this.textBoxBuyProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuyProfit.Location = new System.Drawing.Point(484, 55);
            this.textBoxBuyProfit.Name = "textBoxBuyProfit";
            this.textBoxBuyProfit.Size = new System.Drawing.Size(44, 20);
            this.textBoxBuyProfit.TabIndex = 10;
            this.textBoxBuyProfit.Text = "0.002";
            this.toolTip1.SetToolTip(this.textBoxBuyProfit, "Lowers the buy price");
            this.textBoxBuyProfit.TextChanged += new System.EventHandler(this.textBoxBuyProfit_TextChanged);
            // 
            // textBoxSellProfit
            // 
            this.textBoxSellProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSellProfit.Location = new System.Drawing.Point(484, 74);
            this.textBoxSellProfit.Name = "textBoxSellProfit";
            this.textBoxSellProfit.Size = new System.Drawing.Size(44, 20);
            this.textBoxSellProfit.TabIndex = 18;
            this.textBoxSellProfit.Text = "0.002";
            this.toolTip1.SetToolTip(this.textBoxSellProfit, "Increases the sell price");
            this.textBoxSellProfit.TextChanged += new System.EventHandler(this.textBoxSellProfit_TextChanged);
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownInterval.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownInterval.Location = new System.Drawing.Point(976, 6);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownInterval.TabIndex = 0;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(872, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Update Interval (ms):";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(531, -64);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(83, 23);
            this.buttonTest.TabIndex = 45;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Visible = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStartStop,
            this.toolStripStatusLabelFee,
            this.toolStripStatusLabelLastBought,
            this.toolStripStatusLabelLastSold,
            this.toolStripStatusLabelLastCheck});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1040, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 46;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStartStop
            // 
            this.toolStripStatusLabelStartStop.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelStartStop.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelStartStop.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabelStartStop.Name = "toolStripStatusLabelStartStop";
            this.toolStripStatusLabelStartStop.Size = new System.Drawing.Size(55, 19);
            this.toolStripStatusLabelStartStop.Text = "Stopped";
            this.toolStripStatusLabelStartStop.Click += new System.EventHandler(this.toolStripStatusLabelStartStop_Click);
            // 
            // toolStripStatusLabelFee
            // 
            this.toolStripStatusLabelFee.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelFee.Name = "toolStripStatusLabelFee";
            this.toolStripStatusLabelFee.Size = new System.Drawing.Size(29, 19);
            this.toolStripStatusLabelFee.Text = "Fee";
            // 
            // toolStripStatusLabelLastBought
            // 
            this.toolStripStatusLabelLastBought.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelLastBought.Name = "toolStripStatusLabelLastBought";
            this.toolStripStatusLabelLastBought.Size = new System.Drawing.Size(92, 19);
            this.toolStripStatusLabelLastBought.Text = "Last buy: Never";
            // 
            // toolStripStatusLabelLastSold
            // 
            this.toolStripStatusLabelLastSold.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelLastSold.Name = "toolStripStatusLabelLastSold";
            this.toolStripStatusLabelLastSold.Size = new System.Drawing.Size(89, 19);
            this.toolStripStatusLabelLastSold.Text = "Last sell: Never";
            // 
            // toolStripStatusLabelLastCheck
            // 
            this.toolStripStatusLabelLastCheck.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelLastCheck.Name = "toolStripStatusLabelLastCheck";
            this.toolStripStatusLabelLastCheck.Size = new System.Drawing.Size(109, 19);
            this.toolStripStatusLabelLastCheck.Text = "Last update: Never";
            // 
            // textBoxAPISecret
            // 
            this.textBoxAPISecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAPISecret.Location = new System.Drawing.Point(47, 41);
            this.textBoxAPISecret.Name = "textBoxAPISecret";
            this.textBoxAPISecret.PasswordChar = '*';
            this.textBoxAPISecret.Size = new System.Drawing.Size(137, 20);
            this.textBoxAPISecret.TabIndex = 2;
            this.textBoxAPISecret.TextChanged += new System.EventHandler(this.textBoxAPISecret_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "Secret:";
            // 
            // textBoxAPIKey
            // 
            this.textBoxAPIKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAPIKey.Location = new System.Drawing.Point(47, 19);
            this.textBoxAPIKey.Name = "textBoxAPIKey";
            this.textBoxAPIKey.Size = new System.Drawing.Size(265, 20);
            this.textBoxAPIKey.TabIndex = 1;
            this.textBoxAPIKey.TextChanged += new System.EventHandler(this.textBoxAPIKey_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "Key:";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestart.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.ForeColor = System.Drawing.Color.Red;
            this.buttonRestart.Location = new System.Drawing.Point(947, 572);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(54, 25);
            this.buttonRestart.TabIndex = 54;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.engineToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1040, 24);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.restartToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveToolStripMenuItem.Image = global::BTCETradeBot.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.saveToolStripMenuItem.Text = "&Save Settings";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Image = global::BTCETradeBot.Properties.Resources.refresh;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.restartToolStripMenuItem.Text = "&Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::BTCETradeBot.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoStartToolStripMenuItem,
            this.connectionModeToolStripMenuItem,
            this.toolStripMenuItem3,
            this.resetSettingsToolStripMenuItem,
            this.deleteDatabaseToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // autoStartToolStripMenuItem
            // 
            this.autoStartToolStripMenuItem.Checked = true;
            this.autoStartToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoStartToolStripMenuItem.Name = "autoStartToolStripMenuItem";
            this.autoStartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoStartToolStripMenuItem.Text = "Auto &Start";
            this.autoStartToolStripMenuItem.Click += new System.EventHandler(this.autoStartToolStripMenuItem_Click);
            // 
            // connectionModeToolStripMenuItem
            // 
            this.connectionModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTTPRequestToolStripMenuItem,
            this.webBrowserToolStripMenuItem,
            this.smoothHTTPRequestToolStripMenuItem});
            this.connectionModeToolStripMenuItem.Name = "connectionModeToolStripMenuItem";
            this.connectionModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectionModeToolStripMenuItem.Text = "Connection Mode";
            // 
            // hTTPRequestToolStripMenuItem
            // 
            this.hTTPRequestToolStripMenuItem.Name = "hTTPRequestToolStripMenuItem";
            this.hTTPRequestToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hTTPRequestToolStripMenuItem.Text = "HTTP Request";
            this.hTTPRequestToolStripMenuItem.CheckedChanged += new System.EventHandler(this.hTTPRequestToolStripMenuItem_CheckedChanged);
            this.hTTPRequestToolStripMenuItem.Click += new System.EventHandler(this.hTTPRequestToolStripMenuItem_Click);
            // 
            // webBrowserToolStripMenuItem
            // 
            this.webBrowserToolStripMenuItem.Name = "webBrowserToolStripMenuItem";
            this.webBrowserToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.webBrowserToolStripMenuItem.Text = "Web Browser";
            this.webBrowserToolStripMenuItem.CheckedChanged += new System.EventHandler(this.webBrowserToolStripMenuItem_CheckedChanged);
            this.webBrowserToolStripMenuItem.Click += new System.EventHandler(this.webBrowserToolStripMenuItem_Click);
            // 
            // smoothHTTPRequestToolStripMenuItem
            // 
            this.smoothHTTPRequestToolStripMenuItem.Checked = true;
            this.smoothHTTPRequestToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smoothHTTPRequestToolStripMenuItem.Name = "smoothHTTPRequestToolStripMenuItem";
            this.smoothHTTPRequestToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.smoothHTTPRequestToolStripMenuItem.Text = "Smooth HTTP Request";
            this.smoothHTTPRequestToolStripMenuItem.CheckedChanged += new System.EventHandler(this.smoothHTTPRequestToolStripMenuItem_CheckedChanged);
            this.smoothHTTPRequestToolStripMenuItem.Click += new System.EventHandler(this.smoothHTTPRequestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetSettingsToolStripMenuItem.Text = "&Reset Settings";
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem_Click);
            // 
            // engineToolStripMenuItem
            // 
            this.engineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.activePairToolStripMenuItem});
            this.engineToolStripMenuItem.Name = "engineToolStripMenuItem";
            this.engineToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.engineToolStripMenuItem.Text = "&Engine";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::BTCETradeBot.Properties.Resources.StartBig;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.startToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // activePairToolStripMenuItem
            // 
            this.activePairToolStripMenuItem.Name = "activePairToolStripMenuItem";
            this.activePairToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.activePairToolStripMenuItem.Text = "Active Pair";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoCheckForUpdateToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem,
            this.downloadLatestVersionToolStripMenuItem,
            this.toolStripMenuItem4,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // autoCheckForUpdateToolStripMenuItem
            // 
            this.autoCheckForUpdateToolStripMenuItem.Name = "autoCheckForUpdateToolStripMenuItem";
            this.autoCheckForUpdateToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.autoCheckForUpdateToolStripMenuItem.Text = "Auto Check For Update";
            this.autoCheckForUpdateToolStripMenuItem.Visible = false;
            this.autoCheckForUpdateToolStripMenuItem.Click += new System.EventHandler(this.autoCheckForUpdateToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check For Update Now";
            this.checkForUpdateToolStripMenuItem.Visible = false;
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // downloadLatestVersionToolStripMenuItem
            // 
            this.downloadLatestVersionToolStripMenuItem.Name = "downloadLatestVersionToolStripMenuItem";
            this.downloadLatestVersionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.downloadLatestVersionToolStripMenuItem.Text = "Download Latest Version";
            this.downloadLatestVersionToolStripMenuItem.Visible = false;
            this.downloadLatestVersionToolStripMenuItem.Click += new System.EventHandler(this.downloadLatestVersionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(200, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::BTCETradeBot.Properties.Resources.Info;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBoxAutoTrade
            // 
            this.groupBoxAutoTrade.Controls.Add(this.textBoxBTCEBuyPrice);
            this.groupBoxAutoTrade.Controls.Add(this.textBoxBTCESellPrice);
            this.groupBoxAutoTrade.Controls.Add(this.comboBoxAutoSellAmount);
            this.groupBoxAutoTrade.Controls.Add(this.comboBoxAutoBuyAmount);
            this.groupBoxAutoTrade.Controls.Add(this.labelThresholdCurrency);
            this.groupBoxAutoTrade.Controls.Add(this.labelBuyThresholdValue);
            this.groupBoxAutoTrade.Controls.Add(this.labelSellThresholdValue);
            this.groupBoxAutoTrade.Controls.Add(this.checkBoxUseTrueTruePermission);
            this.groupBoxAutoTrade.Controls.Add(this.textBoxAutoBuyTotalResult);
            this.groupBoxAutoTrade.Controls.Add(this.textBoxAutoSellTotalResult);
            this.groupBoxAutoTrade.Controls.Add(this.label51);
            this.groupBoxAutoTrade.Controls.Add(this.comboBoxSellCondition);
            this.groupBoxAutoTrade.Controls.Add(this.label49);
            this.groupBoxAutoTrade.Controls.Add(this.comboBoxBuyCondition);
            this.groupBoxAutoTrade.Controls.Add(this.label2);
            this.groupBoxAutoTrade.Controls.Add(this.textBoxCalcBuyPrice);
            this.groupBoxAutoTrade.Controls.Add(this.textBoxCalcSellPrice);
            this.groupBoxAutoTrade.Controls.Add(this.label44);
            this.groupBoxAutoTrade.Controls.Add(this.label43);
            this.groupBoxAutoTrade.Controls.Add(this.label41);
            this.groupBoxAutoTrade.Controls.Add(this.label36);
            this.groupBoxAutoTrade.Controls.Add(this.label13);
            this.groupBoxAutoTrade.Controls.Add(this.label11);
            this.groupBoxAutoTrade.Controls.Add(this.label10);
            this.groupBoxAutoTrade.Controls.Add(this.textBoxBuyThreshold);
            this.groupBoxAutoTrade.Controls.Add(this.numericUpDownLimitSellOrders);
            this.groupBoxAutoTrade.Controls.Add(this.numericUpDownLimitBuyOrders);
            this.groupBoxAutoTrade.Controls.Add(this.label9);
            this.groupBoxAutoTrade.Controls.Add(this.checkBoxLimitSellOrders);
            this.groupBoxAutoTrade.Controls.Add(this.checkBoxLimitBuyOrders);
            this.groupBoxAutoTrade.Controls.Add(this.labelBuyCount);
            this.groupBoxAutoTrade.Controls.Add(this.labelSellCount);
            this.groupBoxAutoTrade.Controls.Add(this.labelBuyPriceDelta);
            this.groupBoxAutoTrade.Controls.Add(this.labelSellPriceDelta);
            this.groupBoxAutoTrade.Controls.Add(this.label12);
            this.groupBoxAutoTrade.Controls.Add(this.labelSellNote);
            this.groupBoxAutoTrade.Controls.Add(this.labelBuyNote);
            this.groupBoxAutoTrade.Controls.Add(this.textBoxSellThreshold);
            this.groupBoxAutoTrade.Controls.Add(this.textBoxBuyFee);
            this.groupBoxAutoTrade.Controls.Add(this.textBoxSellFee);
            this.groupBoxAutoTrade.Controls.Add(this.textBoxBuyProfit);
            this.groupBoxAutoTrade.Controls.Add(this.textBoxSellProfit);
            this.groupBoxAutoTrade.Controls.Add(this.checkBoxConsiderFeeInSell);
            this.groupBoxAutoTrade.Controls.Add(this.checkBoxConsiderFeeInBuy);
            this.groupBoxAutoTrade.Controls.Add(this.checkBoxAllowBuy);
            this.groupBoxAutoTrade.Controls.Add(this.checkBoxAllowSell);
            this.groupBoxAutoTrade.Enabled = false;
            this.groupBoxAutoTrade.Location = new System.Drawing.Point(12, 289);
            this.groupBoxAutoTrade.Name = "groupBoxAutoTrade";
            this.groupBoxAutoTrade.Size = new System.Drawing.Size(1017, 99);
            this.groupBoxAutoTrade.TabIndex = 3;
            this.groupBoxAutoTrade.TabStop = false;
            // 
            // textBoxBTCEBuyPrice
            // 
            this.textBoxBTCEBuyPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBTCEBuyPrice.Enabled = false;
            this.textBoxBTCEBuyPrice.Location = new System.Drawing.Point(320, 55);
            this.textBoxBTCEBuyPrice.Name = "textBoxBTCEBuyPrice";
            this.textBoxBTCEBuyPrice.ReadOnly = true;
            this.textBoxBTCEBuyPrice.Size = new System.Drawing.Size(95, 20);
            this.textBoxBTCEBuyPrice.TabIndex = 83;
            this.textBoxBTCEBuyPrice.Text = "N/A";
            // 
            // textBoxBTCESellPrice
            // 
            this.textBoxBTCESellPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBTCESellPrice.Enabled = false;
            this.textBoxBTCESellPrice.Location = new System.Drawing.Point(320, 74);
            this.textBoxBTCESellPrice.Name = "textBoxBTCESellPrice";
            this.textBoxBTCESellPrice.ReadOnly = true;
            this.textBoxBTCESellPrice.Size = new System.Drawing.Size(95, 20);
            this.textBoxBTCESellPrice.TabIndex = 84;
            this.textBoxBTCESellPrice.Text = "N/A";
            // 
            // comboBoxAutoSellAmount
            // 
            this.comboBoxAutoSellAmount.FormattingEnabled = true;
            this.comboBoxAutoSellAmount.Items.AddRange(new object[] {
            "0.0104",
            "0.1",
            "ALL"});
            this.comboBoxAutoSellAmount.Location = new System.Drawing.Point(261, 75);
            this.comboBoxAutoSellAmount.Name = "comboBoxAutoSellAmount";
            this.comboBoxAutoSellAmount.Size = new System.Drawing.Size(58, 21);
            this.comboBoxAutoSellAmount.TabIndex = 16;
            this.comboBoxAutoSellAmount.Text = "0.0104";
            this.comboBoxAutoSellAmount.TextChanged += new System.EventHandler(this.comboBoxAutoSellAmount_TextChanged);
            // 
            // comboBoxAutoBuyAmount
            // 
            this.comboBoxAutoBuyAmount.FormattingEnabled = true;
            this.comboBoxAutoBuyAmount.Items.AddRange(new object[] {
            "0.0104",
            "0.1",
            "ALL"});
            this.comboBoxAutoBuyAmount.Location = new System.Drawing.Point(261, 54);
            this.comboBoxAutoBuyAmount.Name = "comboBoxAutoBuyAmount";
            this.comboBoxAutoBuyAmount.Size = new System.Drawing.Size(58, 21);
            this.comboBoxAutoBuyAmount.TabIndex = 8;
            this.comboBoxAutoBuyAmount.Text = "0.0104";
            this.comboBoxAutoBuyAmount.TextChanged += new System.EventHandler(this.comboBoxAutoBuyAmount_TextChanged);
            // 
            // labelThresholdCurrency
            // 
            this.labelThresholdCurrency.AutoSize = true;
            this.labelThresholdCurrency.Location = new System.Drawing.Point(182, 39);
            this.labelThresholdCurrency.Name = "labelThresholdCurrency";
            this.labelThresholdCurrency.Size = new System.Drawing.Size(54, 13);
            this.labelThresholdCurrency.TabIndex = 99;
            this.labelThresholdCurrency.Text = "Threshold";
            // 
            // labelBuyThresholdValue
            // 
            this.labelBuyThresholdValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBuyThresholdValue.Enabled = false;
            this.labelBuyThresholdValue.Location = new System.Drawing.Point(151, 55);
            this.labelBuyThresholdValue.Name = "labelBuyThresholdValue";
            this.labelBuyThresholdValue.Size = new System.Drawing.Size(110, 20);
            this.labelBuyThresholdValue.TabIndex = 97;
            this.labelBuyThresholdValue.Text = "N/A";
            // 
            // labelSellThresholdValue
            // 
            this.labelSellThresholdValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSellThresholdValue.Enabled = false;
            this.labelSellThresholdValue.Location = new System.Drawing.Point(151, 74);
            this.labelSellThresholdValue.Name = "labelSellThresholdValue";
            this.labelSellThresholdValue.Size = new System.Drawing.Size(110, 20);
            this.labelSellThresholdValue.TabIndex = 98;
            this.labelSellThresholdValue.Text = "N/A";
            // 
            // textBoxAutoBuyTotalResult
            // 
            this.textBoxAutoBuyTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAutoBuyTotalResult.Enabled = false;
            this.textBoxAutoBuyTotalResult.Location = new System.Drawing.Point(715, 55);
            this.textBoxAutoBuyTotalResult.Name = "textBoxAutoBuyTotalResult";
            this.textBoxAutoBuyTotalResult.ReadOnly = true;
            this.textBoxAutoBuyTotalResult.Size = new System.Drawing.Size(95, 20);
            this.textBoxAutoBuyTotalResult.TabIndex = 95;
            this.textBoxAutoBuyTotalResult.Text = "N/A";
            this.textBoxAutoBuyTotalResult.TextChanged += new System.EventHandler(this.textBoxAutoBuyTotalResult_TextChanged);
            // 
            // textBoxAutoSellTotalResult
            // 
            this.textBoxAutoSellTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAutoSellTotalResult.Enabled = false;
            this.textBoxAutoSellTotalResult.Location = new System.Drawing.Point(715, 74);
            this.textBoxAutoSellTotalResult.Name = "textBoxAutoSellTotalResult";
            this.textBoxAutoSellTotalResult.ReadOnly = true;
            this.textBoxAutoSellTotalResult.Size = new System.Drawing.Size(95, 20);
            this.textBoxAutoSellTotalResult.TabIndex = 96;
            this.textBoxAutoSellTotalResult.Text = "N/A";
            this.textBoxAutoSellTotalResult.TextChanged += new System.EventHandler(this.textBoxAutoSellTotalResult_TextChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(724, 41);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(81, 13);
            this.label51.TabIndex = 94;
            this.label51.Text = "What You\'ll Get";
            // 
            // comboBoxSellCondition
            // 
            this.comboBoxSellCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSellCondition.FormattingEnabled = true;
            this.comboBoxSellCondition.Items.AddRange(new object[] {
            ">",
            "<"});
            this.comboBoxSellCondition.Location = new System.Drawing.Point(74, 75);
            this.comboBoxSellCondition.Name = "comboBoxSellCondition";
            this.comboBoxSellCondition.Size = new System.Drawing.Size(41, 21);
            this.comboBoxSellCondition.TabIndex = 14;
            this.comboBoxSellCondition.SelectedIndexChanged += new System.EventHandler(this.comboBoxSellCondition_SelectedIndexChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(73, 40);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(41, 13);
            this.label49.TabIndex = 92;
            this.label49.Text = "If Delta";
            // 
            // comboBoxBuyCondition
            // 
            this.comboBoxBuyCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuyCondition.FormattingEnabled = true;
            this.comboBoxBuyCondition.Items.AddRange(new object[] {
            ">",
            "<"});
            this.comboBoxBuyCondition.Location = new System.Drawing.Point(74, 53);
            this.comboBoxBuyCondition.Name = "comboBoxBuyCondition";
            this.comboBoxBuyCondition.Size = new System.Drawing.Size(41, 21);
            this.comboBoxBuyCondition.TabIndex = 6;
            this.comboBoxBuyCondition.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuyCondition_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Threshold (%)";
            // 
            // textBoxCalcBuyPrice
            // 
            this.textBoxCalcBuyPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCalcBuyPrice.Enabled = false;
            this.textBoxCalcBuyPrice.Location = new System.Drawing.Point(527, 55);
            this.textBoxCalcBuyPrice.Name = "textBoxCalcBuyPrice";
            this.textBoxCalcBuyPrice.ReadOnly = true;
            this.textBoxCalcBuyPrice.Size = new System.Drawing.Size(95, 20);
            this.textBoxCalcBuyPrice.TabIndex = 86;
            this.textBoxCalcBuyPrice.Text = "N/A";
            // 
            // textBoxCalcSellPrice
            // 
            this.textBoxCalcSellPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCalcSellPrice.Enabled = false;
            this.textBoxCalcSellPrice.Location = new System.Drawing.Point(527, 74);
            this.textBoxCalcSellPrice.Name = "textBoxCalcSellPrice";
            this.textBoxCalcSellPrice.ReadOnly = true;
            this.textBoxCalcSellPrice.Size = new System.Drawing.Size(95, 20);
            this.textBoxCalcSellPrice.TabIndex = 87;
            this.textBoxCalcSellPrice.Text = "N/A";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(534, 41);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(84, 13);
            this.label44.TabIndex = 85;
            this.label44.Text = "Calculated Price";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(345, 41);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(38, 13);
            this.label43.TabIndex = 82;
            this.label43.Text = "BTC-E";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(441, 41);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(25, 13);
            this.label41.TabIndex = 79;
            this.label41.Text = "Fee";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(491, 41);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(31, 13);
            this.label36.TabIndex = 76;
            this.label36.Text = "Profit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(921, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Limit Orders Count";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(866, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Note";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(648, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "Delta";
            // 
            // numericUpDownLimitSellOrders
            // 
            this.numericUpDownLimitSellOrders.Enabled = false;
            this.numericUpDownLimitSellOrders.Location = new System.Drawing.Point(972, 73);
            this.numericUpDownLimitSellOrders.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownLimitSellOrders.Name = "numericUpDownLimitSellOrders";
            this.numericUpDownLimitSellOrders.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownLimitSellOrders.TabIndex = 20;
            this.numericUpDownLimitSellOrders.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLimitSellOrders.ValueChanged += new System.EventHandler(this.numericUpDownLimitSellOrders_ValueChanged);
            // 
            // numericUpDownLimitBuyOrders
            // 
            this.numericUpDownLimitBuyOrders.Enabled = false;
            this.numericUpDownLimitBuyOrders.Location = new System.Drawing.Point(972, 54);
            this.numericUpDownLimitBuyOrders.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownLimitBuyOrders.Name = "numericUpDownLimitBuyOrders";
            this.numericUpDownLimitBuyOrders.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownLimitBuyOrders.TabIndex = 12;
            this.numericUpDownLimitBuyOrders.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLimitBuyOrders.ValueChanged += new System.EventHandler(this.numericUpDownLimitBuyOrders_ValueChanged);
            // 
            // checkBoxLimitSellOrders
            // 
            this.checkBoxLimitSellOrders.AutoSize = true;
            this.checkBoxLimitSellOrders.Enabled = false;
            this.checkBoxLimitSellOrders.Location = new System.Drawing.Point(924, 76);
            this.checkBoxLimitSellOrders.Name = "checkBoxLimitSellOrders";
            this.checkBoxLimitSellOrders.Size = new System.Drawing.Size(50, 17);
            this.checkBoxLimitSellOrders.TabIndex = 19;
            this.checkBoxLimitSellOrders.Text = "Limit:";
            this.checkBoxLimitSellOrders.UseVisualStyleBackColor = true;
            this.checkBoxLimitSellOrders.CheckedChanged += new System.EventHandler(this.checkBoxLimitSellOrders_CheckedChanged);
            // 
            // checkBoxLimitBuyOrders
            // 
            this.checkBoxLimitBuyOrders.AutoSize = true;
            this.checkBoxLimitBuyOrders.Enabled = false;
            this.checkBoxLimitBuyOrders.Location = new System.Drawing.Point(924, 56);
            this.checkBoxLimitBuyOrders.Name = "checkBoxLimitBuyOrders";
            this.checkBoxLimitBuyOrders.Size = new System.Drawing.Size(50, 17);
            this.checkBoxLimitBuyOrders.TabIndex = 11;
            this.checkBoxLimitBuyOrders.Text = "Limit:";
            this.checkBoxLimitBuyOrders.UseVisualStyleBackColor = true;
            this.checkBoxLimitBuyOrders.CheckedChanged += new System.EventHandler(this.checkBoxLimitBuyOrders_CheckedChanged);
            // 
            // textBoxBuyFee
            // 
            this.textBoxBuyFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuyFee.Enabled = false;
            this.textBoxBuyFee.Location = new System.Drawing.Point(430, 55);
            this.textBoxBuyFee.Name = "textBoxBuyFee";
            this.textBoxBuyFee.ReadOnly = true;
            this.textBoxBuyFee.Size = new System.Drawing.Size(52, 20);
            this.textBoxBuyFee.TabIndex = 80;
            this.textBoxBuyFee.Text = "N/A";
            // 
            // textBoxSellFee
            // 
            this.textBoxSellFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSellFee.Enabled = false;
            this.textBoxSellFee.Location = new System.Drawing.Point(430, 74);
            this.textBoxSellFee.Name = "textBoxSellFee";
            this.textBoxSellFee.ReadOnly = true;
            this.textBoxSellFee.Size = new System.Drawing.Size(52, 20);
            this.textBoxSellFee.TabIndex = 81;
            this.textBoxSellFee.Text = "N/A";
            // 
            // groupBoxApiInfo
            // 
            this.groupBoxApiInfo.Controls.Add(this.txtID);
            this.groupBoxApiInfo.Controls.Add(this.label58);
            this.groupBoxApiInfo.Controls.Add(this.label6);
            this.groupBoxApiInfo.Controls.Add(this.textBoxFundXPM);
            this.groupBoxApiInfo.Controls.Add(this.labelAPIInfoStatus);
            this.groupBoxApiInfo.Controls.Add(this.button1);
            this.groupBoxApiInfo.Controls.Add(this.buttonRefreshInfo);
            this.groupBoxApiInfo.Controls.Add(this.pictureBoxDonate);
            this.groupBoxApiInfo.Controls.Add(this.linkLabelDoation);
            this.groupBoxApiInfo.Controls.Add(this.label34);
            this.groupBoxApiInfo.Controls.Add(this.label33);
            this.groupBoxApiInfo.Controls.Add(this.textBoxInfoServerTime);
            this.groupBoxApiInfo.Controls.Add(this.label32);
            this.groupBoxApiInfo.Controls.Add(this.textBoxInfoTransactionCount);
            this.groupBoxApiInfo.Controls.Add(this.label31);
            this.groupBoxApiInfo.Controls.Add(this.label30);
            this.groupBoxApiInfo.Controls.Add(this.textBoxInfoOpenOrders);
            this.groupBoxApiInfo.Controls.Add(this.checkBoxRightTrade);
            this.groupBoxApiInfo.Controls.Add(this.label27);
            this.groupBoxApiInfo.Controls.Add(this.textBoxAPISecret);
            this.groupBoxApiInfo.Controls.Add(this.textBoxFundEUR);
            this.groupBoxApiInfo.Controls.Add(this.label18);
            this.groupBoxApiInfo.Controls.Add(this.label29);
            this.groupBoxApiInfo.Controls.Add(this.textBoxAPIKey);
            this.groupBoxApiInfo.Controls.Add(this.checkBoxRightInfo);
            this.groupBoxApiInfo.Controls.Add(this.label19);
            this.groupBoxApiInfo.Controls.Add(this.label28);
            this.groupBoxApiInfo.Controls.Add(this.textBoxFundRUR);
            this.groupBoxApiInfo.Controls.Add(this.label25);
            this.groupBoxApiInfo.Controls.Add(this.textBoxFundFTC);
            this.groupBoxApiInfo.Controls.Add(this.label26);
            this.groupBoxApiInfo.Controls.Add(this.textBoxFundPPC);
            this.groupBoxApiInfo.Controls.Add(this.label24);
            this.groupBoxApiInfo.Controls.Add(this.textBoxFundTRC);
            this.groupBoxApiInfo.Controls.Add(this.label23);
            this.groupBoxApiInfo.Controls.Add(this.textBoxFundNVC);
            this.groupBoxApiInfo.Controls.Add(this.label22);
            this.groupBoxApiInfo.Controls.Add(this.textBoxFundNMC);
            this.groupBoxApiInfo.Controls.Add(this.label21);
            this.groupBoxApiInfo.Controls.Add(this.textBoxFundLTC);
            this.groupBoxApiInfo.Controls.Add(this.label20);
            this.groupBoxApiInfo.Controls.Add(this.textBoxFundUSD);
            this.groupBoxApiInfo.Controls.Add(this.label3);
            this.groupBoxApiInfo.Controls.Add(this.textBoxFundBTC);
            this.groupBoxApiInfo.Location = new System.Drawing.Point(706, 62);
            this.groupBoxApiInfo.Name = "groupBoxApiInfo";
            this.groupBoxApiInfo.Size = new System.Drawing.Size(323, 247);
            this.groupBoxApiInfo.TabIndex = 0;
            this.groupBoxApiInfo.TabStop = false;
            this.groupBoxApiInfo.Text = "API Info";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(222, 41);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '*';
            this.txtID.Size = new System.Drawing.Size(90, 20);
            this.txtID.TabIndex = 84;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(200, 44);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(24, 13);
            this.label58.TabIndex = 85;
            this.label58.Text = "ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "XPM:";
            // 
            // textBoxFundXPM
            // 
            this.textBoxFundXPM.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFundXPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFundXPM.Location = new System.Drawing.Point(47, 159);
            this.textBoxFundXPM.Multiline = true;
            this.textBoxFundXPM.Name = "textBoxFundXPM";
            this.textBoxFundXPM.ReadOnly = true;
            this.textBoxFundXPM.Size = new System.Drawing.Size(108, 17);
            this.textBoxFundXPM.TabIndex = 43;
            // 
            // labelAPIInfoStatus
            // 
            this.labelAPIInfoStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAPIInfoStatus.Location = new System.Drawing.Point(71, 0);
            this.labelAPIInfoStatus.Name = "labelAPIInfoStatus";
            this.labelAPIInfoStatus.Size = new System.Drawing.Size(240, 16);
            this.labelAPIInfoStatus.TabIndex = 81;
            this.labelAPIInfoStatus.Text = "N/A";
            this.labelAPIInfoStatus.TextChanged += new System.EventHandler(this.labelAPIInfoStatus_TextChanged);
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.Gray;
            this.label34.Location = new System.Drawing.Point(-45, 65);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(418, 1);
            this.label34.TabIndex = 77;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Gray;
            this.label33.Location = new System.Drawing.Point(-44, 182);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(418, 1);
            this.label33.TabIndex = 76;
            // 
            // textBoxInfoServerTime
            // 
            this.textBoxInfoServerTime.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxInfoServerTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInfoServerTime.Location = new System.Drawing.Point(203, 221);
            this.textBoxInfoServerTime.Multiline = true;
            this.textBoxInfoServerTime.Name = "textBoxInfoServerTime";
            this.textBoxInfoServerTime.ReadOnly = true;
            this.textBoxInfoServerTime.Size = new System.Drawing.Size(108, 17);
            this.textBoxInfoServerTime.TabIndex = 46;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(102, 205);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(97, 13);
            this.label32.TabIndex = 75;
            this.label32.Text = "Transaction Count:";
            // 
            // textBoxInfoTransactionCount
            // 
            this.textBoxInfoTransactionCount.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxInfoTransactionCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInfoTransactionCount.Location = new System.Drawing.Point(203, 203);
            this.textBoxInfoTransactionCount.Multiline = true;
            this.textBoxInfoTransactionCount.Name = "textBoxInfoTransactionCount";
            this.textBoxInfoTransactionCount.ReadOnly = true;
            this.textBoxInfoTransactionCount.Size = new System.Drawing.Size(108, 17);
            this.textBoxInfoTransactionCount.TabIndex = 45;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(132, 221);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 13);
            this.label31.TabIndex = 73;
            this.label31.Text = "Server Time:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(129, 187);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 13);
            this.label30.TabIndex = 71;
            this.label30.Text = "Open Orders:";
            // 
            // textBoxInfoOpenOrders
            // 
            this.textBoxInfoOpenOrders.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxInfoOpenOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInfoOpenOrders.Location = new System.Drawing.Point(203, 185);
            this.textBoxInfoOpenOrders.Multiline = true;
            this.textBoxInfoOpenOrders.Name = "textBoxInfoOpenOrders";
            this.textBoxInfoOpenOrders.ReadOnly = true;
            this.textBoxInfoOpenOrders.Size = new System.Drawing.Size(108, 17);
            this.textBoxInfoOpenOrders.TabIndex = 44;
            // 
            // checkBoxRightTrade
            // 
            this.checkBoxRightTrade.AutoSize = true;
            this.checkBoxRightTrade.Enabled = false;
            this.checkBoxRightTrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRightTrade.Location = new System.Drawing.Point(47, 205);
            this.checkBoxRightTrade.Name = "checkBoxRightTrade";
            this.checkBoxRightTrade.Size = new System.Drawing.Size(51, 17);
            this.checkBoxRightTrade.TabIndex = 69;
            this.checkBoxRightTrade.Text = "Trade";
            this.checkBoxRightTrade.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(166, 144);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(33, 13);
            this.label27.TabIndex = 66;
            this.label27.Text = "EUR:";
            // 
            // textBoxFundEUR
            // 
            this.textBoxFundEUR.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFundEUR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFundEUR.Location = new System.Drawing.Point(203, 141);
            this.textBoxFundEUR.Multiline = true;
            this.textBoxFundEUR.Name = "textBoxFundEUR";
            this.textBoxFundEUR.ReadOnly = true;
            this.textBoxFundEUR.Size = new System.Drawing.Size(108, 17);
            this.textBoxFundEUR.TabIndex = 42;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 187);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 13);
            this.label29.TabIndex = 68;
            this.label29.Text = "Rights:";
            // 
            // checkBoxRightInfo
            // 
            this.checkBoxRightInfo.AutoSize = true;
            this.checkBoxRightInfo.Enabled = false;
            this.checkBoxRightInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRightInfo.Location = new System.Drawing.Point(47, 188);
            this.checkBoxRightInfo.Name = "checkBoxRightInfo";
            this.checkBoxRightInfo.Size = new System.Drawing.Size(41, 17);
            this.checkBoxRightInfo.TabIndex = 67;
            this.checkBoxRightInfo.Text = "Info";
            this.checkBoxRightInfo.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 144);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 13);
            this.label28.TabIndex = 64;
            this.label28.Text = "RUR:";
            // 
            // textBoxFundRUR
            // 
            this.textBoxFundRUR.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFundRUR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFundRUR.Location = new System.Drawing.Point(47, 141);
            this.textBoxFundRUR.Multiline = true;
            this.textBoxFundRUR.Name = "textBoxFundRUR";
            this.textBoxFundRUR.ReadOnly = true;
            this.textBoxFundRUR.Size = new System.Drawing.Size(108, 17);
            this.textBoxFundRUR.TabIndex = 41;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(169, 126);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 13);
            this.label25.TabIndex = 62;
            this.label25.Text = "FTC:";
            // 
            // textBoxFundFTC
            // 
            this.textBoxFundFTC.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFundFTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFundFTC.Location = new System.Drawing.Point(203, 123);
            this.textBoxFundFTC.Multiline = true;
            this.textBoxFundFTC.Name = "textBoxFundFTC";
            this.textBoxFundFTC.ReadOnly = true;
            this.textBoxFundFTC.Size = new System.Drawing.Size(108, 17);
            this.textBoxFundFTC.TabIndex = 40;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(15, 126);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 13);
            this.label26.TabIndex = 60;
            this.label26.Text = "PPC:";
            // 
            // textBoxFundPPC
            // 
            this.textBoxFundPPC.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFundPPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFundPPC.Location = new System.Drawing.Point(47, 123);
            this.textBoxFundPPC.Multiline = true;
            this.textBoxFundPPC.Name = "textBoxFundPPC";
            this.textBoxFundPPC.ReadOnly = true;
            this.textBoxFundPPC.Size = new System.Drawing.Size(108, 17);
            this.textBoxFundPPC.TabIndex = 39;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(167, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 58;
            this.label24.Text = "TRC:";
            // 
            // textBoxFundTRC
            // 
            this.textBoxFundTRC.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFundTRC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFundTRC.Location = new System.Drawing.Point(203, 105);
            this.textBoxFundTRC.Multiline = true;
            this.textBoxFundTRC.Name = "textBoxFundTRC";
            this.textBoxFundTRC.ReadOnly = true;
            this.textBoxFundTRC.Size = new System.Drawing.Size(108, 17);
            this.textBoxFundTRC.TabIndex = 38;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 108);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "NVC:";
            // 
            // textBoxFundNVC
            // 
            this.textBoxFundNVC.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFundNVC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFundNVC.Location = new System.Drawing.Point(47, 105);
            this.textBoxFundNVC.Multiline = true;
            this.textBoxFundNVC.Name = "textBoxFundNVC";
            this.textBoxFundNVC.ReadOnly = true;
            this.textBoxFundNVC.Size = new System.Drawing.Size(108, 17);
            this.textBoxFundNVC.TabIndex = 37;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(165, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 54;
            this.label22.Text = "NMC:";
            // 
            // textBoxFundNMC
            // 
            this.textBoxFundNMC.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFundNMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFundNMC.Location = new System.Drawing.Point(203, 87);
            this.textBoxFundNMC.Multiline = true;
            this.textBoxFundNMC.Name = "textBoxFundNMC";
            this.textBoxFundNMC.ReadOnly = true;
            this.textBoxFundNMC.Size = new System.Drawing.Size(108, 17);
            this.textBoxFundNMC.TabIndex = 36;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "LTC:";
            // 
            // textBoxFundLTC
            // 
            this.textBoxFundLTC.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFundLTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFundLTC.Location = new System.Drawing.Point(47, 87);
            this.textBoxFundLTC.Multiline = true;
            this.textBoxFundLTC.Name = "textBoxFundLTC";
            this.textBoxFundLTC.ReadOnly = true;
            this.textBoxFundLTC.Size = new System.Drawing.Size(108, 17);
            this.textBoxFundLTC.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "USD:";
            // 
            // textBoxFundUSD
            // 
            this.textBoxFundUSD.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFundUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFundUSD.Location = new System.Drawing.Point(47, 69);
            this.textBoxFundUSD.Multiline = true;
            this.textBoxFundUSD.Name = "textBoxFundUSD";
            this.textBoxFundUSD.ReadOnly = true;
            this.textBoxFundUSD.Size = new System.Drawing.Size(108, 17);
            this.textBoxFundUSD.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "BTC:";
            // 
            // textBoxFundBTC
            // 
            this.textBoxFundBTC.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFundBTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFundBTC.Location = new System.Drawing.Point(203, 69);
            this.textBoxFundBTC.Multiline = true;
            this.textBoxFundBTC.Name = "textBoxFundBTC";
            this.textBoxFundBTC.ReadOnly = true;
            this.textBoxFundBTC.Size = new System.Drawing.Size(108, 17);
            this.textBoxFundBTC.TabIndex = 34;
            // 
            // labelTotalAskAmount
            // 
            this.labelTotalAskAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalAskAmount.Location = new System.Drawing.Point(129, 172);
            this.labelTotalAskAmount.Name = "labelTotalAskAmount";
            this.labelTotalAskAmount.Size = new System.Drawing.Size(83, 16);
            this.labelTotalAskAmount.TabIndex = 36;
            this.labelTotalAskAmount.Text = "N/A";
            // 
            // labelTotalAskOrders
            // 
            this.labelTotalAskOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalAskOrders.Location = new System.Drawing.Point(99, 172);
            this.labelTotalAskOrders.Name = "labelTotalAskOrders";
            this.labelTotalAskOrders.Size = new System.Drawing.Size(31, 16);
            this.labelTotalAskOrders.TabIndex = 34;
            this.labelTotalAskOrders.Text = "N/A";
            // 
            // labelTotalAskValue
            // 
            this.labelTotalAskValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalAskValue.Location = new System.Drawing.Point(211, 172);
            this.labelTotalAskValue.Name = "labelTotalAskValue";
            this.labelTotalAskValue.Size = new System.Drawing.Size(70, 16);
            this.labelTotalAskValue.TabIndex = 38;
            this.labelTotalAskValue.Text = "N/A";
            // 
            // labelAskAVG
            // 
            this.labelAskAVG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAskAVG.Location = new System.Drawing.Point(280, 172);
            this.labelAskAVG.Name = "labelAskAVG";
            this.labelAskAVG.Size = new System.Drawing.Size(80, 16);
            this.labelAskAVG.TabIndex = 10;
            this.labelAskAVG.Text = "N/A";
            // 
            // labelTotalBidAmount
            // 
            this.labelTotalBidAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalBidAmount.Location = new System.Drawing.Point(129, 157);
            this.labelTotalBidAmount.Name = "labelTotalBidAmount";
            this.labelTotalBidAmount.Size = new System.Drawing.Size(83, 16);
            this.labelTotalBidAmount.TabIndex = 36;
            this.labelTotalBidAmount.Text = "N/A";
            // 
            // labelTotalBidOrders
            // 
            this.labelTotalBidOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalBidOrders.Location = new System.Drawing.Point(99, 157);
            this.labelTotalBidOrders.Name = "labelTotalBidOrders";
            this.labelTotalBidOrders.Size = new System.Drawing.Size(31, 16);
            this.labelTotalBidOrders.TabIndex = 34;
            this.labelTotalBidOrders.Text = "N/A";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(99, 143);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(38, 13);
            this.label35.TabIndex = 33;
            this.label35.Text = "Orders";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(134, 143);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(70, 13);
            this.label37.TabIndex = 35;
            this.label37.Text = "Total Amount";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(225, 143);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(61, 13);
            this.label39.TabIndex = 37;
            this.label39.Text = "Total Value";
            // 
            // labelTotalBidValue
            // 
            this.labelTotalBidValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalBidValue.Location = new System.Drawing.Point(211, 157);
            this.labelTotalBidValue.Name = "labelTotalBidValue";
            this.labelTotalBidValue.Size = new System.Drawing.Size(70, 16);
            this.labelTotalBidValue.TabIndex = 38;
            this.labelTotalBidValue.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Average";
            // 
            // labelBidAVG
            // 
            this.labelBidAVG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBidAVG.Location = new System.Drawing.Point(280, 157);
            this.labelBidAVG.Name = "labelBidAVG";
            this.labelBidAVG.Size = new System.Drawing.Size(80, 16);
            this.labelBidAVG.TabIndex = 8;
            this.labelBidAVG.Text = "N/A";
            // 
            // labelOldMid2
            // 
            this.labelOldMid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOldMid2.Location = new System.Drawing.Point(450, 187);
            this.labelOldMid2.Name = "labelOldMid2";
            this.labelOldMid2.Size = new System.Drawing.Size(58, 16);
            this.labelOldMid2.TabIndex = 17;
            this.labelOldMid2.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Delta";
            // 
            // labelDelta
            // 
            this.labelDelta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDelta.Location = new System.Drawing.Point(507, 164);
            this.labelDelta.Name = "labelDelta";
            this.labelDelta.Size = new System.Drawing.Size(80, 16);
            this.labelDelta.TabIndex = 15;
            this.labelDelta.Text = "N/A";
            // 
            // labelOldMid
            // 
            this.labelOldMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOldMid.Location = new System.Drawing.Point(450, 172);
            this.labelOldMid.Name = "labelOldMid";
            this.labelOldMid.Size = new System.Drawing.Size(58, 16);
            this.labelOldMid.TabIndex = 13;
            this.labelOldMid.Text = "N/A";
            // 
            // listViewTrades
            // 
            this.listViewTrades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTrades.FullRowSelect = true;
            this.listViewTrades.GridLines = true;
            this.listViewTrades.HideSelection = false;
            this.listViewTrades.Location = new System.Drawing.Point(162, 17);
            this.listViewTrades.Name = "listViewTrades";
            this.listViewTrades.Size = new System.Drawing.Size(518, 124);
            this.listViewTrades.TabIndex = 6;
            this.listViewTrades.UseCompatibleStateImageBehavior = false;
            this.listViewTrades.View = System.Windows.Forms.View.Details;
            this.listViewTrades.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewTrades_ColumnClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "AVG(Buy,Sell)";
            // 
            // labelNewMid
            // 
            this.labelNewMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNewMid.Location = new System.Drawing.Point(450, 157);
            this.labelNewMid.Name = "labelNewMid";
            this.labelNewMid.Size = new System.Drawing.Size(58, 16);
            this.labelNewMid.TabIndex = 12;
            this.labelNewMid.Text = "N/A";
            // 
            // labelTicker
            // 
            this.labelTicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTicker.Location = new System.Drawing.Point(6, 17);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(155, 124);
            this.labelTicker.TabIndex = 4;
            this.labelTicker.Text = "N/A";
            this.labelTicker.Click += new System.EventHandler(this.labelTicker_Click);
            // 
            // labelDelta2
            // 
            this.labelDelta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDelta2.Location = new System.Drawing.Point(507, 179);
            this.labelDelta2.Name = "labelDelta2";
            this.labelDelta2.Size = new System.Drawing.Size(80, 16);
            this.labelDelta2.TabIndex = 41;
            this.labelDelta2.Text = "N/A";
            // 
            // labelOldMid3
            // 
            this.labelOldMid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOldMid3.Location = new System.Drawing.Point(450, 202);
            this.labelOldMid3.Name = "labelOldMid3";
            this.labelOldMid3.Size = new System.Drawing.Size(58, 16);
            this.labelOldMid3.TabIndex = 43;
            this.labelOldMid3.Text = "N/A";
            // 
            // labelDelta3
            // 
            this.labelDelta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDelta3.Location = new System.Drawing.Point(507, 194);
            this.labelDelta3.Name = "labelDelta3";
            this.labelDelta3.Size = new System.Drawing.Size(80, 16);
            this.labelDelta3.TabIndex = 45;
            this.labelDelta3.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDelta);
            this.groupBox1.Controls.Add(this.buttonRefreshStatistics);
            this.groupBox1.Controls.Add(this.labelTickerTradesStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Controls.Add(this.labelBidAskAverage);
            this.groupBox1.Controls.Add(this.labelTradePermission);
            this.groupBox1.Controls.Add(this.labelEstimationResult2);
            this.groupBox1.Controls.Add(this.labelEstimationResult);
            this.groupBox1.Controls.Add(this.buttonTest);
            this.groupBox1.Controls.Add(this.buttonFocus);
            this.groupBox1.Controls.Add(this.labelDelta3);
            this.groupBox1.Controls.Add(this.labelTicker);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.listViewTrades);
            this.groupBox1.Controls.Add(this.labelTotalAskAmount);
            this.groupBox1.Controls.Add(this.labelOldMid3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelTotalBidAmount);
            this.groupBox1.Controls.Add(this.labelTotalAskOrders);
            this.groupBox1.Controls.Add(this.labelOldMid2);
            this.groupBox1.Controls.Add(this.labelDelta2);
            this.groupBox1.Controls.Add(this.labelBidAVG);
            this.groupBox1.Controls.Add(this.labelTotalAskValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelAskAVG);
            this.groupBox1.Controls.Add(this.labelTotalBidOrders);
            this.groupBox1.Controls.Add(this.labelTotalBidValue);
            this.groupBox1.Controls.Add(this.labelNewMid);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.labelOldMid);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 224);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // labelTickerTradesStatus
            // 
            this.labelTickerTradesStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTickerTradesStatus.Location = new System.Drawing.Point(79, 0);
            this.labelTickerTradesStatus.Name = "labelTickerTradesStatus";
            this.labelTickerTradesStatus.Size = new System.Drawing.Size(601, 16);
            this.labelTickerTradesStatus.TabIndex = 82;
            this.labelTickerTradesStatus.Text = "N/A";
            this.labelTickerTradesStatus.TextChanged += new System.EventHandler(this.labelTickerTradesStatus_TextChanged);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(360, 150);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(81, 13);
            this.label50.TabIndex = 52;
            this.label50.Text = "AVG(Bids,Asks)";
            // 
            // labelBidAskAverage
            // 
            this.labelBidAskAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBidAskAverage.Location = new System.Drawing.Point(359, 164);
            this.labelBidAskAverage.Name = "labelBidAskAverage";
            this.labelBidAskAverage.Size = new System.Drawing.Size(88, 16);
            this.labelBidAskAverage.TabIndex = 51;
            this.labelBidAskAverage.Text = "N/A";
            // 
            // labelTradePermission
            // 
            this.labelTradePermission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTradePermission.Location = new System.Drawing.Point(627, 180);
            this.labelTradePermission.Name = "labelTradePermission";
            this.labelTradePermission.Size = new System.Drawing.Size(55, 16);
            this.labelTradePermission.TabIndex = 49;
            this.labelTradePermission.Text = "N/A";
            // 
            // labelEstimationResult2
            // 
            this.labelEstimationResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEstimationResult2.Location = new System.Drawing.Point(586, 188);
            this.labelEstimationResult2.Name = "labelEstimationResult2";
            this.labelEstimationResult2.Size = new System.Drawing.Size(42, 16);
            this.labelEstimationResult2.TabIndex = 47;
            this.labelEstimationResult2.Text = "N/A";
            // 
            // labelEstimationResult
            // 
            this.labelEstimationResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEstimationResult.Location = new System.Drawing.Point(586, 173);
            this.labelEstimationResult.Name = "labelEstimationResult";
            this.labelEstimationResult.Size = new System.Drawing.Size(42, 16);
            this.labelEstimationResult.TabIndex = 46;
            this.labelEstimationResult.Text = "N/A";
            // 
            // buttonFocus
            // 
            this.buttonFocus.Location = new System.Drawing.Point(60, -66);
            this.buttonFocus.Name = "buttonFocus";
            this.buttonFocus.Size = new System.Drawing.Size(75, 23);
            this.buttonFocus.TabIndex = 0;
            this.buttonFocus.Text = "buttonFocus";
            this.buttonFocus.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Bids (Price to buy):";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(589, 159);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(37, 13);
            this.label40.TabIndex = 48;
            this.label40.Text = "Result";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(627, 166);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(57, 13);
            this.label42.TabIndex = 50;
            this.label42.Text = "Permission";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(4, 173);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(96, 13);
            this.label48.TabIndex = 40;
            this.label48.Text = "Asks (Price to sell):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Currency Pair:";
            // 
            // comboBoxActivePair
            // 
            this.comboBoxActivePair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActivePair.FormattingEnabled = true;
            this.comboBoxActivePair.Items.AddRange(new object[] {
            "btceur",
            "btcusd",
            "eurusd",
            "ftcbtc",
            "ltcbtc",
            "ltceur",
            "ltcrur",
            "ltcusd"});
            this.comboBoxActivePair.Location = new System.Drawing.Point(80, 6);
            this.comboBoxActivePair.Name = "comboBoxActivePair";
            this.comboBoxActivePair.Size = new System.Drawing.Size(82, 21);
            this.comboBoxActivePair.Sorted = true;
            this.comboBoxActivePair.TabIndex = 96;
            this.comboBoxActivePair.SelectedIndexChanged += new System.EventHandler(this.comboBoxActivePair_SelectedIndexChanged);
            // 
            // listViewOrders
            // 
            this.listViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.GridLines = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(555, 416);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(471, 128);
            this.listViewOrders.TabIndex = 31;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.SelectedIndexChanged += new System.EventHandler(this.listViewOrders_SelectedIndexChanged);
            // 
            // numericUpDownCancelBuyOrderTimeout
            // 
            this.numericUpDownCancelBuyOrderTimeout.Location = new System.Drawing.Point(150, 492);
            this.numericUpDownCancelBuyOrderTimeout.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCancelBuyOrderTimeout.Name = "numericUpDownCancelBuyOrderTimeout";
            this.numericUpDownCancelBuyOrderTimeout.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownCancelBuyOrderTimeout.TabIndex = 28;
            this.numericUpDownCancelBuyOrderTimeout.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownCancelBuyOrderTimeout.ValueChanged += new System.EventHandler(this.numericUpDownCancelBuyOrderTimeout_ValueChanged);
            // 
            // checkBoxCancelBuyOrders
            // 
            this.checkBoxCancelBuyOrders.AutoSize = true;
            this.checkBoxCancelBuyOrders.Location = new System.Drawing.Point(12, 493);
            this.checkBoxCancelBuyOrders.Name = "checkBoxCancelBuyOrders";
            this.checkBoxCancelBuyOrders.Size = new System.Drawing.Size(142, 17);
            this.checkBoxCancelBuyOrders.TabIndex = 27;
            this.checkBoxCancelBuyOrders.Text = "Cancel Buy Orders After:";
            this.checkBoxCancelBuyOrders.UseVisualStyleBackColor = true;
            this.checkBoxCancelBuyOrders.CheckedChanged += new System.EventHandler(this.checkBoxCancelBuyOrders_CheckedChanged);
            // 
            // checkBoxCancelSellOrders
            // 
            this.checkBoxCancelSellOrders.AutoSize = true;
            this.checkBoxCancelSellOrders.Location = new System.Drawing.Point(12, 512);
            this.checkBoxCancelSellOrders.Name = "checkBoxCancelSellOrders";
            this.checkBoxCancelSellOrders.Size = new System.Drawing.Size(141, 17);
            this.checkBoxCancelSellOrders.TabIndex = 29;
            this.checkBoxCancelSellOrders.Text = "Cancel Sell Orders After:";
            this.checkBoxCancelSellOrders.UseVisualStyleBackColor = true;
            this.checkBoxCancelSellOrders.CheckedChanged += new System.EventHandler(this.checkBoxCancelSellOrders_CheckedChanged);
            // 
            // numericUpDownCancelSellOrderTimeout
            // 
            this.numericUpDownCancelSellOrderTimeout.Location = new System.Drawing.Point(150, 511);
            this.numericUpDownCancelSellOrderTimeout.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCancelSellOrderTimeout.Name = "numericUpDownCancelSellOrderTimeout";
            this.numericUpDownCancelSellOrderTimeout.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownCancelSellOrderTimeout.TabIndex = 30;
            this.numericUpDownCancelSellOrderTimeout.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownCancelSellOrderTimeout.ValueChanged += new System.EventHandler(this.numericUpDownCancelSellOrderTimeout_ValueChanged);
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelOrder.Location = new System.Drawing.Point(555, 546);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(132, 23);
            this.buttonCancelOrder.TabIndex = 32;
            this.buttonCancelOrder.Text = "Cancel Selected Order";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonCancelOrder_Click);
            // 
            // checkBoxAutoTrade
            // 
            this.checkBoxAutoTrade.AutoSize = true;
            this.checkBoxAutoTrade.Location = new System.Drawing.Point(18, 290);
            this.checkBoxAutoTrade.Name = "checkBoxAutoTrade";
            this.checkBoxAutoTrade.Size = new System.Drawing.Size(79, 17);
            this.checkBoxAutoTrade.TabIndex = 2;
            this.checkBoxAutoTrade.Text = "Auto Trade";
            this.checkBoxAutoTrade.UseVisualStyleBackColor = true;
            this.checkBoxAutoTrade.CheckedChanged += new System.EventHandler(this.checkBoxAutoTrade_CheckedChanged);
            // 
            // groupBoxManualTrade
            // 
            this.groupBoxManualTrade.Controls.Add(this.comboBoxManualSellCurrency);
            this.groupBoxManualTrade.Controls.Add(this.comboBoxManualBuyCurrency);
            this.groupBoxManualTrade.Controls.Add(this.comboBoxManualSellAmount);
            this.groupBoxManualTrade.Controls.Add(this.comboBoxManualBuyAmount);
            this.groupBoxManualTrade.Controls.Add(this.buttonSetSellPrice);
            this.groupBoxManualTrade.Controls.Add(this.buttonBuyPrice);
            this.groupBoxManualTrade.Controls.Add(this.labelManualSellTotalAmount);
            this.groupBoxManualTrade.Controls.Add(this.labelManualBuyTotalAmount);
            this.groupBoxManualTrade.Controls.Add(this.labelManualSellResult);
            this.groupBoxManualTrade.Controls.Add(this.label7);
            this.groupBoxManualTrade.Controls.Add(this.labelManualBuyResult);
            this.groupBoxManualTrade.Controls.Add(this.buttonManualSell);
            this.groupBoxManualTrade.Controls.Add(this.buttonManualBuy);
            this.groupBoxManualTrade.Controls.Add(this.textBoxManualSellRate);
            this.groupBoxManualTrade.Controls.Add(this.textBoxManualBuyRate);
            this.groupBoxManualTrade.Controls.Add(this.label16);
            this.groupBoxManualTrade.Controls.Add(this.label38);
            this.groupBoxManualTrade.Controls.Add(this.label47);
            this.groupBoxManualTrade.Controls.Add(this.labelManualSellTitle);
            this.groupBoxManualTrade.Controls.Add(this.labelManualBuyTitle);
            this.groupBoxManualTrade.Location = new System.Drawing.Point(12, 394);
            this.groupBoxManualTrade.Name = "groupBoxManualTrade";
            this.groupBoxManualTrade.Size = new System.Drawing.Size(537, 80);
            this.groupBoxManualTrade.TabIndex = 4;
            this.groupBoxManualTrade.TabStop = false;
            this.groupBoxManualTrade.Text = "Manual Trade";
            // 
            // comboBoxManualSellCurrency
            // 
            this.comboBoxManualSellCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManualSellCurrency.FormattingEnabled = true;
            this.comboBoxManualSellCurrency.Items.AddRange(new object[] {
            "USC",
            "BTC"});
            this.comboBoxManualSellCurrency.Location = new System.Drawing.Point(114, 49);
            this.comboBoxManualSellCurrency.Name = "comboBoxManualSellCurrency";
            this.comboBoxManualSellCurrency.Size = new System.Drawing.Size(56, 21);
            this.comboBoxManualSellCurrency.TabIndex = 6;
            this.comboBoxManualSellCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxManualSellCurrency_SelectedIndexChanged);
            // 
            // comboBoxManualBuyCurrency
            // 
            this.comboBoxManualBuyCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManualBuyCurrency.FormattingEnabled = true;
            this.comboBoxManualBuyCurrency.Items.AddRange(new object[] {
            "USC",
            "BTC"});
            this.comboBoxManualBuyCurrency.Location = new System.Drawing.Point(114, 29);
            this.comboBoxManualBuyCurrency.Name = "comboBoxManualBuyCurrency";
            this.comboBoxManualBuyCurrency.Size = new System.Drawing.Size(56, 21);
            this.comboBoxManualBuyCurrency.TabIndex = 1;
            this.comboBoxManualBuyCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxManualBuyCurrency_SelectedIndexChanged);
            // 
            // comboBoxManualSellAmount
            // 
            this.comboBoxManualSellAmount.FormattingEnabled = true;
            this.comboBoxManualSellAmount.Items.AddRange(new object[] {
            "0.0104",
            "0.1",
            "ALL"});
            this.comboBoxManualSellAmount.Location = new System.Drawing.Point(56, 49);
            this.comboBoxManualSellAmount.Name = "comboBoxManualSellAmount";
            this.comboBoxManualSellAmount.Size = new System.Drawing.Size(58, 21);
            this.comboBoxManualSellAmount.TabIndex = 5;
            this.comboBoxManualSellAmount.Text = "0.0104";
            this.comboBoxManualSellAmount.TextChanged += new System.EventHandler(this.comboBoxManualSellAmount_TextChanged);
            // 
            // comboBoxManualBuyAmount
            // 
            this.comboBoxManualBuyAmount.FormattingEnabled = true;
            this.comboBoxManualBuyAmount.Items.AddRange(new object[] {
            "0.0104",
            "0.1",
            "ALL"});
            this.comboBoxManualBuyAmount.Location = new System.Drawing.Point(56, 29);
            this.comboBoxManualBuyAmount.Name = "comboBoxManualBuyAmount";
            this.comboBoxManualBuyAmount.Size = new System.Drawing.Size(58, 21);
            this.comboBoxManualBuyAmount.TabIndex = 0;
            this.comboBoxManualBuyAmount.Text = "0.0104";
            this.comboBoxManualBuyAmount.TextChanged += new System.EventHandler(this.comboBoxManualBuyAmount_TextChanged);
            // 
            // buttonSetSellPrice
            // 
            this.buttonSetSellPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetSellPrice.Location = new System.Drawing.Point(249, 49);
            this.buttonSetSellPrice.Name = "buttonSetSellPrice";
            this.buttonSetSellPrice.Size = new System.Drawing.Size(38, 21);
            this.buttonSetSellPrice.TabIndex = 8;
            this.buttonSetSellPrice.Text = "Set";
            this.buttonSetSellPrice.UseVisualStyleBackColor = true;
            this.buttonSetSellPrice.Click += new System.EventHandler(this.buttonSetSellPrice_Click);
            // 
            // buttonBuyPrice
            // 
            this.buttonBuyPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuyPrice.Location = new System.Drawing.Point(249, 29);
            this.buttonBuyPrice.Name = "buttonBuyPrice";
            this.buttonBuyPrice.Size = new System.Drawing.Size(38, 21);
            this.buttonBuyPrice.TabIndex = 3;
            this.buttonBuyPrice.Text = "Set";
            this.buttonBuyPrice.UseVisualStyleBackColor = true;
            this.buttonBuyPrice.Click += new System.EventHandler(this.buttonBuyPrice_Click);
            // 
            // labelManualSellTotalAmount
            // 
            this.labelManualSellTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelManualSellTotalAmount.Location = new System.Drawing.Point(290, 49);
            this.labelManualSellTotalAmount.Name = "labelManualSellTotalAmount";
            this.labelManualSellTotalAmount.Size = new System.Drawing.Size(110, 21);
            this.labelManualSellTotalAmount.TabIndex = 61;
            this.labelManualSellTotalAmount.Text = "N/A";
            this.labelManualSellTotalAmount.TextChanged += new System.EventHandler(this.labelSellTotalAmount_TextChanged);
            // 
            // labelManualBuyTotalAmount
            // 
            this.labelManualBuyTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelManualBuyTotalAmount.Location = new System.Drawing.Point(290, 29);
            this.labelManualBuyTotalAmount.Name = "labelManualBuyTotalAmount";
            this.labelManualBuyTotalAmount.Size = new System.Drawing.Size(110, 21);
            this.labelManualBuyTotalAmount.TabIndex = 60;
            this.labelManualBuyTotalAmount.Text = "N/A";
            this.labelManualBuyTotalAmount.TextChanged += new System.EventHandler(this.labelBuyTotalAmount_TextChanged);
            // 
            // labelManualSellResult
            // 
            this.labelManualSellResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelManualSellResult.Location = new System.Drawing.Point(444, 49);
            this.labelManualSellResult.Name = "labelManualSellResult";
            this.labelManualSellResult.Size = new System.Drawing.Size(87, 21);
            this.labelManualSellResult.TabIndex = 26;
            this.labelManualSellResult.Text = "N/A";
            this.labelManualSellResult.TextChanged += new System.EventHandler(this.labelManualSellResult_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Amount";
            // 
            // labelManualBuyResult
            // 
            this.labelManualBuyResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelManualBuyResult.Location = new System.Drawing.Point(444, 29);
            this.labelManualBuyResult.Name = "labelManualBuyResult";
            this.labelManualBuyResult.Size = new System.Drawing.Size(87, 21);
            this.labelManualBuyResult.TabIndex = 52;
            this.labelManualBuyResult.Text = "N/A";
            this.labelManualBuyResult.TextChanged += new System.EventHandler(this.labelManualBuyResult_TextChanged);
            // 
            // buttonManualSell
            // 
            this.buttonManualSell.Location = new System.Drawing.Point(402, 50);
            this.buttonManualSell.Name = "buttonManualSell";
            this.buttonManualSell.Size = new System.Drawing.Size(42, 21);
            this.buttonManualSell.TabIndex = 9;
            this.buttonManualSell.Text = "Sell";
            this.buttonManualSell.UseVisualStyleBackColor = true;
            this.buttonManualSell.Click += new System.EventHandler(this.buttonManualSell_Click);
            // 
            // buttonManualBuy
            // 
            this.buttonManualBuy.Location = new System.Drawing.Point(402, 28);
            this.buttonManualBuy.Name = "buttonManualBuy";
            this.buttonManualBuy.Size = new System.Drawing.Size(42, 21);
            this.buttonManualBuy.TabIndex = 4;
            this.buttonManualBuy.Text = "Buy";
            this.buttonManualBuy.UseVisualStyleBackColor = true;
            this.buttonManualBuy.Click += new System.EventHandler(this.buttonManualBuy_Click);
            // 
            // textBoxManualSellRate
            // 
            this.textBoxManualSellRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxManualSellRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxManualSellRate.Location = new System.Drawing.Point(173, 49);
            this.textBoxManualSellRate.Name = "textBoxManualSellRate";
            this.textBoxManualSellRate.Size = new System.Drawing.Size(77, 21);
            this.textBoxManualSellRate.TabIndex = 7;
            this.textBoxManualSellRate.TextChanged += new System.EventHandler(this.textBoxManualSellRate_TextChanged);
            // 
            // textBoxManualBuyRate
            // 
            this.textBoxManualBuyRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxManualBuyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxManualBuyRate.Location = new System.Drawing.Point(173, 29);
            this.textBoxManualBuyRate.Name = "textBoxManualBuyRate";
            this.textBoxManualBuyRate.Size = new System.Drawing.Size(77, 21);
            this.textBoxManualBuyRate.TabIndex = 2;
            this.textBoxManualBuyRate.TextChanged += new System.EventHandler(this.textBoxManualBuyRate_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(195, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Rate";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(306, 15);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(81, 13);
            this.label38.TabIndex = 63;
            this.label38.Text = "What You\'ll Get";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(448, 16);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(37, 13);
            this.label47.TabIndex = 53;
            this.label47.Text = "Result";
            // 
            // labelManualSellTitle
            // 
            this.labelManualSellTitle.AutoSize = true;
            this.labelManualSellTitle.Location = new System.Drawing.Point(2, 51);
            this.labelManualSellTitle.Name = "labelManualSellTitle";
            this.labelManualSellTitle.Size = new System.Drawing.Size(27, 13);
            this.labelManualSellTitle.TabIndex = 27;
            this.labelManualSellTitle.Text = "Sell:";
            // 
            // labelManualBuyTitle
            // 
            this.labelManualBuyTitle.AutoSize = true;
            this.labelManualBuyTitle.Location = new System.Drawing.Point(2, 32);
            this.labelManualBuyTitle.Name = "labelManualBuyTitle";
            this.labelManualBuyTitle.Size = new System.Drawing.Size(52, 13);
            this.labelManualBuyTitle.TabIndex = 47;
            this.labelManualBuyTitle.Text = "Buy BTC:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(796, 551);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(76, 13);
            this.label46.TabIndex = 74;
            this.label46.Text = "Cancel Result:";
            // 
            // labelActiveOrdersStatus
            // 
            this.labelActiveOrdersStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelActiveOrdersStatus.Location = new System.Drawing.Point(661, 398);
            this.labelActiveOrdersStatus.Name = "labelActiveOrdersStatus";
            this.labelActiveOrdersStatus.Size = new System.Drawing.Size(365, 16);
            this.labelActiveOrdersStatus.TabIndex = 75;
            this.labelActiveOrdersStatus.Text = "N/A";
            this.labelActiveOrdersStatus.TextChanged += new System.EventHandler(this.labelActiveOrdersStatus_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(581, 399);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "Active Orders:";
            // 
            // labelCancelledBuysCount
            // 
            this.labelCancelledBuysCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCancelledBuysCount.Location = new System.Drawing.Point(203, 492);
            this.labelCancelledBuysCount.Name = "labelCancelledBuysCount";
            this.labelCancelledBuysCount.Size = new System.Drawing.Size(32, 20);
            this.labelCancelledBuysCount.TabIndex = 81;
            this.labelCancelledBuysCount.Text = "N/A";
            // 
            // labelCancelledSellsCount
            // 
            this.labelCancelledSellsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCancelledSellsCount.Location = new System.Drawing.Point(203, 511);
            this.labelCancelledSellsCount.Name = "labelCancelledSellsCount";
            this.labelCancelledSellsCount.Size = new System.Drawing.Size(32, 20);
            this.labelCancelledSellsCount.TabIndex = 82;
            this.labelCancelledSellsCount.Text = "N/A";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(202, 477);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(35, 13);
            this.label54.TabIndex = 83;
            this.label54.Text = "Count";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(153, 477);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(44, 13);
            this.label55.TabIndex = 84;
            this.label55.Text = "Second";
            // 
            // textBoxCancellBuyResult
            // 
            this.textBoxCancellBuyResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCancellBuyResult.Location = new System.Drawing.Point(234, 492);
            this.textBoxCancellBuyResult.Name = "textBoxCancellBuyResult";
            this.textBoxCancellBuyResult.ReadOnly = true;
            this.textBoxCancellBuyResult.Size = new System.Drawing.Size(309, 20);
            this.textBoxCancellBuyResult.TabIndex = 98;
            this.textBoxCancellBuyResult.Text = "N/A";
            // 
            // textBoxCancelSellResult
            // 
            this.textBoxCancelSellResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCancelSellResult.Location = new System.Drawing.Point(234, 511);
            this.textBoxCancelSellResult.Name = "textBoxCancelSellResult";
            this.textBoxCancelSellResult.ReadOnly = true;
            this.textBoxCancelSellResult.Size = new System.Drawing.Size(309, 20);
            this.textBoxCancelSellResult.TabIndex = 99;
            this.textBoxCancelSellResult.Text = "N/A";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(302, 477);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(37, 13);
            this.label52.TabIndex = 97;
            this.label52.Text = "Result";
            // 
            // label57
            // 
            this.label57.BackColor = System.Drawing.Color.Gray;
            this.label57.Location = new System.Drawing.Point(-3, 55);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(2000, 1);
            this.label57.TabIndex = 104;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDownAmountRound);
            this.panel1.Controls.Add(this.numericUpDownInterval);
            this.panel1.Controls.Add(this.comboBoxActivePair);
            this.panel1.Controls.Add(this.numericUpDownRateRound);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label56);
            this.panel1.Controls.Add(this.label53);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 32);
            this.panel1.TabIndex = 100;
            // 
            // textBoxCancelOrderResult
            // 
            this.textBoxCancelOrderResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCancelOrderResult.Location = new System.Drawing.Point(874, 548);
            this.textBoxCancelOrderResult.Name = "textBoxCancelOrderResult";
            this.textBoxCancelOrderResult.ReadOnly = true;
            this.textBoxCancelOrderResult.Size = new System.Drawing.Size(154, 20);
            this.textBoxCancelOrderResult.TabIndex = 100;
            this.textBoxCancelOrderResult.Text = "N/A";
            this.textBoxCancelOrderResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonCancelAllOrders
            // 
            this.buttonCancelAllOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelAllOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelAllOrders.Location = new System.Drawing.Point(690, 546);
            this.buttonCancelAllOrders.Name = "buttonCancelAllOrders";
            this.buttonCancelAllOrders.Size = new System.Drawing.Size(104, 23);
            this.buttonCancelAllOrders.TabIndex = 105;
            this.buttonCancelAllOrders.Text = "Cancel All Orders";
            this.buttonCancelAllOrders.UseVisualStyleBackColor = true;
            this.buttonCancelAllOrders.Click += new System.EventHandler(this.buttonCancelAllOrders_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Location = new System.Drawing.Point(234, 544);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(309, 21);
            this.Withdraw.TabIndex = 106;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(10, 550);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(73, 13);
            this.label45.TabIndex = 108;
            this.label45.Text = "BTC Amount :";
            // 
            // txtbitcoin
            // 
            this.txtbitcoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbitcoin.Location = new System.Drawing.Point(89, 545);
            this.txtbitcoin.Name = "txtbitcoin";
            this.txtbitcoin.Size = new System.Drawing.Size(135, 20);
            this.txtbitcoin.TabIndex = 109;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(1081, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 110;
            // 
            // deleteDatabaseToolStripMenuItem
            // 
            this.deleteDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daysToolStripMenuItem,
            this.monthToolStripMenuItem,
            this.monthsToolStripMenuItem});
            this.deleteDatabaseToolStripMenuItem.Name = "deleteDatabaseToolStripMenuItem";
            this.deleteDatabaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteDatabaseToolStripMenuItem.Text = "Delete Database";
            // 
            // daysToolStripMenuItem
            // 
            this.daysToolStripMenuItem.Name = "daysToolStripMenuItem";
            this.daysToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.daysToolStripMenuItem.Text = "10 days";
            this.daysToolStripMenuItem.Click += new System.EventHandler(this.daysToolStripMenuItem_Click);
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthToolStripMenuItem.Text = "1 month";
            this.monthToolStripMenuItem.Click += new System.EventHandler(this.monthToolStripMenuItem_Click);
            // 
            // monthsToolStripMenuItem
            // 
            this.monthsToolStripMenuItem.Name = "monthsToolStripMenuItem";
            this.monthsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthsToolStripMenuItem.Text = "2 months";
            this.monthsToolStripMenuItem.Click += new System.EventHandler(this.monthsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 596);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtbitcoin);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.buttonCancelAllOrders);
            this.Controls.Add(this.textBoxCancelOrderResult);
            this.Controls.Add(this.pictureBoxDonate2);
            this.Controls.Add(this.groupBoxApiInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.textBoxCancellBuyResult);
            this.Controls.Add(this.textBoxCancelSellResult);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.labelCancelledBuysCount);
            this.Controls.Add(this.labelCancelledSellsCount);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.checkBoxAutoTrade);
            this.Controls.Add(this.groupBoxAutoTrade);
            this.Controls.Add(this.buttonRefreshActiveOrders);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelActiveOrdersStatus);
            this.Controls.Add(this.numericUpDownCancelBuyOrderTimeout);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.groupBoxManualTrade);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.numericUpDownCancelSellOrderTimeout);
            this.Controls.Add(this.checkBoxCancelSellOrders);
            this.Controls.Add(this.checkBoxCancelBuyOrders);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitstamp Trade Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRateRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxAutoTrade.ResumeLayout(false);
            this.groupBoxAutoTrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimitSellOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimitBuyOrders)).EndInit();
            this.groupBoxApiInfo.ResumeLayout(false);
            this.groupBoxApiInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCancelBuyOrderTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCancelSellOrderTimeout)).EndInit();
            this.groupBoxManualTrade.ResumeLayout(false);
            this.groupBoxManualTrade.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerRefreshGlobal;
        private System.Windows.Forms.CheckBox checkBoxAllowBuy;
        private System.Windows.Forms.CheckBox checkBoxAllowSell;
        private System.Windows.Forms.Label labelBuyCount;
        private System.Windows.Forms.Label labelSellCount;
        private System.Windows.Forms.TextBox textBoxBuyThreshold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSellPriceDelta;
        private System.Windows.Forms.Label labelBuyPriceDelta;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSellThreshold;
        private System.Windows.Forms.Label labelBuyNote;
        private System.Windows.Forms.Label labelSellNote;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBoxAPISecret;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxAPIKey;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStartStop;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLastCheck;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFee;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLastBought;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLastSold;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.GroupBox groupBoxAutoTrade;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxApiInfo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxFundTRC;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxFundNVC;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxFundNMC;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxFundLTC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxFundUSD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFundBTC;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxFundFTC;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxFundPPC;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxFundEUR;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxFundRUR;
        private System.Windows.Forms.ToolStripMenuItem connectionModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTTPRequestToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxInfoServerTime;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBoxInfoTransactionCount;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxInfoOpenOrders;
        private System.Windows.Forms.CheckBox checkBoxRightTrade;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox checkBoxRightInfo;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label labelTotalAskAmount;
        private System.Windows.Forms.Label labelTotalAskOrders;
        private System.Windows.Forms.Label labelTotalAskValue;
        private System.Windows.Forms.Label labelAskAVG;
        private System.Windows.Forms.Label labelTotalBidAmount;
        private System.Windows.Forms.Label labelTotalBidOrders;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label labelTotalBidValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBidAVG;
        private System.Windows.Forms.Label labelOldMid2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDelta;
        private System.Windows.Forms.Label labelOldMid;
        private System.Windows.Forms.ListView listViewTrades;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelNewMid;
        private System.Windows.Forms.Label labelTicker;
        private System.Windows.Forms.Label labelDelta2;
        private System.Windows.Forms.Label labelOldMid3;
        private System.Windows.Forms.Label labelDelta3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.NumericUpDown numericUpDownLimitSellOrders;
        private System.Windows.Forms.NumericUpDown numericUpDownLimitBuyOrders;
        private System.Windows.Forms.NumericUpDown numericUpDownCancelBuyOrderTimeout;
        private System.Windows.Forms.CheckBox checkBoxCancelBuyOrders;
        private System.Windows.Forms.CheckBox checkBoxCancelSellOrders;
        private System.Windows.Forms.NumericUpDown numericUpDownCancelSellOrderTimeout;
        private System.Windows.Forms.CheckBox checkBoxLimitSellOrders;
        private System.Windows.Forms.CheckBox checkBoxLimitBuyOrders;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.CheckBox checkBoxAutoTrade;
        private System.Windows.Forms.GroupBox groupBoxManualTrade;
        private System.Windows.Forms.TextBox textBoxManualSellRate;
        private System.Windows.Forms.Button buttonManualBuy;
        private System.Windows.Forms.Button buttonManualSell;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxManualBuyRate;
        private System.Windows.Forms.Label labelManualBuyTitle;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label labelManualBuyResult;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label labelActiveOrdersStatus;
        private System.Windows.Forms.ToolStripMenuItem engineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.Button buttonFocus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonSetSellPrice;
        private System.Windows.Forms.Button buttonBuyPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label labelEstimationResult2;
        private System.Windows.Forms.Label labelEstimationResult;
        private System.Windows.Forms.Button buttonRefreshActiveOrders;
        private System.Windows.Forms.Label labelManualSellTotalAmount;
        private System.Windows.Forms.Label labelManualBuyTotalAmount;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label labelTradePermission;
        private System.Windows.Forms.LinkLabel linkLabelDoation;
        private System.Windows.Forms.PictureBox pictureBoxDonate;
        private System.Windows.Forms.Button buttonRefreshInfo;
        private System.Windows.Forms.Label labelManualSellTitle;
        private System.Windows.Forms.PictureBox pictureBoxDonate2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelManualSellResult;
        private System.Windows.Forms.TextBox textBoxBuyFee;
        private System.Windows.Forms.TextBox textBoxSellFee;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBoxBuyProfit;
        private System.Windows.Forms.TextBox textBoxSellProfit;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBoxBTCEBuyPrice;
        private System.Windows.Forms.TextBox textBoxBTCESellPrice;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBoxCalcBuyPrice;
        private System.Windows.Forms.TextBox textBoxCalcSellPrice;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.CheckBox checkBoxConsiderFeeInSell;
        private System.Windows.Forms.CheckBox checkBoxConsiderFeeInBuy;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label labelBidAskAverage;
        private System.Windows.Forms.ComboBox comboBoxSellCondition;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ComboBox comboBoxBuyCondition;
        private System.Windows.Forms.CheckBox checkBoxUseTrueTruePermission;
        private System.Windows.Forms.TextBox textBoxAutoBuyTotalResult;
        private System.Windows.Forms.TextBox textBoxAutoSellTotalResult;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label labelAPIInfoStatus;
        private System.Windows.Forms.Label labelTickerTradesStatus;
        private System.Windows.Forms.Button buttonRefreshStatistics;
        private System.Windows.Forms.Label labelBuyThresholdValue;
        private System.Windows.Forms.Label labelSellThresholdValue;
        private System.Windows.Forms.Label labelCancelledBuysCount;
        private System.Windows.Forms.Label labelCancelledSellsCount;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBoxCancellBuyResult;
        private System.Windows.Forms.TextBox textBoxCancelSellResult;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label labelThresholdCurrency;
        private System.Windows.Forms.ToolStripMenuItem activePairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxActivePair;
        private System.Windows.Forms.NumericUpDown numericUpDownRateRound;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountRound;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFundXPM;
        private System.Windows.Forms.ComboBox comboBoxAutoBuyAmount;
        private System.Windows.Forms.ComboBox comboBoxAutoSellAmount;
        private System.Windows.Forms.ComboBox comboBoxManualSellAmount;
        private System.Windows.Forms.ComboBox comboBoxManualBuyAmount;
        private System.Windows.Forms.ComboBox comboBoxManualBuyCurrency;
        private System.Windows.Forms.ComboBox comboBoxManualSellCurrency;
        private System.Windows.Forms.ToolStripMenuItem smoothHTTPRequestToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxCancelOrderResult;
        private System.Windows.Forms.Button buttonCancelAllOrders;
        private System.Windows.Forms.ToolStripMenuItem autoCheckForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadLatestVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtbitcoin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem deleteDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthsToolStripMenuItem;
    }
}

