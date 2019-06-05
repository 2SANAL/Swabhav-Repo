using System;


namespace GuesserGameApp
{
    class GuessNumberGame
    {
        private int _appgeneratedrandomnumber;

        public void RandomNumberGenreator()
        {
            Random random = new Random();
            _appgeneratedrandomnumber = random.Next(0, 100);
        }

        public int SystemRandomNumber
        {
            get
            {
                return _appgeneratedrandomnumber;
            }
        }

        public int GuessMatch(int userinput)
        {

            if (userinput < _appgeneratedrandomnumber)
            {
                return 0;
            }
            else if (userinput > _appgeneratedrandomnumber)
            {
                return 1;
            }
            else if (userinput == _appgeneratedrandomnumber)
            {
                return _appgeneratedrandomnumber;
            }

            return -2;
        }


    }
}
