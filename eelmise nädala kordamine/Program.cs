using System;

namespace eelmise_nädala_kordamine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enda vanuse arvutamine see ja järgmine aasta
            int yearOfBirth;
            int age;
            int ageNextYear;

            Console.WriteLine("Enter your year of birth:");
            yearOfBirth = int.Parse(Console.ReadLine());

            age = CalculateAge(yearOfBirth,2019);
            Console.WriteLine($"You are {age} years old.");

            ageNextYear = CalculateNextAge(age);
            Console.WriteLine($"Next year you are {ageNextYear}");
            
            //Kuninganna Elisabeth vanus ja enda vanuse vahe arvutamine
            
            CalculateDifference(yearOfBirth);

            Console.ReadLine();


        }
        public static int CalculateAge(int yearOfBirth, int currentYear)
        {
            //int result = currentYear - yearOfBirth;
            return currentYear- yearOfBirth;
        }

        public static int CalculateNextAge(int userAge)
        {
            //return nextYear - yearOfBirth;
            return userAge + 1;
        }

        public static void CalculateDifference(int yearOfBirth)
        {
            if (yearOfBirth > 1926)
            {
                Console.WriteLine($" You are {yearOfBirth-1926} year younger than Queen Elisabeth"); 
            }
            else if (yearOfBirth < 1926)
            {
                Console.WriteLine($"You are {1926-yearOfBirth} years older than Queen!"); 
            }
            else
            {
                Console.WriteLine($"You are {yearOfBirth-1926} years older than Queen!");
            }
        }
        
    }
}