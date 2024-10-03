using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        StudentGrades();
    }

    static void StudentGrades()
    {
        List<String> studentNames = new List<String>();
        List<String> studentGrades = new List<String>();
        
        do
        {
            Console.WriteLine("Please enter a Student's name.");
            string studentName = Console.ReadLine();

            studentNames.Add(studentName);

            if (!string.IsNullOrEmpty(studentName))
            {
                Console.WriteLine($"{studentName} was added.");
            }
            else
            {
                break;
            }
        }
        while (true);

        Console.WriteLine($"{studentNames}'s grade is ");
    }
}