using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Car
    {
        string color = "red";
    }
    internal class Program
    {

        static void testMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("hello world");
            }
        }

        static string getFullName(string title="Mr.", string fname="A", string lname="B")
        {
            string tempFullName = string.Concat(fname, " ", lname);

            return string.Concat(title, tempFullName);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            string fName = "", lName = "";

            //Console.Write("First name: ");
            //fName = Console.ReadLine();

            //Console.Write("Last name: ");
            //lName = Console.ReadLine();


            //string fullName = getFullName(fName, lName);
            //Console.WriteLine($"Full name : {fullName}");

            Car car = new Car();
            Console.WriteLine($"Car color is {car.color}")

        }
    }
}
