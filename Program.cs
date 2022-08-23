using System;

namespace Peverly_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jake Peverly";
            Console.WriteLine(name);
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("10 % " + i.ToString() + " = " + (10 % i).ToString());
            }
        }
    }
}

// Build Solution is F7.
// Start Debugging is F5.
// The program closed because it was done debugging.
// Start without Debugging is Ctrl + F5