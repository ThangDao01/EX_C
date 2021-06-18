using System;
using System.Diagnostics.Contracts;

namespace C_Test
{
    public class Person
    {
        public string Name  { get; set; }
        public int Age  { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Person details - Name = {Name} ,Age = {Age}");
            Console.WriteLine($"Person details < After incrementing age> - Name = {Name} ,Age = {Age+1}");
        }
    }
}