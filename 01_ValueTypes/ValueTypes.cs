using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_ValueTypes
{
    public enum PastryType
    {
        Cake = 0,
        Dainish = 1,
        Backlava = 2,
        Donut = 3,
        Scone = 4,
    }

    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void InitAndDeclareVariables()
        {
            int numOne; //delaire variable
            numOne = 1; //init variable

            int numTwo = 2; //init and declaire variable

        //Variable
        //named location in computer memory AKA: RAM
        }

        [TestMethod]
        
        public void ValueTypeVariables()
        {
            //whole Numbers
            byte byteExample = 255; //byte 0-255
            sbyte sbyteExample = -128; //may be negative down to -128
            short shortExample = 32767;
            Int16 shortExampleTwo = 32000;
            int intMin = -2147483648;
            int intMax = 2147483647;
            Int32 intExample2 = 123456;
            long longMax = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            //Decimals
            double doubleExample = 3.1459;
            float floatExample = 3.1459f;
            decimal decimalExample = 3.1459M;

            Console.WriteLine(doubleExample);

            //Character
            char charExample = 'F';
            char number = '8';
            char symbol = '@';
            char space = ' ';
            char specialChar = '\n';

            //Bool
            bool hunger = true;
            bool fatigue = false;

            //Enum
            PastryType myPastry = PastryType.Backlava;

            //Structs
            DateTime today = DateTime.Now;

            Console.WriteLine(today);
        }
    }
}
