using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingLib
{
    public class TransactionData
    {
        private readonly string _name;
        private readonly string _amount;
        private readonly string _type;
        private readonly string _date;

        public TransactionData(object name, object amount, object type, object date)
        {
            _name = Convert.ToString(name);
            _amount = Convert.ToString(amount);
            _type = Convert.ToString(type);
            _date = Convert.ToString(date);
        }

        public string Name
        {
            get
            {
                return _name;

            }
        }
        public string Amount
        {
            get
            {
                return _amount;

            }
        }
        public string Type
        {
            get
            {
                return _type;

            }
        }
        public string Date
        {
            get
            {
                return _date;

            }
        }
    }
}
