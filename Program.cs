/* ref. https://www.w3schools.com/cs/trycs.php?filename=demo_class
*/

// See https://aka.ms/new-console-template for more information

using System;

 //namespace MyApplication
 //{

    class Car
    {
        public string color = "red";      // public application
        public string style = "sedan";
        public string year_made = "2020";
    }

    class Program
    {

        static void Main(string[] args)
        {
        Car myObj1 = new Car();
        Car myObj2 = new Car();
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj1.style);
        Console.WriteLine(myObj1.year_made);

        Console.WriteLine("");

        Console.WriteLine(myObj2.color);
        Console.WriteLine(myObj2.style);
        Console.WriteLine(myObj2.year_made);
        }
    }
 //}