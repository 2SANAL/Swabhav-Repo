using System;
using System.Collections.Generic;
using TicTacToeLib;
using System.Drawing;
using System.Windows.Forms;
namespace TicTacToeConsole
{
    class   ConsoleFormApp : Form
    {
        private Player[] player = new Player[2];
        private Board board = new Board();
        private Game game;
        private ResultAnalayzer analyzer;
        private static int number = 0;
        private List<Button> listButton = new List<Button>();

        private Label _playerOneNameLabel = new Label();
        private Label _playerTwoNameLabel = new Label();
        private Label _playerOneName = new Label();
        private Label _playerTwoName = new Label();
        private Label _mark = new Label();
        private Label _MarkDisplayLabel = new Label();
        private Label _statusLabel = new Label();
        private Label _gameStatus = new Label();
        private Button _startButton = new Button();
        private Button _restartGame = new Button();

        public ConsoleFormApp()
        {
            Initialize();
            Height = 768;
            Width = 800;

            CreateLabel();
            CreateButton();

            _startButton.Text = "Start";
            _startButton.Location = new Point(341, 175);
            _startButton.ForeColor = Color.Blue;
            _startButton.BackColor = Color.BurlyWood;
            _startButton.Font = new Font(_startButton.Font.FontFamily, 16);
            _startButton.Height = 31;
            _startButton.Width = 100;
            _startButton.Click += _startButton_Click;
            Controls.Add(_startButton);
        }

        private void _startButton_Click(object sender, EventArgs e)
        {
            _startButton = (Button)sender;

            if (_startButton.Text.Equals("Start"))
            {
                Initialize();
                foreach (Button button1 in listButton)
                {
                    _MarkDisplayLabel.Text = player[0].Name;
                    button1.Enabled = true;
                }
                _startButton.Text = "Restart";
            }
           else
            {
                Restart();
                _startButton.Text = "Start";
            }
        }

        private void CreateLabel()
        {
            _playerOneNameLabel.Text = "Player 1 :";
            _playerOneNameLabel.Location = new Point(340, 0);
            _playerOneNameLabel.Height = 20;
            _playerOneNameLabel.Width = 120;
            _playerOneNameLabel.ForeColor = Color.Blue;
            _playerOneNameLabel.Font = new Font(_playerOneNameLabel.Font.FontFamily, 13);

            _playerOneName.Text = "Amit Mark 'O'";
            _playerOneName.Location = new Point(540, 0);
            _playerOneName.ForeColor = Color.Blue;
            _playerOneName.Height = 20;
            _playerOneName.Width = 200;
            _playerOneName.Font = new Font(_playerOneName.Font.FontFamily, 13);

            _playerTwoNameLabel.Text = "Player 2";
            _playerTwoNameLabel.Location = new Point(340, 50);
            _playerTwoNameLabel.ForeColor = Color.Blue;
            _playerTwoNameLabel.Height = 20;
            _playerTwoNameLabel.Width = 120;
            _playerTwoNameLabel.Font = new Font(_playerTwoNameLabel.Font.FontFamily, 13);

            _playerTwoName.Text = "Subham Mark 'X'";
            _playerTwoName.Location = new Point(540, 50);
            _playerTwoName.ForeColor = Color.Blue;
            _playerTwoName.Height = 20;
            _playerTwoName.Width = 200;
            _playerTwoName.Font = new Font(_playerTwoName.Font.FontFamily, 13);

            _mark.Text = "Mark";
            _mark.Location = new Point(340, 100);
            _mark.ForeColor = Color.Blue;
            _mark.Height = 20;
            _mark.Width = 120;
            _mark.Font = new Font(_mark.Font.FontFamily, 13);

            _MarkDisplayLabel.Text = "";
            _MarkDisplayLabel.Location = new Point(540, 100);
            _MarkDisplayLabel.ForeColor = Color.Blue;
            _MarkDisplayLabel.Height = 20;
            _MarkDisplayLabel.Width = 200;
            _MarkDisplayLabel.Font = new Font(_MarkDisplayLabel.Font.FontFamily, 13);

            _statusLabel.Text = "Status";
            _statusLabel.Location = new Point(340, 150);
            _statusLabel.ForeColor = Color.Blue;
            _statusLabel.Height = 20;
            _statusLabel.Width = 120;
            _statusLabel.Font = new Font(_statusLabel.Font.FontFamily, 13);

            _gameStatus.Text = "";
            _gameStatus.Location = new Point(540, 150);
            _gameStatus.ForeColor = Color.Blue;
            _gameStatus.Height = 20;
            _gameStatus.Width = 200;
            _gameStatus.Font = new Font(_gameStatus.Font.FontFamily, 16);

            Controls.Add(_playerOneNameLabel);
            Controls.Add(_playerTwoNameLabel);
            Controls.Add(_playerOneName);
            Controls.Add(_playerTwoName);
            Controls.Add(_mark);
            Controls.Add(_MarkDisplayLabel);
            Controls.Add(_statusLabel);
            Controls.Add(_gameStatus);
        }

        public void CreateButton()
        {
            for (int i = 0; i < 3; i++)
            {
                CreateButtonRow(i);
            }
        }

        private void CreateButtonRow(int i)
        {
            for (int j = 0; j < 3; j++)
            {
                Button button = new Button();
                button.Text = number.ToString();
                button.BackColor = Color.AliceBlue;
                button.Location = new Point((j + 2) * 110, (i + 2) * 110);
                button.Width = 120;
                button.BackColor = Color.Bisque;
                button.Height = 120;
                button.Font= new Font(button.Font.FontFamily, 20);
                listButton.Add(button);
                Controls.Add(button);
                button.Enabled = false;
                button.Click += Button_Click;
                number += 1;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int position = Convert.ToInt32(button.Text);
            string name = _MarkDisplayLabel.Text;
            game.Play(position);
            button.Text = board.GetMark(position).ToString();

            if (game.Status() == (Results.WIN))
            {
                _gameStatus.Text = "Win " + name;
                ButtonEnableDisable();

            }
            if (game.Status() == (Results.DRAW))
            {
                _gameStatus.Text = "Draw";
            }
            if (game.Status() == (Results.PROGRESS))
            {
                _gameStatus.Text = "Progress";
            }
            _MarkDisplayLabel.Text = game.PlayerName.ToString();
        }

        private void ButtonEnableDisable()
        {
            foreach (Button button1 in listButton)
            {
                _startButton.Enabled = true;
                button1.Enabled = false;
            }
        }

        private void Restart()
        {
            int number = 0;

            foreach (Button resteButton in listButton)
            {
                resteButton.Text = number.ToString();
                resteButton.Enabled = false;
                number++;
            }
            _MarkDisplayLabel.Text = "";
            _gameStatus.Text = "";
          
        }

        private void Initialize()
        {
            board = new Board();
            player[0] = new Player("amit", Mark.O);
            player[1] = new Player("shubahm", Mark.X);
            analyzer = new ResultAnalayzer(board);
            game = new Game(player, analyzer, board);
        }
    }
}
