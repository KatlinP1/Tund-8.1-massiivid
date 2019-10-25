using System;

namespace uus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sõnadega massiivid 
            
            String[] myFirstStringArray;
            
            myFirstStringArray= new string[5] {"one","two","three","four","five"};

            for (int i = 0; i < myFirstStringArray.Length; i++)
            {
                Console.WriteLine(myFirstStringArray[i]);
            }
            for (int i = myFirstStringArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myFirstStringArray[i]);
            }

            Console.ReadLine();
        }
    }
}