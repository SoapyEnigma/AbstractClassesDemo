﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> list = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            Car mr2 = new Car()
            {
                Make = "Toyota",
                Model = "MR2",
                Year = "2000",
                HasTrunk = false
            };

            list.Add(mr2);

            Motorcycle scout = new Motorcycle()
            {
                Make = "Indian",
                Model = "Scout",
                Year = "2025",
                HasSideCar = false
            };

            list.Add(scout);

            Vehicle civic = new Car()
            {
                Make = "Honda",
                Model = "Civic",
                Year = "1990",
                HasTrunk = true
            };

            list.Add(civic);

            Vehicle goldWing = new Motorcycle()
            {
                Make = "Honda",
                Model = "Gold Wing",
                Year = "2024",
                HasSideCar = true
            };

            list.Add(goldWing);

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            foreach (Vehicle v in list)
            {
                Console.Write($"{v.Year} {v.Make} {v.Model}");

                if (v is Car car)
                    Console.WriteLine(car.HasTrunk ? " with a trunk.\n" : " without a trunk.\n");

                if (v is Motorcycle motorcycle)
                    Console.WriteLine(motorcycle.HasSideCar ? " with a sidecar.\n" : " without a sidecar.\n");
            }

            // Call each of the drive methods for one car and one motorcycle
            mr2.DriveAbstract();
            mr2.DriveVirtual();

            goldWing.DriveAbstract();
            goldWing.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
