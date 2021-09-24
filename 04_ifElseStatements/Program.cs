using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ifElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursSpentStudying = 1;
            if(hoursSpentStudying < 16)
            {
                Console.WriteLine("student spent less than 16 hours studying.");
                Console.WriteLine("Another line");
            }

            bool taskComplete = false;
            int num;
            if(taskComplete)
            {
                Console.WriteLine("good on you");
            }
            else
            {
                Console.WriteLine("Allocate time twards objective!");
                num = 12;
            }

            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();
            
            int age = Convert.ToInt32(ageInput);

            if(age > 17)
            {
                Console.WriteLine("Welcome to adulthood");
            }
            else
            {
                Console.WriteLine("Looks like you're a child");
                if(age < 6)
                {
                    Console.WriteLine("you're a baby, baby");
                }
                else if(age < 0)
                {
                    Console.WriteLine("Life is a gift, make it a good one");
                }
                else
                {

                }
            }

            Console.ReadKey();
        }
    }
}
