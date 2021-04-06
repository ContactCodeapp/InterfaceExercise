using System;
namespace InterfaceExercise
{
    public class Vehicle : IVevhicle, ICompany
    {

        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public int NumberOfCyclinders { get; set; }
        public string Color { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }

        public Vehicle()
        {
        }
    }
}
