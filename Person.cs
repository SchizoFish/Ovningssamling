using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningssamling
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age 
        { 
            get { return age; }
            set 
            {
                age = value > 0 ? value : throw new ArgumentException("Age must be higher than 0");
            }
        }
        public string FName
        {
            get { return fName; }
            set
            {
                fName = !String.IsNullOrEmpty(value) && value.Length > 2 ? value : throw new ArgumentException("First Name must consist of 2 characters or more");
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                lName = !String.IsNullOrEmpty(value) && value.Length > 3 ? value : throw new ArgumentException("Last Name must consist of 2 characters or more");
            }
        }
        public double Height 
        {
            get { return height; }
            set 
            {
                height = value > 0 ? value : throw new ArgumentException("Height must be higher than 0");
            } 
        }
        public double Weight 
        {
            get { return weight; }
            set
            {
                weight = value > 0 ? value : throw new ArgumentException("Height must be higher than 0");
            }
        }
    }
}
