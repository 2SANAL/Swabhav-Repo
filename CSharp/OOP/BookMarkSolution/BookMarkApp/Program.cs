using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookMarkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> links = new Dictionary<string, string>();
            ExportBookMark exportBookMark = new ExportBookMark();

            links.Add("CODING CLUB: Gantt Chart for Preemptive and Non-Preemptive Priority Scheduling ", "http://codingloverlavi.blogspot.com/2014/08/gantt-chart-for-preemptive-and-non.html");
            links.Add("Google", "https://www.google.co.in/");
            exportBookMark.WriteInHtmlPage(links);
          
        }
    }
}
