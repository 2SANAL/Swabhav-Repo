using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class Player
    {
        private string _name;
        private Mark _mark;

        public Player(string name, Mark mark)
        {
            _name = name;
            _mark = mark;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public Mark Mark
        {
            get
            {
                return _mark;
            }
        }
    }
}
