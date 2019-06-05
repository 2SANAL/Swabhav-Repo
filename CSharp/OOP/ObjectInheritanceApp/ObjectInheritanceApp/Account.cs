using System;


namespace AccountApp.Business
{
    class Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        private static int _count;

        static Account()
        {
            Console.WriteLine("static constructu");
            _count = 0;
        }

        public override string ToString()
        {
            return base.ToString()+"\n"+ "Account Number " + Accno + " \nName " + Name + " \nBalane " + Balance;
        }

        public Account()
        {
            Console.WriteLine("NOn stati construcyor");
        }
        public Account(int accno, string name, double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;

        }
        public Account(int accno, string name) : this(accno, name, 500)
        {
        }
        public void deposit(double amt)
        {
            _balance = _balance + amt;

        }
        public void withdrow(double amt)
        {

            if (_balance == 500)
            { }
            else if (_balance - amt <= 500)
            { }
            else
            { _balance = _balance - amt; }
        }
        public int Accno
        {
            get
            {
                return _accno;
            }
            set
            {
                _accno = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
        public int Counter
        {
            get
            {
                return _count;
            }

        }

    }
}
