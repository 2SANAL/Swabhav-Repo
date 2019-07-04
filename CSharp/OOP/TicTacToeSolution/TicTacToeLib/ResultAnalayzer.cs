using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class ResultAnalayzer
    {

        private Board _board;

        public ResultAnalayzer(Board board)
        {
            _board = board;
        }

        public Results GetResult()
        {
            if (_board.IsFull())
                return Results.DRAW;
            if ((_board.GetMark(0) != Mark.EMPTY && _board.GetMark(0) == _board.GetMark(1) 
                  && _board.GetMark(1) == _board.GetMark(2))
                  || _board.GetMark(3) != Mark.EMPTY && _board.GetMark(3) == _board.GetMark(4)
                  && _board.GetMark(4) == _board.GetMark(5)
                  || _board.GetMark(6) != Mark.EMPTY && _board.GetMark(6) == _board.GetMark(7)
                  && _board.GetMark(7) == _board.GetMark(8)
                  || _board.GetMark(0) != Mark.EMPTY && _board.GetMark(0) == _board.GetMark(3)
                  && _board.GetMark(3) == _board.GetMark(6)
                  || _board.GetMark(1) != Mark.EMPTY && _board.GetMark(1) == _board.GetMark(4)
                  && _board.GetMark(4) == _board.GetMark(7)
                  || _board.GetMark(2) != Mark.EMPTY && _board.GetMark(2) == _board.GetMark(5)
                  && _board.GetMark(5) == _board.GetMark(8)
                  || _board.GetMark(0) != Mark.EMPTY && _board.GetMark(0) == _board.GetMark(4)
                  && _board.GetMark(4) == _board.GetMark(8)
                  || _board.GetMark(2) != Mark.EMPTY && _board.GetMark(2) == _board.GetMark(4) 
                  && _board.GetMark(4) == _board.GetMark(6))
                return Results.WIN;
            return Results.PROGRESS;
        }

    }
}
