using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.RentalVehicles
{
    //Sailboats don't have engines
    public class RentalSailBoat : RentalVehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Turn key to off setting");
        }
    }
}
