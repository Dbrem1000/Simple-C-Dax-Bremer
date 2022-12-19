
/*
 * Program Name: StudentsGenerator
 * Programmer: Dax Bremer
 * Date: 12/19/2022
 *
 * Description: What does your program do? Be sure
 * to keep everything within view on your screen. Edit
 * this description to match what your program does. For
 * example, "This program allows users to create 
 * 4 specific students with an age in a C# windows console application
 */

using System;
using System.Collections.Generic;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "John", "adam", "david", "Manny" };
            List<int> ages = new List<int>() { 24, 21, 32, 28 };

            Person person;
            for (int i = 0; i < names.Count; i++)
            {
                person = new Person(names[i], ages[i]);
                Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
