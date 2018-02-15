using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4
{
    public class Quote
    {
        private string FName { get; set; }
        private string LName { get; set; }
        private int Zip { get; set; }
        private int Year { get; set; }
        private string Make { get; set; }
        private string Model { get; set; }
        private int Age { get; set; }
        private string Type { get; set; }
        private double Price { get; set; }

        public Quote(string fName, string lName, int zip, int year, string make, string model, int age, string type, double price)
        {
            FName = fName;
            LName = lName;
            Zip = zip;
            Year = year;
            Make = make;
            Model = model;
            Age = age;
            Type = type;
            Price = price;
        }

        public override String ToString()
        {
            return "Name: " + FName + " " + LName + " Vehicle: " + Year + " " + Make + " " + Model + " Insurance Quote: $" + Price;
        }
    }
}