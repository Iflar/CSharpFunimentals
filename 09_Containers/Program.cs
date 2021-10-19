using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Containers
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            // Dictionary -- Key value pairs

            Dictionary<int, Employee> _employeeDictionary = new Dictionary<int, Employee>();

            Employee employee1 = new Employee(1, "James", 75000);
            Employee employee2 = new Employee(2, "Matt", 45000);
            Employee employee3 = new Employee(3, "Todd", 150000);

            _employeeDictionary.Add(employee1.ID, employee1);
            _employeeDictionary.Add(employee2.ID, employee2);
            _employeeDictionary.Add(employee3.ID, employee3);

             Employee isEmployee2 = _employeeDictionary[2];
            Console.WriteLine(isEmployee2.Name);

            Console.ReadKey();

            foreach(KeyValuePair<int, Employee> kvp in _employeeDictionary)
            {
                Console.WriteLine("key = {0}", kvp.Key);
                Employee emp = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", emp.ID, emp.Name, emp.Salary);
                Console.WriteLine("-----------------------------------------------------------------");
            }


            Console.ReadKey();

            Employee employeeError = new Employee(1, "john", 900000);


            if (_employeeDictionary.ContainsKey(employeeError.ID))
            {
                Console.WriteLine("Already have that key");
            }
            else
            {
                _employeeDictionary.Add(employeeError.ID, employeeError);
            }

            Employee em;
            if(_employeeDictionary.TryGetValue(2, out em))
            {
                Console.WriteLine(em.Name);
            }
            else
            {
                Console.WriteLine("key not found");
            }

            Console.ReadKey();

            _employeeDictionary.Remove(1);

            _employeeDictionary.Clear();

            int count  = _employeeDictionary.Count(e => e.Value.Salary > 100000);

            //Queues
            // -- first to enter first to leave
            //Stack
            // -- last to enter first to leave
            //Hashset

        }
    }
}
