namespace _11.StudentSpecialty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<StudentSpecialty> specialties = new List<StudentSpecialty>();
            List<Student> students = new List<Student>();

            while (input != "Students:")
            {
                string[] specialtyInfo = input.Split();
                StudentSpecialty currentSpecialty = new StudentSpecialty(specialtyInfo[0] + " " + specialtyInfo[1], int.Parse(specialtyInfo[2]));
                specialties.Add(currentSpecialty);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                string[] studentInfo = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                Student currentStudent = new Student(studentInfo[1] + " " + studentInfo[2], int.Parse(studentInfo[0]));
                students.Add(currentStudent);
                input = Console.ReadLine();
            }

            var linkedInfo = specialties.Join(
                students,
                specialty => specialty.FacNumber,
                student => student.FacNumber,
                (specialty, student) =>
                new
                {
                    StudentName = student.StudentName,
                    FacNum = specialty.FacNumber,
                    SpecName = specialty.SpecialityName
                }).ToList();

            linkedInfo.OrderBy(s => s.StudentName).ToList()
                .ForEach(s => Console.WriteLine(s.StudentName + " " + s.FacNum + " " + s.SpecName));
        }
    }

    public class StudentSpecialty
    {
        public StudentSpecialty(string specialityName, int facNumber)
        {
            this.SpecialityName = specialityName;
            this.FacNumber = facNumber;
        }

        public string SpecialityName { get; set; }

        public int FacNumber { get; set; }
    }

    public class Student
    {
        public Student(string studentName, int facNumber)
        {
            this.StudentName = studentName;
            this.FacNumber = facNumber;
        }

        public string StudentName { get; set; }

        public int FacNumber { get; set; }
    }
}
