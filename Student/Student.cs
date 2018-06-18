namespace Student
{
    public class Student
    {
        public string FullName { get; set; }
        public string DepartmentName { get; set; }
        public string SpecialtyName { get; set; }
        public int NumberOfGroup { get; set; }
        public double AverageScore { get; set; }

        public Student(string FN, string DN, string SN, int NOG, double AS)
        {
            FullName = FN;
            DepartmentName = DN;
            SpecialtyName = SN;
            NumberOfGroup = NOG;
            AverageScore = AS;
        }

    }
}
