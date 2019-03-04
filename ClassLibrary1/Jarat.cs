using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Jarat
    {
        public string Jaratszam { get; set; }
        public string HonnanRepter { get; set; }
        public string HovaRepter { get; set; }
        public DateTime Indulas { get; set; }
        public int Keses { get; set; }

        public Jarat(string jaratszam, string honnanrepter, string hovarepter, DateTime indulas, int keses)
        {
            Jaratszam = jaratszam;
            HonnanRepter = honnanrepter;
            HovaRepter = hovarepter;
            Indulas = indulas;
            Keses = keses;
        }

    }
}
