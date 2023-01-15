using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace parse_three
{
    public class GetReqest
    {
        HttpWebRequest _reqest;
        string _adres;

        public Dictionary<string, string> Headers { get; set; }

        public string Response { get; set; }
        public string Accept { get; set; }
        public string UserAgent { get; set; }
        public string Host { get; set; }
        public string Referer { get; set; }
        public WebProxy Proxy { get; set; }

        public GetReqest(string adres)
        {
            _adres = adres;
            Headers = new Dictionary<string, string>();
        }

        public void Run(CookieContainer cookie)
        {
            _reqest = (HttpWebRequest)WebRequest.Create(_adres);
            _reqest.Method = "Get";
            _reqest.CookieContainer = cookie;
            _reqest.Host = Host;
            _reqest.Accept = Accept;
            _reqest.Proxy = Proxy;
            _reqest.UserAgent = UserAgent;
            _reqest.Referer = Referer;

            foreach (var item in Headers)
            {
                _reqest.Headers.Add(item.Key, item.Value);
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)_reqest.GetResponse();
                var stream = response.GetResponseStream();
                if (stream != null) Response = new StreamReader(stream).ReadToEnd();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
