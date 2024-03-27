using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestr_2_Laba3
{
    public class RozkladItems
    {

        public string StartingTime { get; set; }
        public string EndingTime { get; set; }
        public string Place { get; set; }
        public string Text { get; set; }



        public void Write()
        {
            Console.WriteLine($"Даннi про урок:");

            Console.WriteLine($"Початок: {StartingTime}");
            Console.WriteLine($"Закiнчення: {EndingTime}");
            Console.WriteLine($"Кабiнет: {Place}");
            Console.WriteLine($"Коментар: {Text}");
            Console.WriteLine("-----------");
            Console.WriteLine("     ");
        }


    }


    public class Rozklad
    {
        private List<RozkladItems> _RozkladItems;

        public Rozklad()
        {
            _RozkladItems = new List<RozkladItems>();
        }

        public void AddItem()
        {
            RozkladItems item = new RozkladItems();
            Console.WriteLine("Starting time");
            item.StartingTime = Console.ReadLine();
            Console.WriteLine("Ending time");
            item.EndingTime = Console.ReadLine();
            Console.WriteLine("Place ");
            item.Place = Console.ReadLine();
            Console.WriteLine("Text");
            item.Text = Console.ReadLine();
            _RozkladItems.Add(item);
        }
        public void Add(RozkladItems item)
        {
            _RozkladItems.Add(item);
        }


        public void Clear()
        {
            _RozkladItems.Clear();
        }
        public void Writer()
        {
            foreach (var item in _RozkladItems)
            {
                item.Write();
            }
        }
        public void Replace(string startingtimE, string endingtime, string place, string text)
        {
            int i = 0;
            for (i = 0; i < _RozkladItems.Count; i++)
            {

                if (startingtimE == _RozkladItems[i].StartingTime)
                {
                    _RozkladItems[i].EndingTime = endingtime;
                    _RozkladItems[i].Place = place;
                    _RozkladItems[i].Text = text;
                    break;
                }
            }

        }
        public void ReplacePlace(string startingtimE, string endingtime, string place, string text)
        {
            int i = 0;
            for (i = 0; i < _RozkladItems.Count; i++)
            {

                if (place == _RozkladItems[i].Place)
                {
                    _RozkladItems[i].StartingTime = startingtimE;
                    _RozkladItems[i].EndingTime = endingtime;

                    _RozkladItems[i].Text = text;
                    break;
                }
            }

        }

        public void Compare(Rozklad rozklad1)
        {
            int i = 0;
            for (i=0;i<_RozkladItems.Count;i++)
            {
                for (int j=0;j<rozklad1._RozkladItems.Count;j++)
                {
                    if ((_RozkladItems[i].StartingTime == rozklad1._RozkladItems[j].StartingTime) && (_RozkladItems[i].Place == rozklad1._RozkladItems[j].Place))
                    {

                        Console.WriteLine("\n"+ $"{j+1} Урок перетинаються");
                        Console.WriteLine("-----------------");

                    }
                }
            }
         

        }
    }
}
