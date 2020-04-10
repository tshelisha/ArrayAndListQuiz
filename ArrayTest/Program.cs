using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello!  This will be an exerecise for classes!");
            Console.WriteLine();
            Console.WriteLine("Try to get the lowest possible score. . .");
            Console.WriteLine();
            Console.WriteLine("Hit any key to begin the quiz and start the timer");
            Console.ReadLine();

            Stopwatch sw = Stopwatch.StartNew();

            var answer1 = "var product = new Product();";
            var answer2 = "product.Name = \"Xbox\";";
            var answer3 = "public string Name {get;set;}";
            var answer4 = "blueprints";

            string guess;
            var wrongCount = 0;

            do
            {
                Console.WriteLine("Using inferred typing: create a new instance of the Product class and name it product");
                guess = Console.ReadLine();
                if(guess == answer1)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);
            
            do
            {
                Console.WriteLine("Now that you have created the instance, product.  Assign the value \"Xbox\" to its Name property:");
                guess = Console.ReadLine();
                if (guess == answer2)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer2 != guess);

            do
            {
                Console.WriteLine("Create a public property of type string called Name and give it read and write access:");
                guess = Console.ReadLine();
                if (guess == answer3)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    Console.WriteLine();
                    wrongCount++;
                }

            } while (answer3 != guess);

            do
            {
                Console.WriteLine("Fill in the blank:");
                Console.WriteLine("Classes serve as _________ for creating custom types:");
                guess = Console.ReadLine();
                if (guess == answer4.ToLower())
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer4.ToLower() != guess);



            var time = sw.Elapsed.Seconds;

            Console.WriteLine("Total seconds to complete:");
            Console.WriteLine(time);

            var score = (time * .4) + (wrongCount * .6);

            Console.WriteLine("Your Score:");
            Console.WriteLine(score);
            Console.ReadLine();

        }
    }
}
