using System;

namespace Pr5
{
    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine($"Имя: {Name}\nВозраст: {Age}");
            Console.WriteLine();
        }
    }


}

