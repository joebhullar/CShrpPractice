using System;
using System.Collections.Generic;
using System.Text;

namespace CShrpPractice
{
    public class Book
    {
        public Book(string name) //Constructor method same name as class & Cannot have a return type BECAUSE IT IS A constructor
        {             // This code will execute everytime we use new keyword for class Book to create constructor for Book();
            grades = new List<double>(); //This code Garunteed to execute when I use "new" keyword against this calss
            this.name = name; // Sets FIELD Value 'public string name' = Equal to = Paramater passed 'name'
                              // this.name is reffering to FIELD 'public string name;'!!!!
                              //this is an implicit variable available inside methods and inside of constructors. We use it to refer to objects being operated on. 
        }                                 
        public void AddGrade(double grade)
        {
            this.grades.Add(grade); // Constructor Book();  Will Execute before Invoking AddGrade that will try to use that field. 
        } //this keyword refers to FIELD Paramater!!!

        public Statistics GetStatistics() 
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;
            return result;
        }


        public List<double> grades;//this field is NOW PUBLIC outside of this calss. 
        public string name; // our FIELD Varaible for Name of book

    }
}
