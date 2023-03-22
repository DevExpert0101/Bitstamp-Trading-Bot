namespace BTCETradeBot
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.LinkLabel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.linkLabelDoation = new System.Windows.Forms.LinkLabel();
            this.textBoxDonationAddress = new System.Windows.Forms.TextBox();
            this.pictureBoxDonate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonCopy = new System.Windows.Forms.Button();
            this.pictureBoxDonate2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(678, 94);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(96, 17);
            this.labelProductName.TabIndex = 27;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(621, 123);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 13);
            this.labelVersion.TabIndex = 25;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(621, 136);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(51, 13);
            this.labelCopyright.TabIndex = 28;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(621, 149);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(82, 13);
            this.labelCompanyName.TabIndex = 29;
            this.labelCompanyName.TabStop = true;
            this.labelCompanyName.Text = "Company Name";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCompanyName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelCompanyName_LinkClicked);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxDescription.Location = new System.Drawing.Point(624, 175);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(309, 99);
            this.textBoxDescription.TabIndex = 30;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(484, 281);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 31;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPictureBox.Image = global::BTCETradeBot.Properties.Resources.Stocks_Icon_256;
            this.logoPictureBox.Location = new System.Drawing.Point(9, 94);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(161, 210);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 26;
            this.logoPictureBox.TabStop = false;
            // 
            // linkLabelDoation
            // 
            this.linkLabelDoation.AutoSize = true;
            this.linkLabelDoation.Location = new System.Drawing.Point(203, 154);
            this.linkLabelDoation.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.linkLabelDoation.MaximumSize = new System.Drawing.Size(0, 17);
            this.linkLabelDoation.Name = "linkLabelDoation";
            this.linkLabelDoation.Size = new System.Drawing.Size(42, 13);
            this.linkLabelDoation.TabIndex = 32;
            this.linkLabelDoation.TabStop = true;
            this.linkLabelDoation.Text = "Donate";
            this.linkLabelDoation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.linkLabelDoation, "Donate Now!");
            this.linkLabelDoation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDoation_LinkClicked);
            // 
            // textBoxDonationAddress
            // 
            this.textBoxDonationAddress.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDonationAddress.Location = new System.Drawing.Point(307, 151);
            this.textBoxDonationAddress.Name = "textBoxDonationAddress";
            this.textBoxDonationAddress.ReadOnly = true;
            this.textBoxDonationAddress.Size = new System.Drawing.Size(228, 20);
            this.textBoxDonationAddress.TabIndex = 33;
            this.textBoxDonationAddress.Click += new System.EventHandler(this.textBoxDonationAddress_Click);
            this.textBoxDonationAddress.Enter += new System.EventHandler(this.textBoxDonationAddress_Enter);
            // 
            // pictureBoxDonate
            // 
            this.pictureBoxDonate.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDonate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDonate.Image")));
            this.pictureBoxDonate.Location = new System.Drawing.Point(179, 151);
            this.pictureBoxDonate.Name = "pictureBoxDonate";
            this.pictureBoxDonate.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDonate.TabIndex = 34;
            this.pictureBoxDonate.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxDonate, "Donate Now");
            this.pictureBoxDonate.Click += new System.EventHandler(this.pictureBoxDonate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Address: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label2.MaximumSize = new System.Drawing.Size(0, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Please consider donating some bitcoins if you found this program useful.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackgroundImage = global::BTCETradeBot.Properties.Resources.Copy;
            this.buttonCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCopy.Location = new System.Drawing.Point(537, 149);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(22, 23);
            this.buttonCopy.TabIndex = 37;
            this.toolTip1.SetToolTip(this.buttonCopy, "Copy donation address to clipboard");
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // pictureBoxDonate2
            // 
            this.pictureBoxDonate2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDonate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDonate2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDonate2.Image = global::BTCETradeBot.Properties.Resources.DonateAddress;
            this.pictureBoxDonate2.Location = new System.Drawing.Point(179, 175);
            this.pictureBoxDonate2.Name = "pictureBoxDonate2";
            this.pictureBoxDonate2.Size = new System.Drawing.Size(66, 66);
            this.pictureBoxDonate2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDonate2.TabIndex = 81;
            this.pictureBoxDonate2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxDonate2, "Donate some bitcoins to help the developer!");
            this.pictureBoxDonate2.Click += new System.EventHandler(this.pictureBoxDonate2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label3.MaximumSize = new System.Drawing.Size(0, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "Bitstamp Trading Bot";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAbout
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(582, 312);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxDonate2);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxDonate);
            this.Controls.Add(this.textBoxDonationAddress);
            this.Controls.Add(this.linkLabelDoation);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAbout";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.LinkLabel labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.LinkLabel linkLabelDoation;
        private System.Windows.Forms.TextBox textBoxDonationAddress;
        private System.Windows.Forms.PictureBox pictureBoxDonate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.PictureBox pictureBoxDonate2;
        private System.Windows.Forms.Label label3;

    }
}
