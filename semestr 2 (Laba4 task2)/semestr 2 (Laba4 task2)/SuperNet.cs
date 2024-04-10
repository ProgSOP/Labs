using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace semestr_2__Laba4_task2_
{
    internal class SuperNet:Tariffs
    {

        public string _specialOffer { get; set; }


        public SuperNet(int id, string name, int price, string amoundofinternet, int numberofminutes, string specialoffer):
            base(id,name,price,amoundofinternet,numberofminutes)
        {
            _specialOffer = specialoffer;
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
            Console.WriteLine($"Tarrif SpecialOffer: {_specialOffer}");

        }
    }
}
