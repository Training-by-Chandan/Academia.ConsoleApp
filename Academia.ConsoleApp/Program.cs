using Academia.ConsoleApp.Inheritence;
using System; //using directive

namespace Academia.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inherit();

            Console.ReadLine();
        }
        static  void Initial()
        {
            var ans = "y";
            do
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your class");
                string classname = Console.ReadLine();

                Student s1 = new Student(name, classname);
                Student s2 = new Student();
                Student s3 = new Student();
                Student s4 = new Student();
                Student s5 = new Student(name);

                Console.WriteLine("\n\n\n");
                s1.Display();

                Console.WriteLine("Do you want to continue more (y/n)");
                ans = Console.ReadLine();
            } while (ans == "y");
        }

        static void Inherit()
        {
            //Father f1 = new Father("Khanal", "Raj");
            //f1.FirstName = "";
            //f1.LastName = "";
            Grandfather g1 = new Grandfather("Ram", "Khanal");
            Father f1 = new Father("Khanal","Raj");
            Son s1 = new Son("Rahul","Khanal");


            g1.Display();
            f1.Display();
            s1.Display();
            
            
        }
    }
}
