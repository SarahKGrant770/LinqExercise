using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */
            #region Array Practice
            //Print the Sum and Average of numbers

            var sum = numbers.Sum();
            Console.WriteLine(sum);

            var avg = numbers.Average();

            Console.WriteLine(avg);
            Console.WriteLine();

            //Order numbers in ascending order and decsending order. Print each to console.
            //Where(x => x > 4).OrderBy(x => x))
            Console.WriteLine("Ascending");
            foreach (var num in numbers.OrderBy(x => x))

            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine("Descending");
            foreach (var num in numbers.OrderByDescending(x => x))
            {
                Console.WriteLine(num);
            }
                      
            Console.WriteLine();

            //Print to the console only the numbers greater than 6
            Console.WriteLine("Greater than 6.");
            foreach (var num in numbers.Where(x => x > 6))

            {
                Console.WriteLine(num);
            }
            Console.WriteLine();


            //    //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine();
            Console.WriteLine("Only 4 numbers in descending order");
            var someNums = numbers.Take(4).OrderByDescending(x => x);
            foreach (var num in someNums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();


            //Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine();
            Console.WriteLine("With my age in desc order");
            numbers[4] = 44;
            var numbersWithMyAgeInDescOrder = numbers.OrderByDescending(x => x);
            foreach (var num in numbersWithMyAgeInDescOrder)

            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            #endregion
            #region List Practice


            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            var employeeSubSet = employees.Where(e => e.FirstName.StartsWith("C") || e.FirstName.StartsWith("S")).OrderBy(e => e.FirstName);

            //now need to iterate over list of employees
            foreach (Employee employee in employeeSubSet)
            {
                Console.WriteLine(employee.FullName);
            }
            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            Console.WriteLine();
            var employeesOver26 = employees.Where(e => e.Age > 26).OrderBy(e => e.Age).ThenBy(e => e.FirstName);
            //or below you can say var employee
            foreach (Employee employee in employeesOver26)
            {
                Console.WriteLine($"Name: {employee.FirstName} | Age: {employee.Age}");
            }
        Console.WriteLine();
                //Print the Sum and then the Average of the employees' YearsOfExperience
                //if their YOE is less than or equal to 10 AND Age is greater than 35
                var yoeGreaterThan10 = employees.Where(e => e.YearsOfExperience <= 10 && e.Age > 35);
        var sumOfYOE = yoeGreaterThan10.Sum(e => e.YearsOfExperience);
        var avgOfYOE = yoeGreaterThan10.Average(e => e.YearsOfExperience);
                foreach (var employee in yoeGreaterThan10)
                {
                    Console.WriteLine($"Name: {employee.FullName} | Age: {employee.Age} | YoE: {employee.YearsOfExperience}");
                }

    Console.WriteLine($"The sum of the employees years of exp is: {sumOfYOE}");
                Console.WriteLine($"The average of the employees years of exp is: {avgOfYOE} ");


            //Add an employee to the end of the list without using employees.Add()
            var newList = employees.Append(new Employee("Whit", "Stroup", 24, 42));
            foreach (var employee in newList)
            {
                Console.WriteLine(employee.FullName);
            }


            Console.WriteLine();

            Console.ReadLine();
        }

        //#region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee("Cruz", "Sanchez", 27, 10));
                employees.Add(new Employee("John", "Ward", 29, 50));
                employees.Add(new Employee("Micheal", "Doyle", 36, 8));
                employees.Add(new Employee("Daniel", "Walsh", 72, 22));
                employees.Add(new Employee("Jill", "Valentine", 32, 43));
                employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
                employees.Add(new Employee("Big", "Boss", 23, 14));
                employees.Add(new Employee("Solid", "Snake", 18, 3));
                employees.Add(new Employee("Chris", "Redfield", 44, 7));
                employees.Add(new Employee("Faye", "Valentine", 32, 10));

                return employees;
            }
        #endregion
    }

}

