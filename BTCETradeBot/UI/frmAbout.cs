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

#region

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using BTCETradeBot.Properties;

//using BTCETradeBot.Properties;

#endregion

namespace BTCETradeBot
{
    internal partial class frmAbout : Form
    {
        public static Icon ImageToIcon(Image image)
        {
            return Icon.FromHandle(((Bitmap)image).GetHicon());
        }

        public static Image IconToImage(Icon icon)
        {
            return Image.FromHbitmap(icon.ToBitmap().GetHbitmap());
        }

        public frmAbout()
        {
            InitializeComponent();

            Text = String.Format("About {0}", AssemblyTitle);
            labelProductName.Text = AssemblyTitle;//AssemblyProduct;
            labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription + "\r\n" + @"Copyright (c) 2014 Sayyid Mohammad Saleh Samimi
Donate: " + Business.GetDonationAddress() + @"

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>.";
            this.Icon = ImageToIcon(Resources.Stocks_Icon_256);
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    var titleAttribute = (AssemblyTitleAttribute) attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute) attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute) attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute) attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute) attributes[0]).Company;
            }
        }

        #endregion

        private void labelCompanyName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:mohammadsaleh.samimi@gmail.com");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void linkLabelDoation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DonateNow();
        }

        private void DonateNow()
        {
            Process.Start("bitcoin:" + Business.GetDonationAddress());
        }

        private void textBoxDonationAddress_Enter(object sender, EventArgs e)
        {
            textBoxDonationAddress.SelectionStart = 0;
            textBoxDonationAddress.SelectionLength = textBoxDonationAddress.Text.Length;
        }

        private void textBoxDonationAddress_Click(object sender, EventArgs e)
        {
            textBoxDonationAddress.SelectionStart = 0;
            textBoxDonationAddress.SelectionLength = textBoxDonationAddress.Text.Length;
        }

        private void pictureBoxDonate_Click(object sender, EventArgs e)
        {
            DonateNow();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Business.GetDonationAddress());
        }

        private void pictureBoxDonate2_Click(object sender, EventArgs e)
        {
            Process.Start("bitcoin:" + Business.GetDonationAddress());

        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            textBoxDonationAddress.Text = Business.GetDonationAddress();
        }
    }
}