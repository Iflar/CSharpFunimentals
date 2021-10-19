using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part1.Fruit_Classes
{
    public interface IFruit
    {
        string Name { get; } // prop with only a get
        bool Peeled { get; set; } // prop with get and set

        string Peel(); // Mehtod with only a return type or buissnes logic or paramaters
    }
}
