using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("Jack"),
                new Student("Jill")
            };
            var joe = new Student("Joe");
            var teacher = new Teacher("Sally");
            
            // Subject can attach or Observer can observe
            teacher.Attach(students);
            joe.Observe(teacher);

            teacher.UpdateName("Bob");

            // Subject or observer can detach
            joe.Detach();
            teacher.Detach(students.Single(s => s.Name == "Jill"));
            teacher.UpdateName("Mary");

            Console.ReadKey();
        }
    }
}
