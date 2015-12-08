using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _151002_ListsChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console 10 students’ test scores between 0 and 100 (int). 
            //Calculate and print the sum and the average of the test scores. Use a list.

            List<int> scores = new List<int>();

            Console.WriteLine("Please provide 10 student test scores.");

            for (int i = 0; i < 10; i ++)
            {
                Console.Write("Score: ");
                scores.Add(int.Parse(Console.ReadLine()));
            }
            

            int sum = 0;
            foreach (int score in scores)
            {
                sum = sum + score;
            }
            
            int average = (sum / 10);
            Console.WriteLine("The average is: " + average);
        }
    }
}
