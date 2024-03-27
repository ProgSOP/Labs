

using semestr_2_Laba3;
using System.Drawing;

Rozklad rozklad = new Rozklad();
Console.WriteLine("Create first Rozklad");

Console.WriteLine("Create default RozkladItems? :)       1-yes");
string choice1 = Console.ReadLine();
if (choice1 == "1")
{
    RozkladItems items = new RozkladItems();

    items.StartingTime = "8:30";
    items.EndingTime = "9:30";
    items.Place = "room 301";
    items.Text = "First meeting";

    RozkladItems items1 = new RozkladItems();

    items1.StartingTime = "9:40";
    items1.EndingTime = "10:30";
    items1.Place = "room 309";
    items1.Text = "Second meeting";

    RozkladItems items2 = new RozkladItems();

    items2.StartingTime = "10:40";
    items2.EndingTime = "11:30";
    items2.Place = "room 309";
    items2.Text = "Homework";

    rozklad.Add(items);
    rozklad.Add(items1);
    rozklad.Add(items2);
   
}




while (true)
{

    Console.WriteLine("Pick metod");
    Console.WriteLine("1-Add");
    Console.WriteLine("2-Clear");
    Console.WriteLine("3-Write rozklad");
    Console.WriteLine("4-Replase rozklad item by StartingTime");
    Console.WriteLine("5-Replase rozklad item by Place");
    Console.WriteLine(" Write \"end\" to stop program");


    string choise = Console.ReadLine();

    if (choise == "1")
    {
        RozkladItems item = new RozkladItems();
        rozklad.AddItem();
    }
    if (choise == "2")
    {
        rozklad.Clear();
        Console.WriteLine("Rozklad cleard");
        Console.WriteLine("       ");
     
    }
    if (choise == "3")
    {
        rozklad.Writer();
    }
    if (choise == "4")
    {
        Console.WriteLine("Write StartingTime of the class you want to change");
        string startingtimechange = Console.ReadLine();
        Console.WriteLine("Write endingtime of the class you want to change");
        string endingtimechange = Console.ReadLine();
        Console.WriteLine("Write Place of the class you want to change");
        string Placechange = Console.ReadLine();
        Console.WriteLine("Write Text of the class you want to change");
        string TextChange = Console.ReadLine();

        rozklad.Replace(startingtimechange,endingtimechange,Placechange,TextChange);
    }
    if (choise == "5")
    {
        Console.WriteLine("Write Place of the class you want to change");
        string Placechange1 = Console.ReadLine();
        Console.WriteLine("Write endingtime of the class you want to change");
        string endingtimechange1 = Console.ReadLine();
    
        Console.WriteLine("Write StartingTime of the class you want to change");
        string startingtimechange1 = Console.ReadLine();
        Console.WriteLine("Write Text of the class you want to change");
        string TextChange1 = Console.ReadLine();
        rozklad.ReplacePlace(startingtimechange1, endingtimechange1, Placechange1, TextChange1);
    }
    if (choise == "end")
    {
        break;
    }

}
//------------------------------------------------------------------------------------//



Rozklad rozklad1 = new Rozklad();
Console.WriteLine("\n"+ "Create second Rozklad");
Console.WriteLine("Create default RozkladItems? :)       1-yes");
string choice2 = Console.ReadLine();
if (choice2 == "1")
{
    RozkladItems items = new RozkladItems();

    items.StartingTime = "8:30";
    items.EndingTime = "9:30";
    items.Place = "room 301";
    items.Text = "First meeting";

    RozkladItems items1 = new RozkladItems();

    items1.StartingTime = "9:40";
    items1.EndingTime = "10:30";
    items1.Place = "room 309";
    items1.Text = "Second meeting";

    RozkladItems items2 = new RozkladItems();

    items2.StartingTime = "10:40";
    items2.EndingTime = "11:30";
    items2.Place = "room 309";
    items2.Text = "Homework";

    rozklad1.Add(items);
    rozklad1.Add(items1);
    rozklad1.Add(items2);

}




while (true)
{

    Console.WriteLine("Pick metod");
    Console.WriteLine("1-Add");
    Console.WriteLine("2-Clear");
    Console.WriteLine("3-Write rozklad");
    Console.WriteLine("4-Replase rozklad item by StartingTime");
    Console.WriteLine("5-Replase rozklad item by Place");
    Console.WriteLine("6-Compare rozklads");
    Console.WriteLine(" Write \"end\" to stop program");


    string choise = Console.ReadLine();

    if (choise == "1")
    {
        //RozkladItems item = new RozkladItems();
        rozklad1.AddItem();
    }
    if (choise == "2")
    {
        rozklad1.Clear();
        Console.WriteLine("Rozklad cleard");
        Console.WriteLine("       ");

    }
    if (choise == "3")
    {
        rozklad1.Writer();
    }
    if (choise == "4")
    {
        Console.WriteLine("Write StartingTime of the class you want to change");
        string startingtimechange = Console.ReadLine();
        Console.WriteLine("Write endingtime of the class you want to change");
        string endingtimechange = Console.ReadLine();
        Console.WriteLine("Write Place of the class you want to change");
        string Placechange = Console.ReadLine();
        Console.WriteLine("Write Text of the class you want to change");
        string TextChange = Console.ReadLine();

        rozklad1.Replace(startingtimechange, endingtimechange, Placechange, TextChange);
    }
    if (choise == "5")
    {
        Console.WriteLine("Write Place of the class you want to change");
        string Placechange1 = Console.ReadLine();
        Console.WriteLine("Write endingtime of the class you want to change");
        string endingtimechange1 = Console.ReadLine();

        Console.WriteLine("Write StartingTime of the class you want to change");
        string startingtimechange1 = Console.ReadLine();
        Console.WriteLine("Write Text of the class you want to change");
        string TextChange1 = Console.ReadLine();
        rozklad1.ReplacePlace(startingtimechange1, endingtimechange1, Placechange1, TextChange1);

    }

    if (choise == "6")
    {

        Console.WriteLine("\n"+ "Порiвняння: ");
        rozklad.Compare(rozklad1);

        
    }
    if (choise == "end")
    {
        break;
    }

}





