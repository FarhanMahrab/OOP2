using System;
using System.Globalization;
using System.Text.RegularExpressions;

class StudentRegistrationSystem
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine()?.Trim();

        Console.Write("Enter Email Address: ");
        string emailAddress = Console.ReadLine()?.Trim();

        Console.Write("Enter Course Name: ");
        string courseName = Console.ReadLine()?.Trim();

        Console.Write("Enter Registration ID: ");
        string registrationId = Console.ReadLine()?.Trim();

       
        if (!IsValidName(studentName))
        {
            Console.WriteLine("Error: Name should not contain numbers.");
            return;
        }

        if (!IsValidEmail(emailAddress))
        {
            Console.WriteLine("Error: Email must contain '@' and end with '.com'.");
            return;
        }

        if (string.IsNullOrWhiteSpace(courseName))
        {
            Console.WriteLine("Error: Course name cannot be empty or whitespace.");
            return;
        }

        if (registrationId.Length != 8)
        {
            Console.WriteLine("Error: Registration ID must be exactly 8 characters long.");
            return;
        }

        studentName = ToTitleCase(studentName);
        string emailDomain = ExtractEmailDomain(emailAddress);
        courseName = ProcessCourseName(courseName);
        registrationId = registrationId.ToUpper();

        
        Console.WriteLine("\n--- Student Details ---");
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Registration ID: {registrationId}");
        Console.WriteLine($"Email Domain: {emailDomain}");
        Console.WriteLine($"Final Course Name: {courseName}");
    }

    
    static bool IsValidName(string name)
    {
        return !string.IsNullOrEmpty(name) && !Regex.IsMatch(name, @"\d");
    }

    static bool IsValidEmail(string email)
    {
        return !string.IsNullOrEmpty(email) && email.Contains("@") && email.EndsWith(".com", StringComparison.OrdinalIgnoreCase);
    }

   
    static string ToTitleCase(string input)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
    }

    static string ExtractEmailDomain(string email)
    {
        int atIndex = email.IndexOf('@');
        return atIndex > -1 ? email.Substring(atIndex + 1) : string.Empty;
    }

    static string ProcessCourseName(string courseName)
    {
        if (courseName.Contains("Programming", StringComparison.OrdinalIgnoreCase))
        {
            courseName = Regex.Replace(courseName, "Programming", "Coding", RegexOptions.IgnoreCase);
        }
        return courseName.Trim();
    }
}
