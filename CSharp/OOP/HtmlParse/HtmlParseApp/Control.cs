using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParseApp
{
    class Control : IHtml
    {
        private readonly string _name;
        private readonly string _type;
        private readonly string _description;

        public Control(string name, string type, string description)
        {
            _name = name;
            _type = type;
            _description = description;
        }
        public Control(string name, string description)
        {
            _name = name;
            _type = "";
            _description = description;
        }

        public string ParseToHtml(int space)
        {
            string tag;
            if (_type.Equals(""))
            {
                tag = new String(' ', space) + "<" + _name + ">" + _description + "</" + _name + ">";
            }
            else
            {
                tag = new String(' ', space) + "<" + _name + " type = " + _type + ">" + _description + "</" + _name + ">";
            }

            return tag;
        }
    }
}
