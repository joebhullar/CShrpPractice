using System;
using System.Collections.Generic;

namespace CShrpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("First Grade Book");
            book.AddGrade(89.1);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };  //declare new list of double
            grades.Add(56.1); //we are adding to the list of grades

            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The avg grade is {result:N1}");
      }
    }
}
