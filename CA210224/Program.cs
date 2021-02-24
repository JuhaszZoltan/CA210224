using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA210224
{
    class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            //Feladatok0102();
            //Feladatok0103();
            //Feladatok0104();
            //Feladatok0104_b();
            //Feladatok0106_b();
            //Feladatok0107();
            //Feladatok0110();
            //Feladatok0111();

            //DatumIdoF01();
            //RandomDolgok();

            Console.ReadKey();
        }

        private static void RandomDolgok()
        {
            //[0, int.MaxValue)
            //int v1 = rnd.Next();

            //[0, 10)
            //int v2 = rnd.Next(10);

            //[-200, 200]
            //int veletlen = rnd.Next(-200, 201);

            //0 és 1 közötti 64 biten ábrázolt lebegőpontos szám
            //double veletlenDouble = rnd.NextDouble();
        }
        private static void DatumIdoF01()
        {
            Console.Write("üzemidő másodpercben: ");
            long sec = long.Parse(Console.ReadLine());

            //TimeSpan elteltIdo = new TimeSpan(sec * 10000000);
            TimeSpan elteltIdo = new TimeSpan(0, 0, (int)sec);

            Console.WriteLine($"{elteltIdo.Days}.{elteltIdo.Hours}:{elteltIdo.Minutes}:{elteltIdo.Seconds}");

            Console.WriteLine(elteltIdo.Days);


            TimeSpan ido01 = new TimeSpan(10, 10, 00);
            TimeSpan ido02 = new TimeSpan(2, 20, 00);

            Console.WriteLine(ido01 + ido02);

            DateTime szul = new DateTime(1990, 07, 11);
            DateTime fog = szul - new TimeSpan(270, 0, 0, 0);
            Console.WriteLine(DateTime.Now - szul);
            Console.WriteLine(szul.ToLongDateString());

            Console.WriteLine();
        }
        private static void Feladatok0111()
        {
            Console.Write("hordó térfogata(l): ");
            int hordo = int.Parse(Console.ReadLine());
            Console.Write("kancsó térfogata(l): ");
            int kancso = int.Parse(Console.ReadLine());

            Console.WriteLine($"{hordo / kancso} teli kancsómérhető ki");
            Console.WriteLine($"a hordóban { hordo % kancso} liter cucc marad");
            Console.WriteLine("a hordó és a kancsó hányadosa: {0:0.00}", hordo / (float)kancso);
        }
        private static void Feladatok0110()
        {
            Console.Write("súlyod (kg): ");
            float kg = float.Parse(Console.ReadLine());
            Console.Write("magasságod (cm): ");
            float m = float.Parse(Console.ReadLine()) / 100;
            float tti = kg / (float)Math.Pow(m, 2);

            Console.WriteLine("Testtömegindexed alapját te az alábbi testsúlykategóriába tartozol:");
            if (tti < 16) Console.WriteLine("súlyos soványság");
            else if (tti < 17) Console.WriteLine("mérsékelt soványság");
            else if (tti < 18.5) Console.WriteLine("enyhe soványság");
            else if (tti < 25) Console.WriteLine("normális testsúly");
            else if (tti < 30) Console.WriteLine("túlsúlyos");
            else if (tti < 35) Console.WriteLine("I.fokú elhízás");
            else if (tti < 40) Console.WriteLine("II. fokú elhízás");
            else Console.WriteLine("III. fokú (súlyos) elhízás");


            /*
            if(feltétel)
            {
                kód, ha a feltétel igaz
            }
            else
            {
                kód, ha a feltétel hamis
            }
            */
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
