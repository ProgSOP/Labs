
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace laba4__semestr2_
{
    internal class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        public Person(string lastName, string firstName, int age, int id)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Id = id;
        }
        public Person()
        { 
        
        }
        

        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ FirstName.GetHashCode() ^ Age.GetHashCode() ;
             
        }

        public string ToString(object? obj)
        {
            return $"{obj.ToString}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Person person)
            {
                return  this.GetHashCode() == person.GetHashCode();
            }

            return false;  
        }
        


        //public void Add()   
        //{
        //    Person NewPerson = new Person();
        //    Console.WriteLine("Write LastName");
        //    NewPerson.LastName = Console.ReadLine();
        //    Console.WriteLine("Write FirstName");
        //    NewPerson.FirstName = Console.ReadLine();
        //    Console.WriteLine("Write Age");
        //    NewPerson.Age = int.Parse(Console.ReadLine());
        //    people.Add(NewPerson);
        //}
        //public void AddTolist(Person person) 
        //{

        //    people.Add(person);

        //}

   
        //public Person FindPerson(string lastname)
        //{
            
        //    int i;
        //    Person person = new Person();

        //        if (people.Count >= 1)
        //        {
        //            for (i = 0; i < people.Count; i++)
        //            {
        //                if (lastname == people[i].LastName)
        //                {

        //                    return people[i];
                            
        //                }
        //                if (i == people.Count -1)
        //                {
        //                   Console.ForegroundColor = ConsoleColor.Red;
        //                   Console.WriteLine("There is no such person");
        //                   Console.ForegroundColor = ConsoleColor.White;
        //                   return null;
        //                }

        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("There is no people");
        //             return null;
        //        }

        //        return person;
            
        //}


   
    }
}

