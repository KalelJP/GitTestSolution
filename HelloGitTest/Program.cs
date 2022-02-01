using System;

namespace HelloGitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Hello GitHub!");
                Console.WriteLine("=================");
                Console.WriteLine("Let's test your Git knowledge!");
                Console.WriteLine();
                Console.WriteLine("Which command is utilised to put two branches together?");
                string sAnswer1 = Console.ReadLine();
                if (sAnswer1.ToLower() == "merge")
                {
                    Console.WriteLine("Congratulations! Way to go superstar!");
                    Console.WriteLine("Goodbye");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Unfortunately that is not right. Try Again!");
                }
            } while (repeat);


        }
    }
}
