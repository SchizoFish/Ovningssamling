using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningssamling
{
    class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person
            {
                Age = age, FName = fname, LName = lname, Height = height, Weight = weight
            };

            return person;
        }

        public void PrintPerson(Person pers)
        {
            Console.WriteLine($"Age: {pers.Age}\nFirstname: {pers.FName}\nLastname: {pers.LName}\nHeight: {pers.Height}\nHeight: {pers.Height}\nWeight: {pers.Weight}");
        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void ChangeLName(Person pers, string lName)
        {
            string prevName = pers.LName;

            pers.LName = lName;

            Console.WriteLine($"Name changed from {prevName} to {pers.LName}");
        }

        public void UpdateWeight(Person pers, double weight)
        {
            pers.Weight = weight;

            Console.WriteLine($"Weight has been updated to: {pers.Weight}");
        }
    }
}
