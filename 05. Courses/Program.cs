using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var coursesInfo = new Dictionary<string, List<string>>();
            string cmd = Console.ReadLine();
            while (cmd != "end")
            {
                string[] tokens = cmd.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string courseName = tokens[0];
                string studentName = tokens[1];
                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo[courseName] = new List<string>();
                }
                coursesInfo[courseName].Add(studentName);
                cmd = Console.ReadLine();
            }
            PrintCoursesInfo(coursesInfo);
        }

        private static void PrintCoursesInfo(Dictionary<string, List<string>> coursesInfo)
        {
            foreach (var kvp in coursesInfo)
            {
                string courseName = kvp.Key;
                var students = kvp.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
