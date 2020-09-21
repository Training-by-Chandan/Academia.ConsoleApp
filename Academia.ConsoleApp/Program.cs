using System;

namespace Academia.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = "y";
            do
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your class");
                string classname = Console.ReadLine();

                Student s1 = new Student(name, classname);

                Console.WriteLine("\n\n\n");
                s1.Display();

                Console.WriteLine("Do you want to continue more (y/n)");
                ans = Console.ReadLine();
            } while (ans == "y");
        }
    }
}
