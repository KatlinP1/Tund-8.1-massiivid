using System;

namespace uus1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] fruits= new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Name some fruit: ");
                fruits[i] = Console.ReadLine();
            }

            foreach(string fruit in fruits)
            {
                Console.WriteLine($"You have insert: {fruit}");
                
            }
            
            
            Console.ReadLine();
        }
    }
}