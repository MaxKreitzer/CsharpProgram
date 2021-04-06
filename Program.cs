using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Guess the from 1 to 10.");
            int num = random.Next(0,11);
            int inp = Convert.ToInt32(Console.ReadLine());

            while (inp != num)
            {
                if (inp < num)
                {
                    Console.WriteLine("Too low");
                    inp = Convert.ToInt32(Console.ReadLine());
                }
                if (inp > num)
                {
                    Console.WriteLine("Too High");
                    inp = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Correct!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
