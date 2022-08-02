using System;
using System.Collections.Generic;
namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Mercedes";
            myCar.Model = "Benze";
            myCar.Year = 2019;     //or:

            var honda = new Car()
            {
                Make = "Honda",
                Model = "civic",
                Year = 2014
            };
            var saturn = new Car("Saturn", "Vue", 2005);
            var carList = new List<Car>() { myCar, honda, saturn };
            foreach (var vechile in carList)
            {
                Console.WriteLine($"{vechile.Make} {vechile.Model} {vechile.Year}");
            }
        }

    }
}