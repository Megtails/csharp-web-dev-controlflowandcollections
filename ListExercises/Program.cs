using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 3, 8, 2, 1, 3, 9, 8, 7, 5, 4 };
            MessWithLists.SumEvens(nums);

            List<string> words = new List<string> { "bangs", "five", "trees", "pig", "to", "cigar", "balloon", "grave", "as", "shin", "camp", "log"};
            Console.WriteLine("Enter a word length: ");
            string searchTerm = Console.ReadLine();
            int searchNumber = int.Parse(searchTerm);
            MessWithLists.PrintRandomNumberLetters(words, searchNumber);
        }
        public class MessWithLists
        {
            public static int SumEvens(List<int> args)
            {
                int sum = 0;

                foreach (int number in args)
                {
                    if (number % 2 == 0)
                    {
                        sum += number;
                    }
                }
                Console.WriteLine(sum);
                return sum;

            }

            public static void PrintFiveLetters(List<string> args)
            {
                foreach (string word in args)
                {
                    if (word.Length == 5)
                    {
                        Console.WriteLine(word);
                    }
                }
            }

            public static void PrintRandomNumberLetters(List<string> args, int length)
            {
                foreach (string word in args)
                {
                    if (word.Length == length)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}


