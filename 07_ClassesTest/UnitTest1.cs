using _07_Classes;
using _07_Classes_updated_;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_ClassesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddPerson()
        {

            PersonRepository _repo = new PersonRepository();
            Person person = new Person();

            List<Person> localList = _repo.ReturnListOfPeople();
            int count = localList.Count;
            _repo.AddPerson(person);

            List<Person> updatedLocalList = _repo.ReturnListOfPeople();
            int newCount = updatedLocalList.Count;

            bool result = newCount == (count + 1) ? true : false;

            Assert.IsTrue(result);
        }
    }
}
// 3 A's of test methods

//1: Arrange - Seting up test data requiered to test our method
//   what do I need to test this method.


//2: Act - Calling our method and saving what it retuns (if anything) to a variable.

//3: Assert - 