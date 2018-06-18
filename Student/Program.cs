using System;
using System.Collections.Generic;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Nick", "ASD", "JKKK", 1, 5);
            Student l = new Student("Alex", "SAS", "KLK", 2, 4);
            Student s1 = new Student("KWEk", "ASf", "ggK", 1, 3);
            Student l1 = new Student("Alexa", "SASa", "KLKa", 2, 4);
            List<Student> list = new List<Student>(){s, l, s1, l1};
            StudentsListMethods.GetStudentsInList(list, StudentsListMethods.GetStudentByScore, 4).ForEach(i => Console.WriteLine("{0}\t", i.FullName + " " + i.AverageScore));
            StudentsListMethods.GetStudentsInList(list, StudentsListMethods.GetStudentsByGroup, 1).ForEach(i => Console.WriteLine("{0}\t", i.FullName + " " + i.AverageScore));
            StudentsListMethods.GetStudentsInList(list, StudentsListMethods.GetStudentsByName, "Alex").ForEach(i => Console.WriteLine("{0}\t", i.FullName + " " + i.AverageScore));
            StudentsListMethods.SortStudents(list, StudentsListMethods.ComparisonStudentsByScore).ForEach(i => Console.WriteLine("{0}\t", i.FullName + " " + i.AverageScore));
            Console.ReadLine();
        }
    }
}
