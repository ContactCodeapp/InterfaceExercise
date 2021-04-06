using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            

            var list = new List<Vehicle>();
            

            var car = new Car()
            {
                Color = "black",
                Name = "Mazeroti",
                Model = "Gran Tourismo",
                NumberOfCyclinders = 10,
                NumberOfDoors = 2,
                Location = "Italy",
                Seats = 2,
                Sunroof = "Yes",
            };

            var truck = new Truck()
            {
                Color = "Silver",
                Name = "Ford",
                Model = "F-150",
                Location = "America",
                NumberOfDoors = 4,
                NumberOfCyclinders = 8,
                BedSize = 72,
                TowCapcity = 8000

            };

            var suv = new Suv()
            {
                Color = "white",
                NumberOfCyclinders = 8,
                Name = "Mercades",
                Model = "G-Wagon",
                Location = "Germany",
                NumberOfDoors = 4,
                CargoSpace = 69,
                RearSeats = "no"
            };

            list.Add(car);
            list.Add(truck);
            list.Add(suv);

           


            
                foreach (var item in list)
                {
                Console.WriteLine($"Model: {item.Model}\n" +
                                  $"Color: {item.Color}\n" +
                                  $"Number of Doors: {item.NumberOfDoors}\n" +
                                  $"Numebr of Cylinders: {item.NumberOfCyclinders}\n" +
                                  $"Made by: {item.Name}\n" +
                                  $"Location: {item.Location}\n" +
                                  $"");
                }

            

               
            

            
          
        }
    }
}
