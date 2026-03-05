using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Vehicle
    {
        public int id;
        public string name;

        public Vehicle()
        {
            Console.WriteLine("Vehicle Constructor called");
        }

        public Vehicle(int id, string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("Vehicle paramerized constructor called");
        }
        public override string ToString()
        {
            return $"[ {this.id} , {this.name} ]";
        }
    }

    class Bike : Vehicle
    {
        public string color;

        public Bike()
        {
            Console.WriteLine("Bike constructor called");
        }
        public Bike(int id, string name, string color): base(id, name)
        {
            this.color = color;
            Console.WriteLine("Bike parameterized constructor called");
        }
        public override string ToString()
        {
            return $"[ {this.id} , {this.name}, {this.color} ]";
        }

        public static void Main()
        {
            Vehicle vehicle1 = new Vehicle();
            Console.WriteLine(vehicle1.ToString());
            Vehicle vehicle2 = new Vehicle(1, "RX100");
            Console.WriteLine(Convert.ToString(vehicle2));


            Bike bike1 = new Bike();
            Console.WriteLine(bike1.ToString());
            Bike bike2 = new Bike(1, "Honda", "Blue");
            Console.WriteLine(bike2.ToString());
            Console.ReadLine();
        }
    }
}
