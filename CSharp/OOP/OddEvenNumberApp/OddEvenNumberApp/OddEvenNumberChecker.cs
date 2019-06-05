

namespace OddEvenNumberApp
{


    class OddEvenNumberChecker
    {
        private int[] _evennumberarray = new int[51];
        private int[] _oddnumberarray = new int[51];
        private int _index1 = 0;
        private int _index2 = 0;
        private int number = 0;
        private int _end;
        public OddEvenNumberChecker(int endnumber)
        {
            _end = endnumber;
        }

        public void EvenOddNumberChecker()
        {
            while (number <= _end)
            {
                if (number % 2 == 1)
                {
                    _oddnumberarray[_index1] = number;
                    _index1++;
                }
                if (number % 2 == 0)
                {
                    _evennumberarray[_index2] = number;
                    _index2++;
                }
                number++;
            }
        }
        public int[] GetEvenNumberArray()
        {
            return _evennumberarray;
        }
        public int[] GetOddNumberArray()
        {
            return _oddnumberarray;
        }

    }
}
