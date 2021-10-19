using System;

namespace _07_Classes
{
    public enum VehicleType { Car, Truck, SUV, Van, Coupe, Boat}
    public class Vehicle
    {
        //access modifier  type  propertyname  {get;set;}
        public string Make { get; set; }
        public int year { get; set; }
        public string model{ get; set; }
        public string Color { get; set; }
        public double Mileage { get; set; }

        public VehicleType type  { get; set; }
    }
}
//class = blueprint of a specific object
    //-class members = everything we declaire inside a class - constructors
//object = thing creted from the blueprint