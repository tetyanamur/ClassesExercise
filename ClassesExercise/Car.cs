using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
    public class Car
    {  //constructors 

       public Car()
       {

        }
        public Car(string make, string model, int year)
            {
            Make = make;
            Model = model;
            Year = year;
            }
        //fields
        //properties
        //methods
        public string Make { get; set; } //get = read; set = write
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
