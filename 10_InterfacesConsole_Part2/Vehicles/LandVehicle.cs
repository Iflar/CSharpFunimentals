using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.Vehicles
{
    public class LandVehicle
    {
        public int NumberOfPassengers { get; set; }
        public void StartEngine()
        {
            Console.WriteLine("Insert the key into ignition.");
            Console.WriteLine("Turn the key into the on positon.");
        }
        public void StopEngine()
        {
            Console.WriteLine("Turn key into off position.");
        }
    }
}
