using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace laba4__semestr2_
{
    internal class Student:Person
    {

        public int Course { get; set; }
        public bool HomeworkExisting { get; set; }

        public Student (int course, string lastname,string firstname,int age, int id, bool homeworkexisting):
            base (lastname,firstname,age, id)
        {
            Course = course;
            HomeworkExisting = homeworkexisting;
        }
        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ FirstName.GetHashCode() ^ Age.GetHashCode()^ Course.GetHashCode();

        }
        public string ToString(object? obj)
        {
            return $"{obj.ToString}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is  Student student) return obj.GetHashCode() == student.GetHashCode();
            return false;
        }
        public void Write(Student student)
        {
            Console.WriteLine("Student : Id: " + student.Id.ToString() + " " + student.LastName.ToString() + " " + student.FirstName.ToString() + " " + student.Age.ToString());
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Course : " + student.Course.ToString());
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Homework existing : " + student.HomeworkExisting.ToString());
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Student HashCode : " + student.GetHashCode().ToString());
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("-----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }

}
