using System;
using System.Collections;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var name = args[0];
                Console.WriteLine($"Hello, {name}!");
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Hello Nameless Traveler.");
            }
        }
    }
}
