using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Jaratkezelo();
            b.Ujjarat("1", "BP", "Moszkva", new DateTime(2019,03,04), 0);
            b.Ujjarat("2", "BP", "Párizs", new DateTime(2019, 02, 03), 60);
            b.Ujjarat("3", "Brüsszel", "London", new DateTime(2019, 01, 02), 120);
            b.Ujjarat("4", "Brüsszel", "Berlin", new DateTime(2018, 12, 01), 180);
            
            b.KesesModositas("1", 30);
            //Console.WriteLine(b.Egyenleg("5555"));

            b.Mikorindul("2");
            b.jaratokRepuloterrol("Brüsszel");
            //Console.WriteLine(b.Egyenleg("1234"));

            Console.ReadLine();
        }
    }
}
