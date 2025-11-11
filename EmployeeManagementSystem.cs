using System;

namespace EmployeeManagementSystem
{
    class Employee
    {
        
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public string Department { get; set; }

        
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Department: {Department}");
        }

        
        public void UpdateDepartment(ref string newDepartment)
        {
            Department = newDepartment;
        }

        
        public double CalculateTotalSalary(params double[] salaryComponents)
        {
            double total = 0;
            foreach (double component in salaryComponents)
            {
                total += component;
            }
            return total;
        }

       
        public void GetDepartment(out string department)
        {
            department = Department;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp = new Employee();

          
            Console.Write("Enter Employee Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Employee ID: ");
            emp.EmployeeID = int.Parse(Console.ReadLine());

            Console.Write("Enter Department: ");
            emp.Department = Console.ReadLine();

            
            Console.WriteLine("\nInitial Employee Details:");
            emp.DisplayDetails();

           
            Console.Write("\nEnter new Department: ");
            string newDepartment = Console.ReadLine();
            emp.UpdateDepartment(ref newDepartment);

           
            Console.WriteLine("\nUpdated Employee Details:");
            emp.DisplayDetails();

          
            Console.Write("\nEnter salary components separated by space: ");
            string[] components = Console.ReadLine().Split(' ');
            double[] salaryComponents = Array.ConvertAll(components, double.Parse);
            double totalSalary = emp.CalculateTotalSalary(salaryComponents);

            Console.WriteLine($"\nTotal Salary: {totalSalary:C}");

           
            emp.GetDepartment(out string department);
            Console.WriteLine($"\nRetrieved Department (using out): {department}");
        }
    }
}
