using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name;
            //int age;

            //Console.WriteLine("")
            // Console.WriteLine("HEllO WORLD");
            //Console.WriteLine("this is my first program");


            // Console.WriteLine("enter the name");
            //name = Console.ReadLine();
            // Console.WriteLine("enter the age");
            // age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(name+" "+age);
            // Console.ReadLine();

            //int n1;
            //int n2;
            //int n3;

            //Console.WriteLine("enter the n1");
            //n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the n2");
            //n2 = Convert.ToInt32(Console.ReadLine());
            //n3 = n1 + n2;
            //Console.WriteLine(n3);

            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortDateString());



            Console.ReadKey();


        }
    }
}
