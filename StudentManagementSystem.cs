using System;

namespace SimpleStudentManagementSystem
{
    class Student
    {
        
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double CGPA { get; set; }

        public void UpdateCGPA(double newCGPA)
        {
            if (newCGPA >= 0 && newCGPA <= 4.0)
            {
                CGPA = newCGPA;
                Console.WriteLine($"CGPA updated successfully for {Name}.");
            }
            else
            {
                Console.WriteLine("Invalid CGPA. It must be between 0.0 and 4.0.");
            }
        }

   
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"ID: {StudentID}, Name: {Name}, Age: {Age}, CGPA: {CGPA:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student { StudentID = 1, Name = "Alice", Age = 20, CGPA = 3.4 };
            Student student2 = new Student { StudentID = 2, Name = "Bob", Age = 21, CGPA = 3.7 };
            Student student3 = new Student { StudentID = 3, Name = "Charlie", Age = 22, CGPA = 3.2 };

            Student[] students = { student1, student2, student3 };

            Console.WriteLine("Student Details:");
            foreach (var student in students)
            {
                student.DisplayStudentDetails();
            }


            Console.WriteLine("\nUpdating Bob's CGPA...");
            student2.UpdateCGPA(3.9);

            Console.WriteLine("\nUpdated Student Details:");
            foreach (var student in students)
            {
                student.DisplayStudentDetails();
            }
        }
    }
}
