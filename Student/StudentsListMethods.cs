using System;
using System.Collections.Generic;

namespace Student
{
    class StudentsListMethods
    {
        public delegate bool GetStudents(Student s, object o);

        public delegate Student ComparisonStudents(Student s1, Student s2);

        public static List<Student> GetStudentsInList(List<Student> s, GetStudents del, object o = null)
        {
            List<Student> result = new List<Student>();
            foreach (var student in s)
            {
                if(del(student, o)) { result.Add(student);}
            }
            return result;
        }

        public static List<Student> SortStudents(List<Student> s, ComparisonStudents del)
        {
            List<Student> result = new List<Student>();
            for(int i = 0; i < s.Count; i++)
            {
                int k = i + 1;
                if(k < i) result.Add(del(s[i], s[k]));
            }

            return result;
        }

        public static bool GetStudentByScore(Student s, object k)
        {
            if (s.AverageScore >= Convert.ToDouble(k))
            {
                return true;
            }
            return false;
        }

        public static bool GetStudentsByDepartment(Student s, object str)
        {
            if (s.DepartmentName.Contains((string)str))
            {
                return true;
            }
            return false;
        }
        public static bool GetStudentsByGroup(Student s, object k)
        {
            if (s.NumberOfGroup == (int)k)
            {
                return true;
            }
            return false;
        }

        public static bool GetsStudentsBySpecialty(Student s, object str)
        {
            if (s.SpecialtyName.Contains((string)str))
            {
                return true;
            }
            return false;
        }
        public static bool GetStudentsByName(Student s, object str)
        {
            if (s.FullName.Contains((string)str))
            {
                return true;
            }
            return false;
        }

        public static Student ComparisonStudentsByScore(Student s1, Student s2)
        {
            if (s1.AverageScore > s2.AverageScore)
            {
                return s1;
            }
            return s2;
        }

        public static Student ComparisonStudentsByName(Student s1, Student s2)
        {
            if (s1.FullName[0] > s2.FullName[0])
            {
                return s1;
            }
            return s2;
        }

    }
}
