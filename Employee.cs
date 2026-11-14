using System;

namespace Pr5
{
    public class Emoloyee : Person
    {
        public double Salary { get; set; }
        public double WorkExperience { get; set; }

        public Emoloyee(string name, int age, double zarp, int stag) 
        {
            Name = name;
            Age = age;
            Salary = zarp;
            WorkExperience = stag;
        }
        public Emoloyee(string name, int age) : this(name, age, 112000.44, 1)
        {
            Name = name;
            Age = age;
            
        }
    }
         
}