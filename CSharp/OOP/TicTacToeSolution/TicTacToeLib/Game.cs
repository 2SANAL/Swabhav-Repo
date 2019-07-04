using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class Game
    {

        private Player[] _player;
        private ResultAnalayzer _analyzer;
        private Results _status;
        private int _switching;
        private Board _board;

        public Game(Player[] player, ResultAnalayzer analyzer, Board board)
        {
            _player = player;
            _analyzer = analyzer;
            _board = board;
        }

        public void Play(int choice)
        {
            if (_switching == 0)
            {
                _board.SetMark(choice, _player[_switching].Mark);
                _switching = 1;
                _status = _analyzer.GetResult();
                return;
            }
            _board.SetMark(choice, _player[_switching].Mark);
            _switching = 0;
            _status = _analyzer.GetResult();
        }

        public Results Status()
        {
            return _status;
        }

        public string PlayerName
        {
            get
            {
                if (_switching == 0)
                {
                    return _player[0].Name;
                }
                return _player[1].Name;

            }
        }
    }
}
