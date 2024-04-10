using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5__semestr2_
{
    internal class Djembe:Drums

    {

        public string _typeOfMembrana { get;set;}
        public Djembe(string name, string lenth, string width, string sound, string typeOfMembrana) :
            base(name, lenth, width, sound)
        {
            _typeOfMembrana = typeOfMembrana;
        }

        public override void DoSound()
        {
            Console.WriteLine(_sound);
        }

        public override void WriteInformationAboutInstrument()
        {
            Console.WriteLine($"-------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Name of Instrument: {_name}");
            Console.WriteLine($"TypeOfMembrana: {_typeOfMembrana}");
            Console.WriteLine($"Lenth of Instrument: {_lenth}");
            Console.WriteLine($"Width of Instrument: {_width}");
            Console.WriteLine($"Sound: {_sound}");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
