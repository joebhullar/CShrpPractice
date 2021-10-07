using System;
using System.Collections.Generic;

namespace CShrpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("First Grade Book");
            book.AddGrade(12.7);
            book.AddGrade(10.3);
            book.AddGrade(6.11);
            book.AddGrade(4.1);
            book.AddGrade(56.1);
            var stats = book.GetStatistics(); // complete computation of book & display results
            Console.WriteLine($"The avg grade is {stats.Average:N1}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
        } 
        // The OPPOSITE of static is to have a method is OOP to instantiate that method.
        // 
    }
}
