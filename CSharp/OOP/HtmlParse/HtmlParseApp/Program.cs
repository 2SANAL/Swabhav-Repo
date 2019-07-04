using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlGroup div = new ControlGroup("Div");
            Control h1 = new Control("h1", "heading", "Heading tage");
            Control p = new Control("p", "hi Hello");
            Control table = new Control("table", "table 1");
            ControlGroup div1 = new ControlGroup("Div","d1");
            Control button = new Control("input", "Button","submit");

            div.AddTag(h1);
            div.AddTag(p);
            div1.AddTag(h1);
            div1.AddTag(p);
            div.AddTag(div1);
            div.AddTag(table);
            div.AddTag(button);

            Console.WriteLine(div.ParseToHtml(1));

        }
    }
}
