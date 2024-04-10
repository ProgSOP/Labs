using laba4__semestr2_;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Nodes;


//Створити об'єкт класу Персона
//використовуючи клас Викладач, Студент.
//Методи: курс студента, наявність в аудиторії, перевірка домашніх завдань, вік.


List<Person> people = new List<Person>();
List<Student> students = new List<Student>();
List<Teacher> teachers = new List<Teacher>();

Person persontest = new Person("Sternanko", "Maria", 17, 1);
Person persontest1 = new Person("Shuldiner", "Chuck", 19, 2);
Person persontest2 = new Person("Lyovkin", "Oleg", 48, 3);
Person persontest3 = new Person("Antonova", "Nastya", 18, 4);
Person persontest4 = new Person("Shuldiner", "Chuck", 19, 5);



people.Add(persontest);
people.Add(persontest1);
people.Add(persontest2);
people.Add(persontest3);
people.Add(persontest4);


while (true)
{
    Console.WriteLine("        ");
    Console.WriteLine("1-Write information about 4 persons");
    Console.WriteLine("2-Compare Hash-codes");
    Console.WriteLine("3-To do person student or teacher");
    Console.WriteLine("4- Write Students");
    Console.WriteLine("5- Write Teachers");
    Console.WriteLine("6- Save Information about persones to Json file");
    Console.WriteLine("0- exit");

    string choice2;
    choice2 = Console.ReadLine();

    if (choice2 == "1")
    {
        foreach (Person person in people)
        {
            WritePerson(person);
        }
    }
    if (choice2 == "2")
    {
        Console.WriteLine("Write first Id");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Write second Id");
        int id1 = int.Parse(Console.ReadLine());

        for (int i = 0; i < people.Count; i++)
        {
            if (id == people[i].Id)
            {
                for (int j = 0; j < people.Count; j++)
                {
                    if (id1 == people[j].Id)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("This 2 persones hashes is equals?");
                        Console.WriteLine(people[i].Equals(people[j]).ToString());
                        Console.WriteLine("----------------------------------");
                    }
                }
            }
        }


    }
    if (choice2 == "3")
    {
    
        Console.WriteLine("Pick Id");
        int id = int.Parse(Console.ReadLine());
     

            for (int i = 0; i < people.Count; i++)
            {
                if (id == people[i].Id)
                {
                    while (true)
                    {
                        Console.WriteLine("1-Do it student");
                        Console.WriteLine("2-Do it teacher");
                        int choice3 = int.Parse(Console.ReadLine());

                        if (choice3 == 1)
                        {

                            while (true)
                            {
                                Console.WriteLine("Write his Course");
                                int course = int.Parse(Console.ReadLine());

                                if (course >= 1 && course <= 4)
                                {

                                    while (true)
                                    {
                                        Console.WriteLine("Write his Homework existing (true/false)");
                                        string s1 = Console.ReadLine();
                                        bool homeworkexisting;
                                        if (s1 == "true")
                                        {

                                            homeworkexisting = true;

                                            Student student = new Student(course, people[i].LastName, people[i].FirstName, people[i].Age, people[i].Id, homeworkexisting);
                                            students.Add(student);
                                            break;
                                        

                                        }
                                        if (s1 == "false")
                                        {

                                            homeworkexisting = false;

                                            Student student = new Student(course, people[i].LastName, people[i].FirstName, people[i].Age, people[i].Id, homeworkexisting);
                                            students.Add(student);
                                            break;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Write true/false");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }


                                    }


                                    break;

                                }
                            



                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Course must be >=1 and <=4");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }


                        break;

                        }
                   




                        if (choice3 == 2)
                        {
                   
                         
                            while (true)
                            {
                            Console.WriteLine("Douse he exist in auditory? 1-yes 2-no");
                            string s = Console.ReadLine();
                            bool ExistingInAuditory;

                            if (s == "1")
                                {
                                    ExistingInAuditory = true;

                                    Teacher teacher = new Teacher(people[i].FirstName, people[i].LastName, people[i].Age, ExistingInAuditory, people[i].Id);
                                    teachers.Add(teacher);
                                    break;
                                }
                                if (s == "2")
                                {
                                    ExistingInAuditory = false;

                                    Teacher teacher = new Teacher(people[i].FirstName, people[i].LastName, people[i].Age, ExistingInAuditory, people[i].Id);
                                    teachers.Add(teacher);
                                    break;
                                }
                                else

                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Write 1 or 2 ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            
                            }
                            break;
                        }
                    }
                }
            }
    }

    if (choice2 == "4")
    {
        if (students.Count >= 1)
        {
            foreach (Student student in students)
            {

                student.Write(student);
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There is no students");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    if (choice2 == "5")
    {
        if (teachers.Count >= 1)
        {
            foreach (Teacher teacher in teachers)
            {

                teacher.Write(teacher);
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There is no teachers");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    if (choice2 == "6")
    {
        string path = "C:\\ROFL\\Учеба\\КПІ\\прога\\laba 3\\Json\\Json.txt";

        SaveToJson(path, people);
        

        

    }
    if (choice2 == "0")
    {
        break;
    }
}


void WritePerson(Person person)
{

    Console.WriteLine("Id: " + person.Id.ToString() + " " + "Person : " + person.LastName.ToString() + " " + person.FirstName.ToString() + " " + person.Age.ToString());
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Person HashCode : " + person.GetHashCode().ToString());
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("-----------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.White;
}

void SaveToJson(string path, List<Person> people)
{

    StringBuilder jsonBuilder = new StringBuilder();
    jsonBuilder.Append("[");
    foreach (Person person in people)
    {
        jsonBuilder.AppendLine();
        jsonBuilder.Append("{");
        jsonBuilder.Append("Id: " + person.Id.ToString() + " " + "Person : " + person.LastName.ToString() + " " + person.FirstName.ToString() + " " + person.Age.ToString());
        jsonBuilder.Append("Person HashCode : " + person.GetHashCode().ToString());

        jsonBuilder.Append("}");
        jsonBuilder.AppendLine();
    }
    jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
    jsonBuilder.Append("]");

    File.WriteAllText(path, jsonBuilder.ToString());
}

 