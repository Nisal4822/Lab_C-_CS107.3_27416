using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace labday3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Nisal";
            //int age = 22;
            //double batch = 22.2;
            //Console.WriteLine(name);
            //Console.WriteLine(age);
            //Console.WriteLine(batch);
            //Console.ReadKey();


            //string name;
            //Console.Write("Enter your name: ");
            //name=Console.ReadLine();
            //Console.WriteLine("Enter your age: ");
            //int age=Console.ReadKey();
            //Console.WriteLine("Hello " + name);
            //Console.WriteLine(age);

            string name;
            int age;
            int marks;
            Console.Write("Enter your name: ");
            name=Console.ReadLine();
            Console.Write("Eneter your age: ");
            age=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks of the module: ");
            marks=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + name + " you are " + age + " years old");
            if (marks>=75)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks>=65)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks>=55)
            {
                Console.WriteLine("Grade: C");
            }
            else if (marks>=35)
            {
                Console.WriteLine("Grade: S");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
            Console.ReadKey();
            
        }
    }
}
