using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestr_2__Laba4_task2_
{
     public class Tariffs
    {
        protected int _id { get; set; }
        protected string _name { get; set; }
        protected int _price { get; set; }
        protected string _amountOfInternet { get; set; }
        protected int _numberOfMinutes { get; set; }    

        public Tariffs(int id, string name, int price, string amoundofinternet, int numberofminutes)
        {
            _id = id;
            Name = name;
            Price = price;
            _amountOfInternet = amoundofinternet;
            _numberOfMinutes = numberofminutes;  
        }
         
        public int Price
        {
            get { return _price; }
            set {
                if (value <= 3000 && value >= 100)
                {
                    _price = value;
                }
                else 
                {
                    _price = 150;
                }
                }
        }

        public string Name
        { 
            get { return _name; } 
            set {
                
                if (value == "Start" || value == "JoiceStart" || value == "JoicePro" || value == "JoiceUltra"|| value =="SuperNet")
                {
                    _name = value;
                }
                else
                {
                    _name = "Unknown tarif";
                }
                    
                }
        }
        

        public void Writer()
        {
            Console.WriteLine($"Tarrif: ");
            Console.WriteLine($"Tarrif Id: {_id}");
            Console.WriteLine($"Tarrif name: {_name}");
            Console.Write($"Tarrif price: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Price} UAH\n");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine($"Tarrif Amound of Internet: {_amountOfInternet}");
            Console.WriteLine($"Tarrif Amound of Minutes: {_numberOfMinutes}");

        }
            public bool ConfrimSearch(int price,int numberofminutes)
            {
                if (Math.Abs(price - _price) <= 50 && Math.Abs(numberofminutes - _numberOfMinutes) <= 500)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
    }
}
