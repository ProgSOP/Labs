using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5__semestr2_
{
    internal class Guitar : StringInstrument
    {
        public string _type { get; set; }
        public Guitar(string name, string lenth, string width, string sound, int stringCount, string type)
            : base(name, lenth, width, sound, stringCount)
        {
            _type = type;
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
            Console.WriteLine($"Type: {_type}");
            Console.WriteLine($"Lenth of Instrument: {_lenth}");
            Console.WriteLine($"Width of Instrument: {_width}");
            Console.WriteLine($"Sound: {_sound}");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
