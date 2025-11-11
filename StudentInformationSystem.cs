using System;

namespace StudentInformationSystem
{
    struct Student
    {
        
        public int ID;
        public string Name;
        public double GPA;

        
        public Student(int id, string name, double gpa)
        {
            ID = id;
            Name = name;
            GPA = gpa;
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, GPA: {GPA:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Student ID:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name:");
            string name = Console.ReadLine();

            Console.Write("Enter Student GPA:");
            double gpa = double.Parse(Console.ReadLine());

            
            Student student = new Student(id, name, gpa);

            
            Console.Write("\nStudent Details:");
            student.DisplayInfo();
        }
    }
}