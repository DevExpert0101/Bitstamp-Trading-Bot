using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Web;

namespace Bitstamp
{
    class SMSSimpleHttpRequest
    {
        public int TimeOut = 10;

        public string GetResponse(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.GetResponse();
            request.Timeout = TimeOut * 1000;

            if (request == null)
                throw new Exception("Non HTTP WebRequest");

            return new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd();
        }

        public string GetResponse(string url, byte[] byteArray, WebHeaderCollection headers)
        {
            var request = WebRequest.Create(new Uri(url)) as HttpWebRequest;
            if (request == null)
                return null; //throw new Exception("Non HTTP WebRequest");

            request.Headers = headers;
            request.Method = "POST";
            request.Timeout = TimeOut * 1000;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            var reqStream = request.GetRequestStream();
            reqStream.Write(byteArray, 0, byteArray.Length);
            reqStream.Close();
            return (new StreamReader(request.GetResponse().GetResponseStream())).ReadToEnd();
        }
    }

    // ==============================================================================================================
    class SMSRequestWebBrowser
    {
        public int TimeOut = 10;
        readonly WebBrowser _browser = new WebBrowser();
        private bool _loading = false;

        public SMSRequestWebBrowser()
        {
            _browser.DocumentCompleted += _browser_DocumentCompleted;
            _browser.NewWindow += _browser_NewWindow;
            _browser.ScriptErrorsSuppressed = false;
            _browser.Visible = false;
        }

        private void _browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            _loading = false;
        }

        private void _browser_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _browser.Navigate(_browser.StatusText, false);
            e.Cancel = true;
        }

        public string GetResponse(string url)
        {
            _loading = true;
            try
            {
                _browser.Navigate(url, false);
            }
            catch (Exception)
            {
                _loading = false;
            }

            var t1 = DateTime.Now;

            while (_loading)
            {
                Application.DoEvents();
                Thread.Sleep(1);

                var t2 = DateTime.Now;
                if ((t2 - t1).TotalSeconds > TimeOut)
                    break;
            }
            var result = _browser.DocumentText;

            _browser.Stop();
            _browser.Dispose();

            return result;
        }

        public string GetResponse(string url, byte[] byteArray, string headers)
        {
            _loading = true;
            _browser.Navigate(url, "", byteArray, headers + "Content-Type: application/x-www-form-urlencoded");

            var t1 = DateTime.Now;

            while (_loading)
            {
                Application.DoEvents();
                Thread.Sleep(1);

                var t2 = DateTime.Now;
                if ((t2 - t1).TotalSeconds > TimeOut)
                    break;
            }

            var result = _browser.DocumentText;

            _browser.Stop();
            _browser.Dispose();

            return result;
        }
    }

    // ==============================================================================================================
    public class SMSRequestSmoothHttpRequest
    {
        public int TimeOut = 10;
        private bool _loading = false;
        private string _result;
        private HttpWebRequest _request;
        private byte[] _byteArray;

        void GetSimpleResponse() //Thread
        {
            try
            {
                _request.GetResponse();
                _result = new StreamReader(_request.GetResponse().GetResponseStream()).ReadToEnd();
            }
            catch (Exception exception)
            {

            }
            _loading = false;
        }

        public string GetResponse(string url)
        {
            //_request = (HttpWebRequest)WebRequest.Create(url);
            //if (_request == null)
            //    return null; //throw new Exception("Non HTTP WebRequest");

            //_request.Timeout = TimeOut * 1000;

            //_loading = true;
            //var thread = new Thread(new ThreadStart(GetSimpleResponse));
            //thread.Start();

            //var t1 = DateTime.Now;
            //while (_loading)
            //{
            //    Application.DoEvents();
            //    Thread.Sleep(1);

            //    var t2 = DateTime.Now;
            //    if ((t2 - t1).TotalSeconds > TimeOut)
            //        break;
            //}
            //thread.Abort();

            //return _result;
            //url = _baseURL + url;
            var request = WebRequest.Create(new Uri(url));
            var response = request.GetResponse();
            using (var resStream = response.GetResponseStream())
            {
                using (var resStreamReader = new StreamReader(resStream))
                {
                    string _result = resStreamReader.ReadToEnd();
                    return _result; 
                }
            }
        }

        void GetPostResponse() //Thread
        {
            try
            {
                var reqStream = _request.GetRequestStream();
                reqStream.Write(_byteArray, 0, _byteArray.Length);
                reqStream.Close();
                _result = (new StreamReader(_request.GetResponse().GetResponseStream())).ReadToEnd();
            }
            catch (Exception exception)
            {

            }
            _loading = false;
        }

        public string GetResponse(string url, byte[] byteArray, WebHeaderCollection headers)
        {
            _byteArray = byteArray;

            _request = (HttpWebRequest)WebRequest.Create(url);
            if (_request == null)
                return null; //throw new Exception("Non HTTP WebRequest");

            _request.Headers = headers;
            _request.Method = "POST";
            _request.Timeout = TimeOut * 1000;
            _request.ContentType = "application/x-www-form-urlencoded";
            _request.ContentLength = byteArray.Length;

            _loading = true;

            using (var reqStream = _request.GetRequestStream())
            {
                reqStream.Write(byteArray, 0, byteArray.Length);
                reqStream.Close();
            }
            var response = _request.GetResponse();
            using (var resStream = response.GetResponseStream())
            {
                using (var resStreamReader = new StreamReader(resStream))
                {
                    string _result = resStreamReader.ReadToEnd();
                    return _result;
                }
            }
        }

        private static string BuildPostData(Dictionary<string, string> dataDic)
        {
            var p = dataDic.Keys.Select(key => String.Format("{0}={1}", key, HttpUtility.UrlEncode(dataDic[key]))).ToArray();
            return string.Join("&", p);
        }
    }
}
