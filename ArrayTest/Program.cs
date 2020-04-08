using System;
using System.Diagnostics;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();

            Console.WriteLine("Hello!  This will be an exerecise in array and list creation!");
            Console.WriteLine();
            var answer1 = "var numbers = new int[5];";
            var answer2 = "int[] numbers = new int[5];";
            var answer3 = "var teachers = new List<string>();";
            var answer4 = "List<string> teachers = new List<string>();";
            var answer5 = "teachers.Add(\"Michael\");";
            var answer6 = "teachers.Remove(\"Michael\");";

            var answer7 = "numbers[0] = 10;";
            var answer8 = "Count";

            var guess = "";
            var wrongCount = 0;

            do
            {
                Console.WriteLine("Using inferred typing: create a new array named numbers that will hold 5 integers:");
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
                Console.WriteLine("Using explicit typing: create a new array named numbers that will hold 5 integers:");
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
                Console.WriteLine("Place the value, 10, in the numbers array at index 0:");
                guess = Console.ReadLine();
                if (guess == answer7)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer7 != guess);

            //-------------------------Lists
            do
            {
                Console.WriteLine("Using inferred typing: create a new empty List named teachers that will hold string values:");
                guess = Console.ReadLine();
                if (guess == answer3)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer3 != guess);

            do
            {
                Console.WriteLine("Using explicit typing: create a new empty List named teachers that will hold string values:");
                guess = Console.ReadLine();
                if (guess == answer4)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer4 != guess);

            do
            {
                Console.WriteLine("Add the name, Michael, to the teachers list:");
                guess = Console.ReadLine();
                if (guess == answer5)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer5 != guess);

            do
            {
                Console.WriteLine("Remove the name, Michael, from the teachers list:");
                guess = Console.ReadLine();
                if (guess == answer6)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer6 != guess);

            do
            {
                Console.WriteLine("The following code will store the size of the teachers list in a variable");
                Console.WriteLine("but the code is missing to complete this");
                Console.WriteLine("What property will complete the code?");
                Console.WriteLine("var size = teachers._______;");
                guess = Console.ReadLine();
                if (guess == answer8)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer8 != guess);

            var time = sw.Elapsed.Seconds;

            Console.WriteLine("Total seconds to complete:");
            Console.WriteLine(time);

            var score = (time * .7) + (wrongCount * .3);

            Console.WriteLine("Your Score:");
            Console.WriteLine(score);
        }
    }
}
