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
        private string[] lines;
        private string html = string.Empty;
        private Dictionary<Employee, Employee> employeelistDataParser = new Dictionary<Employee, Employee>();

        public WebDataLoader(string url)
        {
            _url = url;
        }

        public Dictionary<Employee, Employee> Loader()
        {
            DataParser dataParser = new DataParser();
            const SslProtocols _Tls12 = (SslProtocols)0x00000C00;
            const SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;
            ServicePointManager.SecurityProtocol = Tls12;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            lines = html.Split('\n');
            employeelistDataParser = dataParser.ParseData(lines);
            return employeelistDataParser;


        }
    }
}
