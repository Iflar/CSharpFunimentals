using _07_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _07_ClassesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Type = VehicleType.Car;
            firstVehicle.Make = "Honda";
            firstVehicle.Model = "Civic";
            firstVehicle.Year = 2012;
            firstVehicle.Mileage = 4050;
            firstVehicle.Color = "grey";

            Vehicle secondVehicel = new Vehicle("Chevy", "Silverado", 1994, 98000, "black", VehicleType.Truck);

            Console.WriteLine(secondVehicel.Make);

            Console.ReadKey();

            //Person firstPerson = new Person("Billy", "Bond", new DateTime(1991,08,24), secondVehicel);

            //Console.WriteLine(firstPerson.Transport.Make);

            Console.ReadKey();

        }



    }
}
