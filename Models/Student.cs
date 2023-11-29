using Microsoft.AspNetCore.Mvc;

namespace Model_Binding_2___Modelde_Belirli_Alanları_Doldurmak.Models
{

    [Bind(nameof(Student.Name), nameof(Student.Surname), nameof(ClassRoom))]
    public class Student
    {
        public long IndentificationNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public ClassRoom ClassRoom { get; set; }
        
    }

    public class ClassRoom
    {
        public int ClassNumber { get; set; }
        public Teacher Teacher { get; set; }
    }

    public class Teacher
    {
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
    }
}
