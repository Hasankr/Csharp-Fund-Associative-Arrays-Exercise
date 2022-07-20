using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }
                students[studentName].Add(studentGrade);
                
            }
            foreach (var student in students)
            {
                if (student.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}
