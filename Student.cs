using System;

namespace Pr5
{

    public class Student : Person
    {
        public string Group { get; set; } = string.Empty;
        public double AverageMark { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("Student Record: ");
            Console.WriteLine("\tИмя        :" + Name);
            Console.WriteLine("\tВозраст    :" + Age);
            Console.WriteLine("\tГруппа     :" + Group);
            Console.WriteLine("\tСр.Оценка  :" + AverageMark);
        }

    }

}