using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestr_2__Laba4_task2_
{
    
    internal class JoiceStart:Tariffs
    {
        public int _numberOfRouming { get; set; }
        public JoiceStart(int id, string name, int price ,string amoundOfInternet,int NumberOfMinutes, int NumberOfRouming):
            base (id,name,price,amoundOfInternet,NumberOfMinutes)
        {
            _numberOfRouming = NumberOfRouming;
        }

        public void Writer()
        {
            Console.WriteLine($"Tarrif: ");
            Console.WriteLine($"Tarrif Id: {_id}");
            Console.WriteLine($"Tarrif name: {_name}");
            Console.Write($"Tarrif price: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Price} UAH\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Tarrif Amound of Internet: {_amountOfInternet}");
            Console.WriteLine($"Tarrif Amound of Minutes: {_numberOfMinutes}");
            Console.WriteLine($"Tarrif Number of Minutes(Rouming): {_numberOfRouming}");

        }
    }

}
