using System;
using System.Text.RegularExpressions;

namespace Pr5
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int stCount = 5;
           Person[] people = new Person[stCount];
           people[0] = new Person();
           people[1] = new Person();
           people[2] = new Person();
           people[3] = new Person();
           people[4] = new Person();

           people[0].Name = "Владик";
           people[0].Age = 18;

           people[1].Name = "Егор";
           people[1].Age = 16;

           people[2].Name = "Тимур";
           people[2].Age = 17;

           people[3].Name = "Валерия";
           people[3].Age = 22;

           people[4].Name = "Денис";
           people[4].Age = 20;


            foreach (Person person in people)
           {
           person.Print();
           }

            Student[] students = new Student[stCount];
            students[0] = new Student();
            students[1] = new Student();
            students[2] = new Student();
            students[3] = new Student();
            students[4] = new Student();

            students[0].Name = "Саша";
            students[0].Age = 19;
            students[0].Group = "5992";
            students[0].AverageMark = 4.42;

            students[1].Name = "Вова";
            students[1].Age = 23;
            students[1].Group = "5992";
            students[1].AverageMark = 4.2;

            students[2].Name = "Тимофей";
            students[2].Age = 19;
            students[2].Group = "5992";
            students[2].AverageMark = 3.82;


            students[3].Name = "Олег";
            students[3].Age = 18;
            students[3].Group = "5992";
            students[3].AverageMark = 4.33;

            students[4].Name = "Матвей";
            students[4].Age = 22;
            students[4].Group = "5992";
            students[4].AverageMark = 4.75;

            Console.WriteLine("Весь список студентов: ");
            foreach (Student student in students)
            {
                student.PrintInfo();
                Console.WriteLine();
                Console.WriteLine();
            }


            Console.WriteLine("Студенты с баллом выше 4: ");
            foreach (Student student in students)
            {
                if (student.AverageMark > 4)
                {
                    Console.WriteLine($"Имя:        {student.Name}\nГруппа:     {student.Group}.\n");
                }
            }

            Console.WriteLine("Студенты старше 20: ");
            foreach(Student student in students)
            { 
                if(student.Age > 20)
                {
                    Console.WriteLine($"Имя:        {student.Name}\nВозраст:        {student.Age}\nГруппа:      {student.Group}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Студенты через метод Print: ");
            foreach(Student student in students)
            {
                student.Print();
            }


            Emoloyee emoloyee = new Emoloyee("Мария", 25, 88256.22, 5);
            emoloyee.Print();
            Emoloyee emoloyee1 = new Emoloyee("Иван", 29);
            emoloyee1.Print();
        }


        
    }
}