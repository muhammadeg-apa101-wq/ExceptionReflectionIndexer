using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerReflectionException.Models
{
    public class Students : StudentInfo
    {


        public List<Students> students { get; set; }

        public Students()
        {
            students = new List<Students>();
        }

        public Students this[int index] 
        {
           get { return students[index]; }
            set { students[index] = value; }
        }

        public void AddStudentInfo(Students student) 
        {
            students.Add(student);
        }

        public void ShowAllStudentsInfo() 
        {
            foreach (var student in students) 
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentName}, Surname: {student.StudentSurname}");
            }
        }
    }
}
