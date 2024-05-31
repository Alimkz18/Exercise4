using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EX 1

            WriteLine("Eneter an integer\n");

            int integer = int.Parse(ReadLine());

            if (integer % 2 == 0)
            {
                Write("----------");
                Write($"\nNumber {integer} is even.");
            }
            else
            {
                Write("----------");
                Write($"\nNumber {integer} is odd.");
            }

            ReadLine();


            Clear();


            //EX 2

            WriteLine("Hello, welcom to 21 GAME");
            WriteLine("\n\nEnter how meny cards do you have in your hand: ");


            int quantity = int.Parse(ReadLine());
            int sum = 0;



            for (int i = 0; i < quantity; i++)
            {

                Write($"\nEnter the value {i + 1} of card (2-10, J, Q, K, T): ");
                string cards = ReadLine();

                switch (cards)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        sum += int.Parse(cards);
                        break;
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        WriteLine("Unknown card value ! Try again");
                        i--;
                        break;
                }

            }

            WriteLine($"\nValue of your card {sum}");

            ReadLine();

            Clear();

            // EX 3

            WriteLine("Enter an integer to test for primality: ");
            int num = int.Parse(ReadLine());

            bool isPrime = true;
            int dev = 2;

            while (dev < num)
            {
                if (num % dev == 0)
                {
                    isPrime = false;
                    break;

                }
                dev++;
            }

            if (isPrime)
            {
                WriteLine($"\n{num} is prime.");
            }
            else
            {
                WriteLine($"\n{num} is compound");
            }

            ReadLine();


            Clear();

            //EX 4

            WriteLine("Enter sequence length");

            int length = int.Parse(ReadLine());
            int minNumber = int.MaxValue;

            WriteLine("\nEntre integer each number is confirmed with the Enetr key");

            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(ReadLine());

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            WriteLine($"Smallest number in sequence is {minNumber}");

            ReadLine();


            Clear();
            //EX 5

            WriteLine("Game \"Let's guess\"");
            WriteLine("\nEnter range");
            int range = int.Parse(ReadLine());

            Random ran = new Random();

            int iiNumber = ran.Next(0, range + 1);
            

            while (true)
            {
                WriteLine("\nEnter number:");
                string userInput = ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    Write($"\nGuessed number was {iiNumber}");
                }
                
                int guess;
                if (int.TryParse(userInput, out guess));
                {
                    
                }
               
                if (guess < iiNumber)
                {
                    Write("\nThe entered number is less than the specified number");
                }
                else if (guess > iiNumber)
                {
                    Write("\nThe entered number greater than the specified number");
                }
                else
                {
                    Write($"\nCongratulations, you guessed the number!");
                    ReadKey();
                    break;
                }
            }



































































































        }
    }
}
