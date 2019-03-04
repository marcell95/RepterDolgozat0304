using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class NincsIlyenJaratException : Exception
    {
        public NincsIlyenJaratException(string jaratszam) : base("A következő számmal nincs ilyen járat: " + jaratszam)
        {
            //Java
            //super("Nincs ilyen szamlaszam: " + szamlaszam);   
        }
    }
}
