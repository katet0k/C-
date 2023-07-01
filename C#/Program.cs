
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace C_
{
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
                Console.WriteLine("Гравець {0} виграв!", winner);
            else
                Console.WriteLine("Це нічия!");
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
            Console.WriteLine("Хід гравця {0}.", currentPlayer);
            Console.Write("Введіть номер рядка (1-3): ");
            int row = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Введіть номер стовпця (1-3): ");
            int col = int.Parse(Console.ReadLine()) - 1;

            if (board[row, col] != Player.None)
            {
                Console.WriteLine("Недійсний хід. Спробуйте знову.");
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

    public static class MorseCodeTranslator
    {
        private static readonly Dictionary<char, string> morseCodeDictionary = new Dictionary<char, string>()
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

        private static readonly Dictionary<string, char> reverseMorseCodeDictionary = new Dictionary<string, char>();

        static MorseCodeTranslator()
        {
            foreach (var pair in morseCodeDictionary)
            {
                reverseMorseCodeDictionary.Add(pair.Value, pair.Key);
            }
        }

        public static string TranslateToMorseCode(string text)
        {
            text = text.ToUpper();
            string morseCode = "";

            foreach (char c in text)
            {
                if (morseCodeDictionary.ContainsKey(c))
                {
                    morseCode += morseCodeDictionary[c] + " ";
                }
                else
                {
                    morseCode += c;
                }
            }

            return morseCode;
        }

        public static string TranslateFromMorseCode(string morseCode)
        {
            string[] words = morseCode.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string translatedText = "";

            foreach (string word in words)
            {
                if (reverseMorseCodeDictionary.ContainsKey(word))
                {
                    translatedText += reverseMorseCodeDictionary[word];
                }
                else
                {
                    translatedText += " ";
                }
            }

            return translatedText;
        }
    }

    namespace EvenNumbers
    {
        public class EvenNumberGenerator
        {
            private int currentNumber = 0;

            public int GetNext()
            {
                int evenNumber = currentNumber;
                currentNumber += 2;
                return evenNumber;
            }
        }
    }

    namespace OddNumbers
    {
        public class OddNumberGenerator
        {
            private int currentNumber = 1;

            public int GetNext()
            {
                int oddNumber = currentNumber;
                currentNumber += 2;
                return oddNumber;
            }
        }
    }

    namespace PrimeNumbers
    {
        public class PrimeNumberGenerator
        {
            private List<int> primes = new List<int>() { 2 };

            public int GetNext()
            {
                int currentNumber = primes[primes.Count - 1] + 1;
                while (!IsPrime(currentNumber))
                {
                    currentNumber++;
                }
                primes.Add(currentNumber);
                return currentNumber;
            }

            private bool IsPrime(int number)
            {
                if (number < 2)
                    return false;
                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;
            }
        }
    }

    namespace FibonacciNumbers
    {
        public class FibonacciNumberGenerator
        {
            private List<int> fibonacciNumbers = new List<int>() { 0, 1 };

            public int GetNext()
            {
                int nextNumber = fibonacciNumbers[fibonacciNumbers.Count - 1] + fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(nextNumber);
                return nextNumber;
            }
        }
    }
    namespace Shapes
    {
        // Клас трикутника
        public class Triangle
        {
            private double sideA;
            private double sideB;
            private double sideC;

            public Triangle(double a, double b, double c)
            {
                sideA = a;
                sideB = b;
                sideC = c;
            }

            public double CalculateArea()
            {
                // Використовуємо формулу Герона для обчислення площі трикутника
                double s = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            }
        }

        // Клас прямокутника
        public class Rectangle
        {
            private double length;
            private double width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }

            public double CalculateArea()
            {
                return length * width;
            }
        }

        // Клас квадрата
        public class Square
        {
            private double side;

            public Square(double s)
            {
                side = s;
            }

            public double CalculateArea()
            {
                return side * side;
            }
        }
    }

        namespace ComputerPlayer
    {
        public class NumberGuesser
        {
            private int minRange;
            private int maxRange;
            private int targetNumber;
            private Random random;

            public NumberGuesser(int minRange, int maxRange)
            {
                this.minRange = minRange;
                this.maxRange = maxRange;
                random = new Random();
            }

            public void SetTargetNumber()
            {
                targetNumber = random.Next(minRange, maxRange + 1);
            }

            public bool Guess(int number)
            {
                if (number == targetNumber)
                {
                    Console.WriteLine("Комп'ютер вгадав число!");
                    return true;
                }
                else if (number < targetNumber)
                {
                    Console.WriteLine("Комп'ютер загадав число менше!");
                }
                else
                {
                    Console.WriteLine("Комп'ютер загадав число більше!");
                }
                return false;
            }
        }
    }
    namespace TextGenerator
    {
        public class LoremIpsumGenerator
        {
            private const string Vowels = "aeiou";
            private const string Consonants = "bcdfghjklmnpqrstvwxyz";
            private Random random;

            public LoremIpsumGenerator()
            {
                random = new Random();
            }

            public string GenerateText(int vowelCount, int consonantCount, int maxLength)
            {
                StringBuilder text = new StringBuilder();

                for (int i = 0; i < vowelCount; i++)
                {
                    text.Append(GetRandomCharacter(Vowels));
                }

                for (int i = 0; i < consonantCount; i++)
                {
                    text.Append(GetRandomCharacter(Consonants));
                }

                return CapitalizeFirstLetter(text.ToString()).Substring(0, maxLength);
            }

            private char GetRandomCharacter(string characters)
            {
                int index = random.Next(characters.Length);
                return characters[index];
            }

            private string CapitalizeFirstLetter(string text)
            {
                if (string.IsNullOrEmpty(text))
                    return text;

                char[] charArray = text.ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);
                return new string(charArray);
            }
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
                            Console.Write("Введіть текст: ");
                            string inputText = Console.ReadLine();

                            string morseCode = MorseCodeTranslator.TranslateToMorseCode(inputText);
                            Console.WriteLine("Азбука Морзе: " + morseCode);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("1. Перекласти азбукою Морзе");
                            Console.WriteLine("2. Перекласти з азбуки Морзе");
                            Console.Write("Введіть ваш вибір (1 або 2): ");
                            int choice = int.Parse(Console.ReadLine());

                            if (choice == 1)
                            {
                                Console.Write("Ввудіть текст: ");
                                string inputText = Console.ReadLine();

                                string morseCode = MorseCodeTranslator.TranslateToMorseCode(inputText);
                                Console.WriteLine("Morse Code: " + morseCode);
                            }
                            else if (choice == 2)
                            {
                                Console.Write("Введіть азбуку Морзе: ");
                                string morseCode = Console.ReadLine();

                                string translatedText = MorseCodeTranslator.TranslateFromMorseCode(morseCode);
                                Console.WriteLine("Перекладений текст: " + translatedText);
                            }
                            else
                            {
                                Console.WriteLine("Invalid.");
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Парні числа:");
                            EvenNumbers.EvenNumberGenerator evenGenerator = new EvenNumbers.EvenNumberGenerator();
                            for (int i = 0; i < 5; i++)
                            {
                                int evenNumber = evenGenerator.GetNext();
                                Console.WriteLine(evenNumber);
                            }

                            Console.WriteLine("\nНепарні числа:");
                            OddNumbers.OddNumberGenerator oddGenerator = new OddNumbers.OddNumberGenerator();
                            for (int i = 0; i < 5; i++)
                            {
                                int oddNumber = oddGenerator.GetNext();
                                Console.WriteLine(oddNumber);
                            }

                            Console.WriteLine("\nПрості числа:");
                            PrimeNumbers.PrimeNumberGenerator primeGenerator = new PrimeNumbers.PrimeNumberGenerator();
                            for (int i = 0; i < 5; i++)
                            {
                                int primeNumber = primeGenerator.GetNext();
                                Console.WriteLine(primeNumber);
                            }

                            Console.WriteLine("\nЧисла Фібоначчі:");
                            FibonacciNumbers.FibonacciNumberGenerator fibonacciGenerator = new FibonacciNumbers.FibonacciNumberGenerator();
                            for (int i = 0; i < 5; i++)
                            {
                                int fibonacciNumber = fibonacciGenerator.GetNext();
                                Console.WriteLine(fibonacciNumber);
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 6:
                        {
                            double triangleSideA = 3.0, triangleSideB = 4.0, triangleSideC = 5.0;
                            Shapes.Triangle triangle = new Shapes.Triangle(triangleSideA, triangleSideB, triangleSideC);
                            Console.WriteLine($"Площа трикутника: {triangle.CalculateArea()}");

                            double rectangleLength = 6.0, rectangleWidth = 8.0;
                            Shapes.Rectangle rectangle = new Shapes.Rectangle(rectangleLength, rectangleWidth);
                            Console.WriteLine($"Площа прямокутника: {rectangle.CalculateArea()}");

                            double squareSide = 5.0;
                            Shapes.Square square = new Shapes.Square(squareSide);
                            Console.WriteLine($"Площа квадрата: {square.CalculateArea()}");


                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Ласкаво просимо до гри «Вгадай число»!");
                            Console.WriteLine("Придумайте число в заданому діапазоні й дайте комп’ютеру вгадати його.");

                            Console.Write("Введіть мінімальне значення діапазону: ");
                            int minRange = int.Parse(Console.ReadLine());

                            Console.Write("Введіть максимальне значення діапазону: ");
                            int maxRange = int.Parse(Console.ReadLine());

                            Console.WriteLine("Чудово! Нехай гра починається.");

                            ComputerPlayer.NumberGuesser numberGuesser = new ComputerPlayer.NumberGuesser(minRange, maxRange);
                            numberGuesser.SetTargetNumber();

                            bool guessedCorrectly = false;

                            while (!guessedCorrectly)
                            {
                                Console.Write("Припущення комп'ютера: ");
                                int guess = int.Parse(Console.ReadLine());

                                guessedCorrectly = numberGuesser.Guess(guess);
                            }

                            Console.WriteLine("Дякуємо за гру!\n");


                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 8: {
                            Console.WriteLine("Введіть кількість голосних: ");
                            int vowelCount = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введіть кількість приголосних: ");
                            int consonantCount = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введіть максимальну довжину слова: ");
                            int maxLength = int.Parse(Console.ReadLine());

                            TextGenerator.LoremIpsumGenerator generator = new TextGenerator.LoremIpsumGenerator();
                            string generatedText = generator.GenerateText(vowelCount, consonantCount, maxLength);

                            Console.WriteLine("Згенерований псевдотекст: ");
                            Console.WriteLine(generatedText);
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