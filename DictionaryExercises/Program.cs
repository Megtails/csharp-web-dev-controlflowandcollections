using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students' name and ID number. Press Enter to finish.");

            do
            {
                Console.WriteLine("Student name: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("ID number: ");
                    input = Console.ReadLine();
                    double IDNumber = double.Parse(input);
                    students.Add(newStudent, IDNumber);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }
            } while (!Equals(newStudent, ""));

            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<string, double> student in students)
            {
                Console.WriteLine(student.Value + "'s ID: " + student.Key);
            }

            Console.WriteLine("Number of students in roster: " + students.Count);
        }
    }
}
