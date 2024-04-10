using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace laba_5__semestr2_
{
    internal abstract class Instrument
    {
        protected string _name { get; set; }
        protected string _lenth { get; set; }
        protected string _width { get; set; }
        protected string _sound { get; set; }

        protected Instrument (string name, string lenth, string width, string sound)
        {
           _name = name;
            _lenth = lenth;
            _width = width;
            _sound = sound;
        }

        public abstract void DoSound();
        public abstract void WriteInformationAboutInstrument();

  
    }
}
