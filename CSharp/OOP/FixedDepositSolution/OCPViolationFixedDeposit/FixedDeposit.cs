using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPViolationFixedDeposit
{
    class FixedDeposit
    {
        private string _name;
        private double _principle;
        private int _year;
        private FestivalType _festivalType;
        private float _rate;
        private ConverToString _converToString;

        public FixedDeposit(string name, double principle, int year, FestivalType festivalType)
        {
            _name = name;
            _principle = principle;
            _year = year;
            _festivalType = festivalType;
            _converToString = new ConverToString();
        }


        public double CalaculateSimpleInterest()
        {
            if (_festivalType==FestivalType.NEW_YEAR)
            {
                _rate = 0.09f;
            }
            if (_festivalType == FestivalType.NORMAL)
            {
                _rate = 0.07f;
            }
            if (_festivalType == FestivalType.HOLI)
            {
                _rate = 0.08f;
            }
            return ((_principle * _rate * _year) / 100);
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Principle
        {
            get
            {
                return _principle;
            }
        }
        public double Year
        {
            get
            {
                return _year;
            }
        }
        public string FestivalName
        {
            get
            {
                return _converToString.ConvertoString(_festivalType);
            }
        }
    }
}
