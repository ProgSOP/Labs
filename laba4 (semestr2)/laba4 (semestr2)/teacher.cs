using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4__semestr2_
{
    internal class Teacher:Person
    {
        public bool ExistingInAuditory { get; set; }
        public Teacher(string Firstname,string Lastname, int age, bool existinginauditory,int id):
            base (Firstname,Lastname,age,id)
        {
            ExistingInAuditory = existinginauditory;
        }
        public void Write(Teacher teacher)
        {
            Console.WriteLine("Teacher : Id: " + teacher.Id.ToString() + " " + teacher.LastName.ToString() + " " + teacher.FirstName.ToString() + " " + teacher.Age.ToString());
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Existing in Auditory : " + teacher.ExistingInAuditory.ToString());
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Teacher HashCode : " + teacher.GetHashCode().ToString());
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("-----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ FirstName.GetHashCode() ^ Age.GetHashCode() ^ ExistingInAuditory.GetHashCode();

        }
        public string ToString(object? obj)
        {
            return $"{obj.ToString}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Teacher teacher) return obj.GetHashCode() == teacher.GetHashCode();
            return false;
        }
    }
}
