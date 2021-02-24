using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA210224
{
    class Program
    {
        static void Main()
        {
            //Feladatok0102();
            //Feladatok0103();
            //Feladatok0104();
            //Feladatok0104_b();
            //Feladatok0106_b();
            //Feladatok0107();
            Feladatok0110();
            Console.ReadKey();
        }

        private static void Feladatok0110()
        {
            Console.Write("súlyod: ");
            Console.Write("magasságod: ");

            float tti = 0;

            if (tti < 16) Console.WriteLine("");
            else if (tti < 17) Console.WriteLine("....");
        }

        private static void Feladatok0107()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"c = {Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))}");


            Console.WriteLine("--------------------");

            int aNegyzet = (int)Math.Pow(a, 2);
            int bNegyzet = (int)Math.Pow(b, 2);
            int cNegyzet = aNegyzet + bNegyzet;
            double c = Math.Sqrt(cNegyzet);

            Console.WriteLine("c csak lassan = " + c);
        }
        private static void Feladatok0106_b()
        {
            int ezerhuszonnegy = (int)Math.Pow(2, 10);
            double ezerhiszonnegyMegegyszer = Math.Pow(2, 10);

            Console.WriteLine(ezerhuszonnegy);

            int ketto = (int)Math.Sqrt(4);
            Console.WriteLine(ketto);
            
            Console.WriteLine($"pi = {Math.PI}");

            int kettoV2 = (int)Math.Pow(8, 1 / (float)3);
            Console.WriteLine(kettoV2);
        }
        private static void Feladatok0104_b()
        {
            var x1 = 12; // -->> nincs utána semmi, akkor a lit. int32
            var x3 = 12.0; // -->> van benne tizedes pont, akkor double
            var x7 = 12D; // double
            #region fontos
            var x4 = 12.0F; // -->> ha van a végén F vagy f, akkor float
            #endregion
            var x8 = 12m; //decimal <- ő a legnagyobb kapacitású
            var x2 = 12L; //-->> nincs utána semmi, de nagyobb, mint 2.2M akkor long (vagy ha van utána L vagy l betű))
            var x5 = "3"; // -->> string
            var x6 = '4'; // -->> char
            var x9 = true; //vagy false, akkor bool;


            int a = 12;
            int b = 5;

            Console.WriteLine(a / (float)b);
            Console.WriteLine(12 / 5F);
        }
        private static void Feladatok0104()
        {
            Console.Write("euro árfolyama: ");
            float arfolyam = float.Parse(Console.ReadLine());

            Console.Write("ennyi eurom van: ");
            int euro = int.Parse(Console.ReadLine());

            //float forint = arfolyam * euro;
            Console.WriteLine("--------------------");

            Console.WriteLine($"A pénzem {arfolyam * euro} Ft-ot ér.");
        }
        private static void Feladatok0103()
        {
            Console.Write("havi fizetés: ");

            //parsing
            int havi = int.Parse(Console.ReadLine());

            //converting
            //int haviV2 = Convert.ToInt32(Console.ReadLine());

            //casting - cast-olni stringeket NEM lehet
            //int haviV3 = (int)300.00;

            //int eves = havi * 12;

            Console.WriteLine("--------------------");

            Console.WriteLine("éves fizetés: {0:N0} Ft", havi * 12);
        }
        private static void Feladatok0102()
        {
            Console.Write("Első veteknév: ");
            string vNev1 = Console.ReadLine();
            Console.Write("Második veteknév: ");
            string vNev2 = Console.ReadLine();
            Console.Write("Első keresztnév: ");
            string kNev1 = Console.ReadLine();
            Console.Write("Második keresztnév: ");
            string kNev2 = Console.ReadLine();

            Console.WriteLine("--------------------");

            Console.WriteLine($"{vNev1} {kNev1}");
            Console.WriteLine($"{vNev1} {kNev2}");
            Console.WriteLine($"{vNev2} {kNev1}");
            Console.WriteLine($"{vNev2} {kNev2}");
        }
    }
}
