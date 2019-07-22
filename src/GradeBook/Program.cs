using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book();
            book.AddGrade(89.1);

            var book2 = new Book();
            book2.AddGrade(90.1);


            var grades = new List<double>() { 12.7, 18.9, 9.7, 4.1 };
            grades.Add(56.1);
            

            var result = 0.0;
            foreach (double number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}
