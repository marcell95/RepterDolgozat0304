using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class VanIlyenJaratException : Exception
    {
        public VanIlyenJaratException(string jaratszam) : base("A következő számmal már van járat: " + jaratszam)
        {
            //Java
            //super("Nincs ilyen szamlaszam: " + szamlaszam);   
        }
    }
}
