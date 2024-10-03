using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        PrintStudentGrades();
    }

    static void PrintStudentGrades()
    {
        List<String> studentNames = new List<String>();
        List<String> studentGrades = new List<String>();
        
        do
        {
            Console.WriteLine("Please enter a new Student's name.");
            string studentName = Console.ReadLine();

            if (string.IsNullOrEmpty(studentName))
            {
                break;
            }
            studentNames.Add(studentName);

            Console.WriteLine($"Please enter a grade for {studentName}");
            string studentGrade = Console.ReadLine();
            studentGrades.Add(studentGrade);

        }
        while (true);

        Console.WriteLine("Grades:");

        for (int i = 0; i < studentNames.Count; i++)
        {
            Console.WriteLine($"Student Name:{studentNames[i]}");
            Console.WriteLine($"Student Grade:{studentGrades[i]}");
            // Output
            // Grades:
            // Student Name: {Name}
            // Student Grade: {Grade}
        }
    }
}