using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class NegativKesesException : Exception
    {
        public NegativKesesException(string szamlaszam) : base("Nem lehet negatív a késés értéke. Az érintett járat száma: " + szamlaszam)
        {
            //Java
            //super("Nincs ilyen szamlaszam: " + szamlaszam);   
        }
    }
}
