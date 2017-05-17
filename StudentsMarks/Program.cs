using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace StudentsMarks
{
    class CSStudentDetails {
        public string studentName;
        public int[] studentMarks = new int[5];
        public int totalMarks;  
    }


    class CSStudents {
        public List<CSStudentDetails> studentList = new List<CSStudentDetails>();
        public int maxStudents;

        public int addRecord(string name, int[] marks) {

            CSStudentDetails student = new CSStudentDetails();
            student.studentName = name;
            student.studentMarks = marks;
            student.totalMarks = 0;
            for (int i = 0; i < 5;i++) {
                student.totalMarks += student.studentMarks[i];
            }
            studentList.Add(student);
            maxStudents = studentList.Count();
            return 1;
        }
    }

    class Program
    {
        static public CSStudents students = new CSStudents();

		static public void ViewRecords()
		{



			Console.WriteLine("=================================================================");



			Console.WriteLine("SNo\tStudent Name\tENG\tMATH\tPHY\tCHE\tBIO\tTotal");

			Console.WriteLine("=================================================================");



			for (int i = 0; i < students.maxStudents; i++)
			{

				Console.Write("{0, -5}", i + 1);

                Console.Write("{0, -19}", students.studentList[i].studentName);

				Console.Write("{0, -7}", students.studentList[i].studentMarks[0]);

				Console.Write("{0, -7}", students.studentList[i].studentMarks[1]);

				Console.Write("{0, -7}", students.studentList[i].studentMarks[2]);

				Console.Write("{0, -7}", students.studentList[i].studentMarks[3]);

				Console.Write("{0, -7}", students.studentList[i].studentMarks[4]);

				Console.Write("{0, -7}", students.studentList[i].totalMarks);

				Console.WriteLine();

			}

			Console.WriteLine("=============================================================");

		}


		static public void InputRecords()

		{

			Console.Write("Student Name: ");

			string name;

			int[] marks = new int[5];

			name = Console.ReadLine();



			for (int i = 1; i <= 5; i++)

			{

				Console.Write("Sub " + i.ToString() + " Mark: ");

				marks[i - 1] = Convert.ToInt32(Console.ReadLine());

			}

			students.addRecord(name, marks);

		}



		static void Main(string[] args)

		{



			Console.WriteLine("Student MarkList Application");

			Console.Write("Enter the Total number  of students: ");

			int numStudents = -1;

			string s = Console.ReadLine();

			numStudents = Convert.ToInt32(s);



			for (int i = 1; i <= numStudents; i++)
			{

				Console.WriteLine("\nEnter " + i.ToString() + " Student Information\n");

				InputRecords();

			}

			ViewRecords();

			char ch = Console.ReadKey().KeyChar;

		}
	}
}
