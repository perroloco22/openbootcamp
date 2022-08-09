using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    public static class Exercise
    {

        public static void PrintName()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");

        }

        public static void PrintHour()
        {
            Console.WriteLine("This hour is: {0}",DateTime.Now.Hour.ToString());
        }

    }
}
