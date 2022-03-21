using System;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> cw = Console.WriteLine;
            int[] numbers = new int[20];
            int currentIndex = 0;
            



            bool repeat = true;
            do
            {
                cw("Please enter an interger: ");
                string line = Console.ReadLine();
                if (line == "exit")
                {
                    repeat = false;
                }
                else
                {

                    try
                    {
                        int number = int.Parse(line);
                        cw("The number you entered was: " + number);
                        numbers[currentIndex] = number;
                        currentIndex++;

                    }
                    catch (FormatException)
                    {
                        cw("That wasn't a number!");
                    }
                }

            } while (repeat);
            Console.WriteLine("Press any key to exit.");
            {
                while (repeat) ;

                for (int i = 0; i < currentIndex; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

            }

        }
    }
}
