using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParseApp
{
    class ControlGroup : IHtml
    {
        private readonly string _tagName;
        private readonly string _id = "";
        private List<IHtml> _childern = new List<IHtml>();

        public ControlGroup(string tagName, string id)
        {
            _tagName = tagName;
            _id = id;
        }
        public ControlGroup(string tagname)
        {
            _tagName = tagname;
            _id = "";
        }
        public void AddTag(IHtml ihtml)
        {
            _childern.Add(ihtml);
        }

        public string ParseToHtml(int space)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string tag;

            if (_id.Equals(""))
            {
                tag = new String(' ', space) + "<" + _tagName + ">";
            }                        
            else
            {
                tag = new String(' ', space) + "<" + _tagName + " id = " + _id + ">";
            }

            stringBuilder.Append(tag);
            foreach (IHtml control in _childern)
            {
                stringBuilder.Append("\n");
                stringBuilder.Append(control.ParseToHtml(space + 3));
            }

            stringBuilder.Append("\n");
            tag = new String(' ', space) + "</" + _tagName + ">";
            stringBuilder.Append(tag);

            return stringBuilder.ToString();
        }

    }

}

