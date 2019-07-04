using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookMarkApp
{
    class ExportBookMark
    {
       
        public  void WriteInHtmlPage(Dictionary<string, string> links)
        {
            using (FileStream fs = new FileStream(@"E:\\SwabhavTech\BookMark.htm", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {

                    w.WriteLine("<H1>Bookmarks</H1>");
                    w.WriteLine("                   ");
                    w.WriteLine("<H3>Bookmarks bar</H3>");

                    foreach (KeyValuePair<string, string> link in links)
                    {
                        w.WriteLine(link.Key + " :<a href >" + link.Value+"\n</a>");
                        w.WriteLine("<br>");

                    }

                }
            }
        }
    }
}
