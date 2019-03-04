using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestFixture]   //megjelöli tesztosztályként
    class JaratTeszt
    {
        Jaratkezelo b;

        [SetUp]
        public void SetUp()
        {
            b = new Jaratkezelo();

            b.Ujjarat("1", "BP", "Moszkva", new DateTime(2019, 03, 04), 0);
            b.Ujjarat("2", "BP", "Párizs", new DateTime(2019, 02, 03), 60);
            b.Ujjarat("3", "Brüsszel", "London", new DateTime(2019, 01, 02), 120);
            b.Ujjarat("4", "Brüsszel", "Berlin", new DateTime(2018, 12, 01), 180);
        }

        [Test]
        public void UjJaratLetrehozasaSiker()
        {
            b.Ujjarat("1", "BP", "Moszkva", new DateTime(2019, 03, 04), 0);

        }

        [Test]
        public void UjJaratLetrehozasaHiba()
        {
            b.Ujjarat("1", "BP", "Moszkva", new DateTime(2019, 03, 04), 0);
            Assert.Throws < VanIlyenJaratException >(
                () => {         //meg is írhattuk volna egy privát függvényként
                    b.Ujjarat("1", "BP", "Moszkva", new DateTime(2019, 03, 04), 0);
                }
            );

        }

        [Test]
        public void KesesModositasSiker()
        {
            string tempjaratszam = "1";
            int tempkeses = 30;
            b.KesesModositas(tempjaratszam, tempkeses);
            Assert.AreEqual(b.getJaratByJaratszam(tempjaratszam).Keses, tempkeses);

        }

        [Test]
        public void KesesModositasHiba()
        {
            string tempjaratszam = "1";
            int tempkeses = -30;

            Assert.Throws<NegativKesesException>(
                () => {      
                    b.KesesModositas(tempjaratszam, tempkeses);
                }
            );

        }

        [Test]
        public void KesesModositasNincsIlyenHiba()
        {
            string tempjaratszam = "5";
            int tempkeses = 30;

            Assert.Throws<NincsIlyenJaratException>(
                () => {       
                    b.KesesModositas(tempjaratszam, tempkeses);
                }
            );

        }

        [Test]
        public void MikorIndulSiker()
        {
            string tempjaratszam = "4";

            Assert.AreEqual(b.getJaratByJaratszam(tempjaratszam).Indulas.AddMinutes(b.getJaratByJaratszam(tempjaratszam).Keses), 
                b.Mikorindul(tempjaratszam));
        }


        [Test]
        public void MikorIndulHiba()
        {
            string tempjaratszam = "5";

            Assert.Throws<ArgumentException>(
                () => {        
                    b.Mikorindul(tempjaratszam);
                }
            );

        }

        [Test]
        public void jaratokRepuloterrolSiker()
        {
            string temphonnan = "Brüsszel";

            b.jaratokRepuloterrol(temphonnan);

        }

        [Test]
        public void jaratokRepuloterrolUresLista()
        {
            string temphonnan = "Róma";

            b.jaratokRepuloterrol(temphonnan);

        }


    }
}
