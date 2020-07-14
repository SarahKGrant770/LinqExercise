using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercise
{
    internal class Employee
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            //read only property bc there is no set, only get
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int YearsOfExperience { get; set; }

        public Employee(string firstName, string lastName, int age, int yearsOfExperience)
        {
            //Parameterized constructor
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            YearsOfExperience = yearsOfExperience;
        }
        
        public Employee()
        {
           //Default Constructor 
        }
    }
}
