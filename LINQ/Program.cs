namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbersQuery = from num in numbers
                                   where num % 2 == 0
                                   select num;

            Console.WriteLine("Even numbers (Query Sintax):");

            foreach (var num in evenNumbersQuery)
            {
                Console.WriteLine(num);
            }

            //LINQ Method Sintax

           List<Student> students = new List<Student>
            {
                new Student("Yuta", 24),
                new Student("Toji", 24),
                new Student("Megumi", 16),
                new Student("Nobara", 16),
                new Student("Maki", 24)
            };
           
            var orderedStudents = students.OrderBy(s => s.Age).ThenBy(s => s.Age).ToList();
            var groupedStudents = students.GroupBy(s => s.Age).ToList();
            var orderedStudentsDesc = students.OrderByDescending(s => s.Name).ThenByDescending(s => s.Age).ToList();

            Console.WriteLine("\n\n\nStudents ordered by Age (Method Sintax):\n");

            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Age Group: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($" - {student.Name}, Age: {student.Age}");
                }
            }

        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Student() { }

            public Student(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
}
