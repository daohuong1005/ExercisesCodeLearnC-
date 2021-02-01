using System;

namespace GettingStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User enter his/her name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Your name is : " + name);

            Console.ReadKey();
        }
    }
}
