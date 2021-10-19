using _10_InterfacesConsole_Part2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.Vehicles
{
    public enum TruckType {ShortBed, LongBed}
    public class Truck : LandVehicle, IRental
    {
        /*
        This is not repeition because we are not repeating the same logic
        sharing common properties is not a problem
        If we were trying to share common logic, Inheritance would be the prefered method
        */
        public int RentalID { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
        public TruckType TruckStyle { get; set; }
    }

}
