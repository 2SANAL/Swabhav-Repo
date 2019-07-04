using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicTacToeLib;


namespace TicTacToeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Case2();
            //Case1();
        }
        private static void Case2()
        {
            Application.EnableVisualStyles();
            Application.Run(new ConsoleFormApp());
        }

        private static void Case1()
        {
            Player[] player = new Player[2];
            player[0] = new Player("amit", Mark.O);
            player[1] = new Player("shubahm", Mark.X);
            Board board = new Board();
            ResultAnalayzer analyzer = new ResultAnalayzer(board);

            Game game = new Game(player, analyzer, board);

            while (!board.IsFull())
            {
                Console.WriteLine("\nPlayer " + game.PlayerName + " Enter position ");
                int position = Convert.ToInt32(Console.ReadLine());
                game.Play(position);
                BoardDisplay(board);
                if (game.Status() == Results.WIN)
                {
                    Console.WriteLine("Player " + player[0].Name + " wins..");
                    break;
                }
                if (game.Status() == (Results.DRAW))
                {
                    Console.WriteLine("The match is draw");
                    break;
                }
            }
        }

        public static void BoardDisplay(Board board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("\n");
                Console.Write(board.GetMark(i) + "\t");
            }
        }
    }
}