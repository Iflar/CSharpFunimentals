using _10_InterfacesConsole_Part2.Interfaces;
using _10_InterfacesConsole_Part2.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2
{
    class Program
    {
        /*
        Inheritance is used to associate a parent base class with it's child relationships. ------> Animal -> cat -> Lion

        Interfaces is a contract with a set for requierments.
        */
        static void Main(string[] args)
        {
            List<IRental> _rentals = new List<IRental>();

            _rentals.Add(new Truck() { RentalID = 1, CurrentRenter = "truck Guy", TruckStyle = Vehicles.TruckType.LongBed });
            _rentals.Add(new Car() { RentalID = 2, CurrentRenter = "Car Guy", Carstyle = Vehicles.CarType.Sedan });
            _rentals.Add(new SailBoat() { RentalID = 3, CurrentRenter = "Boat Guy", SailBoatStyle = Vehicles.SailBoatType.Boat1 });


            foreach(IRental rental in _rentals)
            {
                if(rental is Truck t)
                {
                    Console.WriteLine("The {0} rented a {1} Which has a rentalID of {2}", t.CurrentRenter, t.TruckStyle, t.RentalID);

                }else if (rental is Car c)
                {
                    Console.WriteLine("The {0} rented a {1} Which has a rentalID of {2}", c.CurrentRenter, c.Carstyle, c.RentalID);
                }
                else if (rental is SailBoat sb)
                {
                    Console.WriteLine("The {0} rented a {1} Which has a rentalID of {2}", sb.CurrentRenter, sb.SailBoatStyle, sb.RentalID);
                    sb.NumberofLifeJackets = 2;
                    Console.WriteLine($"The {sb.SailBoatStyle} has {sb.NumberofLifeJackets} life jackets");
                }
            }
            Console.ReadKey();

        }
    }
}
