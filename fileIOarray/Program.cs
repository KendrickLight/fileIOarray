using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileIOarray
{
    class Program
    {
        private static object file;

        static void Main(string[] args)
        {
            string dataPath = @"Data\students.txt";
            string[] students;

            students = new string[3];
            students[0] = "Sue,McWaters,39";
            students[1] = "Bill,Tompson,20";
            students[2] = "Charles,veils,22";

            WriteAllStudents(dataPath, students);
            students = ReadAllStudents(dataPath);
            DisplayStudentInfo(students);
        }

        static void DisplayStudentInfo(string[] students)
        {
            Console.WriteLine();
            Console.WriteLine("Student Info");
            Console.WriteLine();

            //
            //Split out individual fields
            //

            Console.WriteLine(
                "firstName".PadRight(15) +
                "lastName".PadRight(15) +
                   "age".PadRight(15)
                        );
            Console.WriteLine(
    "---------".PadRight(15) +
    "--------".PadRight(15) +
       "---".PadRight(15)
       );



            foreach (string student in students)
            {
                string[] studentInfo = student.Split(',');

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                string age = studentInfo[2];

                Console.WriteLine(
                    firstName.PadRight(15)+
                    lastName.PadRight(15)+
                    age.PadRight(15)
                    );


            }




            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue.");
            Console.ReadKey();
        }

         static void WriteAllStudents(string dataPath, string[] students)
        {
            File.WriteAllLines(dataPath, students);
        }

        static string[] ReadAllStudents(string dataPath)
        {
            string[] students;

            students = File.ReadAllLines(dataPath);

            return students;
        }
    }
}
