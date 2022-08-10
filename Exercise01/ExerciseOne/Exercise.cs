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
            Console.WriteLine("This hour is: {0}", DateTime.Now.Hour.ToString());
        }


        //Exercise session 2
        public static void DataOfThePerson()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("are you a programmer?");
            string isProgrammer = Console.ReadLine();

            Console.WriteLine($"Name: {name}\nLastname: {lastname}\nAge: {age}\nIs a programmer?: {isProgrammer}");

        }

        public static void DescriptionObjects()
        {
            int doors = 4;
            int wheel = 4;
            string mark = "Ford";
            string validITV = "valid";
            Console.WriteLine($"The car have {doors} doors, {wheel} wheels. The mark of the car is {mark}. The Itv is {validITV} ");

            float weight = 60.2f;
            float lenght = 2.4f; ;
            string material = "metal";
            string color = "red";

            Console.WriteLine($"The features of the table:\n" +
                $"weight: {weight}\n" +
                $"lenght: {lenght}\n" +
                $"material: {material}\n" +
                $"color: {color}");

        }

        public static void CheckConditions(int number, char letter)
        {
            if (number >= 18)
            {
                Console.WriteLine("number valid");
            }
            if ('a' == letter)
            {
                Console.WriteLine("char valid");
            }
            if (number >= 18 && 'a' == letter)
            {
                Console.WriteLine("valid number and char");
            }
            if (number >= 18 || 'a' == letter)
            {
                Console.WriteLine("valid number or char");
            }
        }

    }
}
