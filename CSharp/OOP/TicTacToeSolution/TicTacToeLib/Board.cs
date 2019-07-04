using System;

namespace TicTacToeLib
{
    public class Board
    {
        private Cell[] _cell = new Cell[9];
        public Board()
        {
           for(int index = 0; index < 9; index++)
            {
                _cell[index] = new Cell();
            }
           
        }

        public void SetMark(int position, Mark mark)
        {
            if (_cell[position].IsAlreadyMarked())
                throw new Exception("Cell Already Marked");
            else
                _cell[position].Mark= mark;
        }

        public Mark GetMark(int position)
        {
            return _cell[position].Mark;
        }

        public bool IsEmplty()
        {
            int count = 0;
            for (int index = 0; index < 9; index++)
            {
                if (_cell[index].Mark.Equals(Mark.EMPTY))
                {
                    count++;
                }
            }
            if (count == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            int count = 0;
            for (int index = 0; index < 9; index++)
            {
                if (_cell[index].Mark.Equals(Mark.X) || _cell[index].Mark.Equals(Mark.O))
                {
                    count++;
                }
            }
            if (count == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Cell[] Cell
        {
            get
            {
                return _cell;
            }

        }
    }
}
