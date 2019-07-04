using System;


namespace OcrOcrInViolationFixedDeposit
{
    class FixedDeposit
    {
        private string _name;
        private double _principle;
        private int _year;
        private IRateDiside _festivalType;


        public FixedDeposit(string name, double principle, int year, IRateDiside festivalType)
        {
            _name = name;
            _principle = principle;
            _year = year;
            _festivalType = festivalType;

        }

        public double CalaculateSimpleInterest()
        {


            return ((_principle * _festivalType.GetRate() * _year) / 100);
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
                return _festivalType.GetFestivalName();
            }
        }
    }
}