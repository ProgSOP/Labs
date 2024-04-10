using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba_5__semestr2_
{
    internal class windInstruments : Instrument
    {
        public windInstruments(string name, string lenth, string width, string sound) :
        base(name, lenth, width, sound)
        {

        }
        public override void WriteInformationAboutInstrument()
        {
            Console.WriteLine($"-------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Name of Instrument: {_name}");
            Console.WriteLine($"Lenth of Instrument: {_lenth}");
            Console.WriteLine($"Width of Instrument: {_width}");
            Console.WriteLine($"Sound: {_sound}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void DoSound()
        {
            Console.WriteLine(_sound);
        }


    }
}
