
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace C_ {
    public enum Player
    {
        None,
        X,
        O
    }

    public class Game
    {
        private Player[,] board;
        private Player currentPlayer;

        public Game()
        {
            board = new Player[3, 3];
            currentPlayer = Player.None;
        }

        public void Start()
        {
            Random random = new Random();
            currentPlayer = random.Next(2) == 0 ? Player.X : Player.O;

            while (!IsGameOver())
            {
                DrawBoard();
                MakeMove();
                SwitchPlayer();
            }

            DrawBoard();
            Player winner = GetWinner();
            if (winner != Player.None)
                Console.WriteLine("Player {0} wins!", winner);
            else
                Console.WriteLine("It's a draw!");
        }

        private void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine("  1 2 3");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + 1 + " ");
                for (int col = 0; col < 3; col++)
                {
                    char symbol = board[row, col] == Player.X ? 'X' :
                                  board[row, col] == Player.O ? 'O' : ' ';
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }

        private void MakeMove()
        {
            Console.WriteLine("Player {0}'s turn.", currentPlayer);
            Console.Write("Enter row number (1-3): ");
            int row = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Enter column number (1-3): ");
            int col = int.Parse(Console.ReadLine()) - 1;

            if (board[row, col] != Player.None)
            {
                Console.WriteLine("Invalid move. Try again.");
                MakeMove();
            }
            else
            {
                board[row, col] = currentPlayer;
            }
        }

        private void SwitchPlayer()
        {
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
        }

        private bool IsGameOver()
        {
            return GetWinner() != Player.None || IsBoardFull();
        }

        private Player GetWinner()
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] != Player.None && board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                    return board[row, 0];
            }

            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] != Player.None && board[0, col] == board[1, col] && board[1, col] == board[2, col])
                    return board[0, col];
            }

            // Check diagonals
            if (board[0, 0] != Player.None && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];
            if (board[2, 0] != Player.None && board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
                return board[2, 0];

            return Player.None;
        }

        private bool IsBoardFull()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == Player.None)
                        return false;
                }
            }
            return true;
        }
    }

    public static class MorseCode
    {
        private static readonly Dictionary<char, string> codeDictionary = new Dictionary<char, string>()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
            {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
            {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
            {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
            {'Z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
            {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
            {'9', "----."}, {' ', "/"}
        };

        public static string TranslateToMorseCode(string text)
        {
            text = text.ToUpper();
            string morseCode = "";

            foreach (char c in text)
            {
                if (codeDictionary.ContainsKey(c))
                {
                    morseCode += codeDictionary[c] + " ";
                }
                else
                {
                    morseCode += c;
                }
            }

            return morseCode;
        }
    }

    internal class Program
    {
        static char[,] board;
        static char currentPlayer;
        static bool gameOver;

        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("uk-UA");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            Console.OutputEncoding = Encoding.UTF8;

            int switch_on;

            do
            {
                Console.WriteLine("\n#===========================#");
                Console.WriteLine(" |       1 -  case 1       |");
                Console.WriteLine(" |       2 -  case 2       |");
                Console.WriteLine(" |       3 -  case 3       |");
                Console.WriteLine(" |       4 -  case 4       |");
                Console.WriteLine(" |       5 -  case 5       |");
                Console.WriteLine(" |       6 -  case 6       |");
                Console.WriteLine(" |       7 -  case 7       |");
                Console.WriteLine(" |       8 -  case 8       |");
                Console.WriteLine(" |       9 -  case 9       |");
                Console.WriteLine(" |      10 -  case 10      |");
                Console.WriteLine(" |      11 -  case 11      |");
                Console.WriteLine(" |      12 -  case 12      |");
                Console.WriteLine(" |      13 -  case 13      |");
                Console.WriteLine(" |       0 -   exit        |");
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            Game game = new Game();
                            game.Start();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        {
                            Game game = new Game();
                            game.Start();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Enter a text: ");
                            string inputText = Console.ReadLine();

                            string morseCode = MorseCode.TranslateToMorseCode(inputText);
                            Console.WriteLine("Morse Code: " + morseCode);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                 

                    default:
                        break;
                }
            } while (switch_on != 0);
        }
    }
}