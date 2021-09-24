using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tenaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 77;

            //(condition/Boolean) ? trueResult : faselResult
            string result = (age > 17) ? "u r adult" : "r u not adult";
            Console.WriteLine(result);

            bool boolresult = (age > 17) ? true : false;
            Console.WriteLine(boolresult);

            Console.ReadKey();
        }
    }
}
