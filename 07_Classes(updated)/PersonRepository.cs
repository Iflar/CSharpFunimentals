using _07_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes_updated_
{
    public class PersonRepository
    {
        private List<Person> _listOfPeople = new List<Person>(); //Instantiated person list

        public void AddPerson(Person person)
        {
            _listOfPeople.Add(person);
        }

        public List<Person> ReturnListOfPeople()
        {
            return _listOfPeople;
        }

        public void RemovePersonByName(string firstname)
        {
            foreach (Person p in _listOfPeople)
            {
                if (p.FirstName == firstname)
                {
                    _listOfPeople.Remove(p);
                }
            }
        }

        public Person UpdatePerson(Person oldPerson, Person newPerson)
        {
            foreach(Person p in _listOfPeople)
            {
                if(p == oldPerson)
                {
                    p.FirstName = newPerson.FirstName;
                    p.LastName = newPerson.LastName;
                    p.DateOfBirth = newPerson.DateOfBirth;

                    return p;
                }
            }

            return null;
        }

    }
}
