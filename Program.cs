using System.Diagnostics;
using System;
using System.Media;
using laba_5__semestr2_;


//List<Instrument> instruments = new List<Instrument>();
//Instrument eks = new Instrument();
//instruments.Add(eks);
//eks.Name = "Vasya";
//Instrument eks2 = new Instrument();
//eks2.Name = "Sonya";
//instruments.Add(eks2);

//instruments.Sort();


//List<Drums> drums = new List<Drums>();
//List<StringInstrument> stringInstruments = new List<StringInstrument>();


//StringInstrument Guitar = new StringInstrument("Guitar", "150 cm", "30 cm","Бринь",8); 
//stringInstruments.Add(Guitar);
//StringInstrument Violin = new StringInstrument("Violin","75 cm", "20 cm", "viui..",4);
//stringInstruments.Add(Violin);
//StringInstrument Stick = new StringInstrument("Stick", "32 cm", "12 cm", "ad", 123);
//stringInstruments.Add(Stick);


//Drums Cymbal = new Drums("Cymbal","50 cm", "50 cm", "ТЫыыыЩ....." );
//Drums Percusion = new Drums("Percusion","10 cm", "20 cm", "цык...Цык...Ыцк");
//Drums FloorTom = new Drums("Floor Tom", "20", "20 cm", "PUMmmmm....");
//Drums stick = new Drums("Stick", "1 cm", "1 cm", "asd");



//drums.Add(Cymbal);
//drums.Add(Percusion );
//drums.Add(stick);
//drums.Add(FloorTom );

//void Start()
//{
//    Console.ForegroundColor = ConsoleColor.DarkMagenta;
//    Console.WriteLine("----------------");
//    Console.WriteLine("1- Write Drums");
//    Console.WriteLine("2- Write Stings Instruments");
//    Console.WriteLine("0- exit");

//    Console.ForegroundColor = ConsoleColor.White;
//}



//while (true)
//{
//   Start();
//   string choice = Console.ReadLine();
//   if (choice == "1")
//   {

//        foreach (Drums drum in drums)
//        {
//            if (drum.Name != "The are not such type")
//            {
//                drum.WriteInformationAboutInstrument();
//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine($"-------------------------");
//                Console.WriteLine("Incorect Name!");
//                Console.WriteLine($"-------------------------");
//                Console.ForegroundColor = ConsoleColor.White;

//            }
//        }
//    }

//    else if (choice == "2")
//    {
//        foreach (StringInstrument stringInstrument in stringInstruments)
//        {
//            if (stringInstrument.Name != "There is no such value")
//            {
//                stringInstrument.WriteInformationAboutInstrument();
//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine($"-------------------------");
//                Console.WriteLine("Incorect Name!");
//                Console.WriteLine($"-------------------------");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//        }
//    }

//    else if (choice == "0")
//    {
//        break;
//    }
//}


//Створити суперклас Музичний інструмент і класи Ударний,
//Струнний, Духовий, Джембе, Барабан, Скрипка, Кларнет, Гітара.
//Створити масив об'єктів Оркестр. Видати склад оркестру. Видати звук кожного інструменту.




List<Instrument> orcestra = new List<Instrument>();



orcestra.Add(new Clarinet("Clarnet", "12cm", "5cm", "IOU", "wood"));
orcestra.Add(new Guitar("BC-Rich Chuck Shuldiner edition(Leprosy and SpiritualHealing recordet)", "150cm", "50cm", "BROooI", 6, "Electrical"));
orcestra.Add(new Djembe("ESPPVC-15C (12 FIBER) Джембе", "60cm", "12cm", "pum...pum...cam", "Syntetic"));
orcestra.Add(new Violin("Arvada VIO-180 fiolin 4/4", "30cm", "15cm", "IVoii...", 4, "Good"));
orcestra.Add(new Snare("TAMA PSS146 Малий барабан", "15cm", "15cm","PAa..","HighTuned"));


while (true)
{
    Console.WriteLine("1- Write all orcestra members");
    Console.WriteLine("2- Do all the sounds");
    Console.WriteLine("3- exit");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        foreach (Instrument instrument in orcestra)
        {
            instrument.WriteInformationAboutInstrument();
        }
    }
    else if (choice == "2") 
    {
        foreach(Instrument instrument in orcestra)
        {
            
            instrument.DoSound();
        }
    }
    else if (choice == "3") 
    {
        break;
    }
}



    
