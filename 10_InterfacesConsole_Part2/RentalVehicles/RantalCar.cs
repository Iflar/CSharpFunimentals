using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.RentalVehicles
{
    /*
    rental car is a type of vehicel so this will work
    */

    public enum CarType { Hatchback, Sedan, Compact}
    public class RantalCar : RentalVehicle
    {
        public CarType CarStyle { get; set; }
    }

}
