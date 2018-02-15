using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4
{
    public class Vehicle
    {

        public int Id { get; set; }
        public String Make { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(int id, String make, String model, int year)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
        }
    }
}