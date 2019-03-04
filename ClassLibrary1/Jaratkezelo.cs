using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Jaratkezelo
    {

        List<Jarat> Jaratok = new List<Jarat>();

        
        internal Jarat getJaratByJaratszam(string jaratszam) {

            foreach (var j in Jaratok)
            {
                if (jaratszam.Equals(j.Jaratszam))
                {
                    return j;
                }
            }
            throw new NincsIlyenJaratException(jaratszam);
        }
        

        public void Ujjarat(string jaratszam, string repterhonnan, string repterhova, DateTime indulas, int keses)
        {

            var j = new Jarat(jaratszam, repterhonnan, repterhova, indulas, keses);

            foreach (var j in Jaratok)
            {
                if (jaratszam.Equals(j.Jaratszam))
                {
                    throw new VanIlyenJaratException(jaratszam);
                }
            }

            Jaratok.Add(j);
        }

        public void KesesModositas(string jaratszam, int keses)
        {
            foreach (var j in Jaratok)
            {
                if (jaratszam.Equals(j.Jaratszam))
                {
                    j.Keses += keses;
                    if (j.Keses < 0)
                    {
                        throw new NegativKesesException(jaratszam);
                        j.Keses = 0;

                    }
                }
            }
            throw new NincsIlyenJaratException(jaratszam);
        }


        public DateTime Mikorindul(string jaratszam)
        { 
            foreach (var j in Jaratok)
            {
                if (jaratszam.Equals(j.Jaratszam))
                {
                    return j.Indulas.AddMinutes(j.Keses);
                }
            }
            throw new ArgumentException("Nincs ilyen Járatszám!");
        }

        public List<string> jaratokRepuloterrol(string honnan)
        {

            List<string> repterek = new List<string>();

            foreach (var j in Jaratok)
            {
                if (honnan.Equals(j.HonnanRepter))
                {
                    repterek.Add(j.HonnanRepter);
                }
            }

            return repterek;
        }

    }
}
