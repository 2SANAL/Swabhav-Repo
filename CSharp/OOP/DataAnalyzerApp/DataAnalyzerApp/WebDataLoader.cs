using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Authentication;

namespace DataAnalyzerApp
{
    class WebDataLoader : IDataLoader
    {
        private string _url;
        private string[] _line;
        private string _html = string.Empty;
        private Dictionary<Employee, Employee> _employeelistDataParser = new Dictionary<Employee, Employee>();

        public WebDataLoader(string url)
        {
            _url = url;
            Loader();
        }

        public void Loader()
        {
            const SslProtocols _Tls12 = (SslProtocols)0x00000C00;
            const SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;
            ServicePointManager.SecurityProtocol = Tls12;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                _html = reader.ReadToEnd();
            }
            _line = _html.Split('\n');

        }
        public string[] lines
        {
            get
            {
                return _line;
            }
        }

    }
}
