using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_ReferenceTypes
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void ReferenceTypeVariables()
        {
            //Strings
            string stringExample;
            stringExample = "Variable Initialized hahaha.... HAHAHAHAHA!!!";

            //Console.WriteLine("hey, what's your first name??");
            //string firstnName = Console.ReadLine();
            //Console.WriteLine(firstnName);

            //string operation
            //Concatination
            string concatenatedFullName;
            string firstName = "Forrest";
            string lastName = "Rydén";
            concatenatedFullName = firstName + " " + lastName; //Forrest Rydén
            Console.WriteLine(concatenatedFullName);

            //Interpolation
            string interpolatedFullName = $"{firstName} {lastName}"; //Forrest Rydén
            Console.WriteLine(interpolatedFullName);

            //Collections
            //List
            List<string> listStrings = new List<string>();
            listStrings.Add(firstName);
            listStrings.Add(lastName);

            //Array
            string[] arrayStrings = new string[8];
            string[] array2 = { firstName, lastName, "improv" };

            //queue
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue(lastName);
            firstInFirstOut.Enqueue("what's up people!!!");

            //Dictionary
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(7, "Seven");
            Console.WriteLine(keyValuePairs[7]);

            //Other Collections
            SortedList<string, int> sorte = new SortedList<string, int>();
            HashSet<int> uniquList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();

            //classes
            Random randomExample = new Random();

            int randomNumber = randomExample.Next();
            Console.WriteLine(randomNumber);
        }
    }
}
