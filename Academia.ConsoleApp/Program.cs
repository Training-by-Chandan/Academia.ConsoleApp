using Academia.ConsoleApp.Collections;
using Academia.ConsoleApp.Inheritence;
using Academia.ConsoleApp.Interface;
using System;
using System.Data; //using directive
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Academia.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inherit();
            //StructVsClass();

            //EnumExample();

            //InterfaceExample();

            //PointersExample();

            //Delegates();

            //CollectionsExample();

            //GenericTest();

            //DynamicCustomQueueImplementation();
            //StringGenericDynamicCustomQueueImplementation();

            //Async1();
            //Async2();

            //AttributeExample();

            //Exceptions();

            Database();

            Console.ReadLine();
        }
            static Human h;

        static void Database()
        {
            // We have a People table
            // with an Id and a Name
            using var connection =
              new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AcademiaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

             connection.Open();

            // insert into database
            var insert = connection.CreateCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "insert into People (Name) values (@Name)";
            insert.Parameters.AddWithValue("@Name", "Khalid");
            var result = insert.ExecuteNonQuery();
            Console.WriteLine($"We executed an insert with a result of {result}");

            // read from the database
            var query = connection.CreateCommand();
            query.CommandText = "select Id, Name from People";
            query.CommandType = CommandType.Text;
            using (var reader = query.ExecuteReader())
            {
                while (reader.Read()) 
                {
                    Console.WriteLine($"My name is {reader["Name"]}");
                }
            }

            // clean up
            var truncate = connection.CreateCommand();
            truncate.CommandType = CommandType.Text;
            truncate.CommandText = "Truncate Table People";
            result = truncate.ExecuteNonQuery();
            Console.WriteLine($"We executed an insert with a result of {result}");

            // shut it down, shut it all down            
            connection.Close();
            Console.WriteLine("Connection terminated 🤖");
        }
        static void Exceptions ()
        {
            try
            {
                Console.WriteLine(h.Name);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void ExceptionExample()
        {
            var a = Console.ReadLine();
            if (a.Contains("abc"))
            {
                throw new AcademiaException("abc is not valid");
            }
            if (a.Contains("xyz"))
            {
                throw new NewException("xyz is not valid");
            }
        }


        static void AttributeExample()
        {
            LoginModel login = new LoginModel();

            login.Username = "abc";
            login.Password = "test123";

            var properties = login.GetType().GetProperties();

            foreach (var item in properties)
            {
                Console.WriteLine(item.Name);
                var propertyAttrib = item.CustomAttributes;
                foreach (var items in propertyAttrib)
                {
                    Console.WriteLine(items.AttributeType.Name);
                    //if email address then validate and verify if the value in property is email or not

                    //if password validate and verify and print ********
                }
            }
            var classProperties = login.GetType().CustomAttributes;

            Console.WriteLine(login.Username);
        }

        static async Task Async1()
        {
            for (int i = 0; i < 5000; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Async 1==>{0} ", i);
            }
        }

        static async Task Async2()
        {
            for (int i = 0; i < 2500; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine($"Async 2 ============> {i}");
            }
        }


        static void CustomQueueImplementation()
        {
            CustomQueue queue = new CustomQueue();
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(6);
            queue.Enqueue(2);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(3);
            queue.Enqueue(10);
            queue.Enqueue(12);
            queue.Enqueue(21);

            queue.DisplayAll();
            int a = queue.Dequeue();
            queue.DisplayAll();

            queue.Enqueue(1);
            queue.DisplayAll();

            queue.Enqueue(13);
            queue.Enqueue(109);
        }

        static void DynamicCustomQueueImplementation()
        {
            DynamicCustomQueue queue = new DynamicCustomQueue();
            queue.Enqueue(1);
            queue.DisplayAll();
            queue.Enqueue(3);
            queue.DisplayAll();
            queue.Enqueue(6);
            queue.DisplayAll();
            queue.Enqueue(2);
            queue.DisplayAll();
            queue.Enqueue(7);
            queue.DisplayAll();
            queue.Enqueue(8);
            queue.DisplayAll();
            queue.Enqueue(3);
            queue.DisplayAll();
            queue.Enqueue(10);
            queue.DisplayAll();
            queue.Enqueue(12);
            queue.DisplayAll();
            queue.Enqueue(21);

            queue.DisplayAll();
            int a = queue.Dequeue();
            queue.DisplayAll();

            queue.Enqueue(1);
            queue.DisplayAll();

            queue.Enqueue(13);
            queue.DisplayAll();
            queue.Enqueue(109);
            queue.DisplayAll();

        }

        static void IntGenericDynamicCustomQueueImplementation()
        {
            GenericDynamicCustomQueue<int> queue = new GenericDynamicCustomQueue<int>();
            queue.Enqueue(1);
            queue.DisplayAll();
            queue.Enqueue(3);
            queue.DisplayAll();
            queue.Enqueue(21);

            queue.DisplayAll();
            int a = queue.Dequeue();
            queue.DisplayAll();

            queue.Enqueue(1);
            queue.DisplayAll();

            queue.Enqueue(13);
            queue.DisplayAll();
            queue.Enqueue(109);
            queue.DisplayAll();

        }

        static void Templating()
        {
            TemplatingExample<int, string> example = new TemplatingExample<int, string>();
            var a = example.Func1(1);
            TemplatingExample<string, int> example2 = new TemplatingExample<string, int>();
            var b = example2.Func1("1");

        }

        static void StringGenericDynamicCustomQueueImplementation()
        {
            GenericDynamicCustomQueue<string> queue = new GenericDynamicCustomQueue<string>();
            queue.Enqueue("a");
            queue.DisplayAll();
            queue.Enqueue("b");
            queue.DisplayAll();
            queue.Enqueue("c");

            queue.DisplayAll();
            string a = queue.Dequeue();
            queue.DisplayAll();

            queue.Enqueue("d");
            queue.DisplayAll();

            queue.Enqueue("e");
            queue.DisplayAll();
            queue.Enqueue("f");
            queue.DisplayAll();

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

        static void PointersExample()
        {
            int i = 0;

            Pointers.Math math = new Pointers.Math();

            math.Add1byVal(i);

            Console.WriteLine($"After using Pass by Val Method value of I is {i}");

            math.Add1byRef(ref i);

            Console.WriteLine($"After using Pass by Ref Method value of I is {i}");

        }


        static void Delegates()
        {
            DelegatesAndEvent.DelegateImpl d1 = new DelegatesAndEvent.DelegateImpl();
            Console.WriteLine("Without Adding");

            d1.Initiate();
            // d1.Initiate2();

            //after adding next event
            Console.WriteLine("try adding 1");

            d1.AddNextEvent();
            d1.Initiate();
            Console.WriteLine("try adding 2");
            d1.AddNextEvent();
            d1.Initiate();
            Console.WriteLine("try adding 3");

            d1.AddNextEvent();
            d1.Initiate();


        }

        static void CollectionsExample()
        {
            ListStudents ls = new ListStudents();
            ls.AddStudent("pratik", "dahal", 0);
            ls.AddStudent("Manish", "Dhakal", 101);
            ls.AddStudent("pranish", "maharjan", 50);
            ls.AddStudent("Rohit", "maharjan", 50);
            ls.AddStudent("Rajat", "maharjan", 50);

            ls.DisplayAll();

            ls.DisplaybyFName("R");
            ls.DisplaybyFName("pra");


        }

        static void GenericTest()
        {
            GenericStack<string, int> gs = new GenericStack<string, int>();
            gs.DisplayTypesofTemplates();

            GenericStack<Students, ListStudents> gs2 = new GenericStack<Students, ListStudents>();
            gs2.DisplayTypesofTemplates();

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
