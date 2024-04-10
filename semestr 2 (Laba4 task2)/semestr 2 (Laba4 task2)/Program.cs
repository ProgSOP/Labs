using semestr_2__Laba4_task2_;
using System.Collections;
using System.Drawing;


//Мобільний зв'язок. Визначити ієрархію тарифів мобільного компанії.
//Створити список тарифів компанії. Підрахувати загальну чисельність клієнтів.
//Провести сортування тарифів на основі розміру абонентської плати. Знайти тариф в компанії,
//що відповідає заданому діапазону параметрів.


List<Tariffs> ListOfTariffs = new List<Tariffs>();
List<Customers> ListOfCustomers = new List<Customers>();

//Tariffs Tariff1 = new Tariffs(1,"Turbo",165,"Inf gb",1600);
//ListOfTariffs.Add(Tariff1);

//Tariffs Tariff2 = new Tariffs(2,"JoicePro", 230, "35 gb", 1200);
//ListOfTariffs.Add(Tariff2);

//Tariffs Tariff3 = new Tariffs(3, "JoiceMax", 200, "50 gb", 1600);
//ListOfTariffs.Add(Tariff3);

//Tariffs Tariff4 = new Tariffs(4,"JoiceStart", 180, "25 gb", 800);
//ListOfTariffs.Add(Tariff4);

//Tariffs Tariff5 = new Tariffs(5, "Ubo Start", 39, "10 gb", 10);
//ListOfTariffs.Add(Tariff5);

//Tariffs Tariff6 = new Tariffs(6, "Super Net Unlim", 700, "Inf gb", 2000);
//ListOfTariffs.Add(Tariff6);

Tariffs Tariff1 = new Tariffs(1, "Start", 165,"25 gb",1000);
ListOfTariffs.Add(Tariff1);

JoiceStart Tariff2 = new JoiceStart(2, "JoiceStart", 200, "40 gb", 1200, 300);
ListOfTariffs.Add(Tariff2);

JoicePro Tariff3 = new JoicePro(3, "JoicePro", 250, "100 gb", 1500, 500, "350 bonuses");
ListOfTariffs.Add(Tariff3);

JoiceUltra Tariff4 = new JoiceUltra (4, "JoiceUltra", 400, "Inf gb", 3000, 650, "40 gb", "450 bonuses");
ListOfTariffs.Add(Tariff4);

SuperNet Tariff5 = new SuperNet (5, "SuperNet", 199, "50 gb", 2000,"Inf gb for messangers");
ListOfTariffs.Add(Tariff5);


Customers customer1 = new Customers(1, "Sternenko", "Sergiy", "+380505202577", Tariff1);
ListOfCustomers.Add(customer1);

Customers customer2 = new Customers(2, "Korchinskiy", "Dmytro", "+380235212581", Tariff2);
ListOfCustomers.Add(customer2);

Customers customer3 = new Customers(3, "Lyovkin", "Alexy", "+380321245776", Tariff3);
ListOfCustomers.Add(customer3);

Customers customer4 = new Customers(4, "Kokotko", "Olexa", "+380123591125", Tariff4);
ListOfCustomers.Add(customer4);

Customers customer5 = new Customers(5, "Fiso", "Robert", "+59881203", Tariff5);
ListOfCustomers.Add(customer5);

//Customers customer6 = new Customers(6, "Bondarenko", "Sofia", "+380988749391", Tariff6);
//ListOfCustomers.Add(customer6);


while (true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Write information about tarrifs -1");
    Console.WriteLine("Do sort -2");
    Console.WriteLine("Write all customers -3");
    Console.WriteLine("Found tariff by price and number of minutes -4");
    Console.WriteLine("Write detail information about tarrifs - <");


    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("Exit -0");
    Console.ForegroundColor= ConsoleColor.White;
    
    string choice = Console.ReadLine();

    if (choice == "2")
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.Clear();

        var s = ListOfTariffs.OrderBy(tariff => tariff.Price).ToList();

        foreach (Tariffs tariff in s)
        {
            tariff.Writer();
        }
        
    }

    else if (choice == "1")
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.Clear();

   

        foreach (Tariffs tariff in ListOfTariffs)
        {
                tariff.Writer();
        }
    }
    else if (choice == "<")
    {
        Tariff1.Writer();
        Tariff2.Writer();
        Tariff3.Writer();
        Tariff4.Writer();
        Tariff5.Writer();
    }
    else if (choice == "0")
    {
        break;
    }

    else if (choice == "3")
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Customers count: {ListOfCustomers.Count}");
        Console.ForegroundColor= ConsoleColor.White;
        foreach(Customers customer in ListOfCustomers)
        {
            customer.WriteCustomers();
        }
    }
    else if (choice == "4")
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.Clear();

        Console.WriteLine("Write Approx Price: ");
        int price = int.Parse(Console.ReadLine());
        Console.WriteLine("Write Approx Number of minutes");
        int numberofminutes = int.Parse(Console.ReadLine());

        bool tariffFound = false;
        foreach (Tariffs tariff in ListOfTariffs)
        {
            if (tariff.ConfrimSearch(price, numberofminutes) == true)
            {
                tariffFound = true;
                tariff.Writer();
            }
            

        }

        if (tariffFound == false)
        {
            Console.WriteLine("There is no such tariff");
        }
        

        
    }
    
    else
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Write 1 or 2");
        Console.ForegroundColor = ConsoleColor.White;
    }
}   


