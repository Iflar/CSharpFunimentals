using System;

namespace _07_Classes
{
    public enum VehicleType { Car, Truck, SUV, Van, Coupe, Boat }
    public class Vehicle
    {
        //access modifier  type  propertyname  {get;set;}
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Mileage { get; set; }

        public VehicleType Type { get; set; }


        public Vehicle(string make, string model, int year, double mileage, string color, VehicleType type)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            Color = color;
            Type = type;

        }

       public Vehicle()
        {

        }
    }
    public class Person
    {

        //age
        //height
        //gender
        //weight
        //date of birth
        //first name
        //last name
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName 
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public DateTime DateOfBirth { get; set; }

        public int AgeInYears
        {
            get 
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;

                double totalAgeInYears = ageSpan.TotalDays / 365.25;

                return Convert.ToInt32(Math.Floor(totalAgeInYears));
            }
        }

        public Vehicle Transport { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName, DateTime DateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = DateOfBirth;
            //Transport = transport;
        }
    }














}
//class = blueprint of a specific object
//-class members = everything we declaire inside a class - constructors
//object = thing creted from the blueprint

//access modifier, retun type, name