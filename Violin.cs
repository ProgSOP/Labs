using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5__semestr2_
{
    internal class Violin : StringInstrument
    {
        public string _condition { get; set; }
        public Violin(string name, string lenth, string width, string sound, int stringCount, string condition)
            : base(name, lenth, width, sound, stringCount)
        {
            _condition = condition;
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
            Console.WriteLine($"Condition: {_condition}");
            Console.WriteLine($"Lenth of Instrument: {_lenth}");
            Console.WriteLine($"Width of Instrument: {_width}");
            Console.WriteLine($"Sound: {_sound}");
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
