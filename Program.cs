using System;

namespace properties_and_fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Age = 20;

            Console.WriteLine(s1.Age);
            Student s2 = new Student();
            s2.Age = 22;
            Console.WriteLine($"Student 2 age is {s2.Age}");
            s2.Name = "Mohamed fathy";
            Console.WriteLine(s2.Name);
        }

    }
}
