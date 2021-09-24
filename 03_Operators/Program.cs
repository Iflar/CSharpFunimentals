using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 7;
            int numTwo = 20;

            //addition
            int sum = numOne + numTwo;
            Console.WriteLine(sum);

            //Subtraction
            int differance = numOne - numTwo;
            Console.WriteLine(differance);

            //multiplication
            int product = numOne * numTwo;
            Console.WriteLine(product);

            //Division
            int quotent = numOne / numTwo;
            Console.WriteLine(quotent);

            //Remainder
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            //Timespan
            DateTime today = DateTime.Now;
            DateTime someday = new DateTime(1997, 5, 6);
            TimeSpan timespan = today - someday;
            Console.WriteLine(timespan);

            //Conversions
            //Casting -- one variable to another type of variable
            //type name = (castType)value
            int five = 5;
            double doubleFive = (double)five;
            Console.WriteLine(doubleFive);
          

            char a = 'a';
            int valueA = (int)a;
            Console.WriteLine(valueA);
            Console.WriteLine(a);

            //Conversion
            //type = Convert.toType(value);
            int klive = 5;
            decimal decKlive = Convert.ToDecimal(klive);//int to decimal

            decimal becimal = 2.55m;
            int gigBecimal = Convert.ToInt32(becimal);//decimal to int

            //parsing
            //just for strings
            //type name = type.Parse(string)
            string decimalString = "5.1818181";
            decimal decimalValue = decimal.Parse(decimalString);

            //Comparisom Operators
            Console.WriteLine("Enr ega plz.");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("entry of name requierd");
            string userName = Console.ReadLine();

            bool equals = age == 41;
            Console.WriteLine("user is 41" + " " + equals);

            bool notEquals = age != 41;
            Console.WriteLine($"user is not 41{notEquals}" );

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> newList = new List<string>();
            newList.Add(userName);


            //is as typeOf  -- look these up

            Console.ReadKey();
        }
    }
}
