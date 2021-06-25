using System;

namespace TesteGitHub01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the whole number: ");
            int number = int.Parse(Console.ReadLine());

            if(number > 0)
            {
                Console.WriteLine("The number is positive!");
            }
            else
            {
                Console.WriteLine("The number is negative or null!");
            }
        }
    }
}
