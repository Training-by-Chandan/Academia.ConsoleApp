using Academia.ConsoleApp.Inheritence;
using Academia.ConsoleApp.Interface;
using System; //using directive

namespace Academia.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inherit();
            //StructVsClass();

            //EnumExample();

            InterfaceExample();
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

        static void StructVsClass()
        {
            Human h=new Human();
            HumanStruct hs;

            int i = 0;
        }


        static void EnumExample()
        {
            Gender male = Gender.Male;
            Gender female = Gender.Female;

            Console.WriteLine($"Value of male is {male}");
            Console.WriteLine($"Value of male in string is {male.ToString()}");
            Console.WriteLine($"Acctual Value of male in string is {(int)male}");
        }


        static void InterfaceExample()
        {
            IShape s1;
            Rectangle r1 = new Rectangle();
            r1.Length = 1.2M;
            r1.Breadth = 2.3M;
            Rectangle r2 = new Rectangle() { Length=1.5M, Breadth=5.4M };
            Circle c1 = new Circle() { Radius=2.5M };
            //r1 = c1; //this cannot be done
            s1 = r1;
            //for rectangle r1
            Console.WriteLine($"Perimeter = {s1.Perimeter()}\nArea = {s1.Area()}");

            //rectangle r2
            s1 = r2;
            Console.WriteLine($"Perimeter = {s1.Perimeter()}\nArea = {s1.Area()}");


            //Circle c1
            s1 = c1;
            Console.WriteLine($"Perimeter = {s1.Perimeter()}\nArea = {s1.Area()}");


        }

    }

    namespace PartialClasses
    {
        public partial class Electornics
        {
            void test()
            {
                this.ItemName = "";
            }
        }
    }
   
}
