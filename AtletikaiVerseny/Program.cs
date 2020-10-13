using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atleta> atletak = new List<Atleta>();

        static void Beolvas()
        {
            Console.WriteLine("1. feladat: adatok beolvasása");
            StreamReader file = new StreamReader("tavol.csv");
            while (!file.EndOfStream)
            {
                atletak.Add(new Atleta(Console.ReadLine()));
            }

            file.Close();

        }

        static void feladat2()
        {
            Console.WriteLine("\n2. feladat: Nevek és ugrások");
            foreach (var item in atletak)
            {
                Console.WriteLine("{0,10} {-1,10}",item.VezNev,item.Ugras);
            }

        }


        static void feladat3()
        {
            Console.WriteLine("\n3. feladat: Egyesületek:");
            List<string> egyesuletek = new List<string>();
            foreach (var e in atletak)
            {
                if (!egyesuletek.Contains(e.Egyesulet))
                {
                    egyesuletek.Add(e.Egyesulet);
                }
            }

            for (int i = 0; i < egyesuletek.Count; i++)
            {
                Console.WriteLine(egyesuletek[i]);
            }
        }

        static void feladat4()
        {
            Console.WriteLine("\n4. feladat: Legnagyobb ugrása:");
            int max = atletak[0].Ugras;
            int index = 0;
            for (int i = 0; i < atletak.Count; i++)
            {
                if (max < atletak[i].Ugras)
                {
                    max = atletak[i].Ugras;
                    index = i;
                }
            }
            

            

            Console.WriteLine(atletak[index].VezNev+": "+max+"cm" );
        }

        static void feladat5()
        {
            Console.Write("\n5.feladat: ");
            double osszeg = 0;
            for (int i = 0; i < atletak.Count; i++)
            {
                osszeg += (atletak[i].Ugras);
            }
            double atlag = osszeg / atletak.Count;
            int db = 0;
            for (int i = 0; i < atletak.Count; i++)
            {
                if (atletak[i].Ugras < atlag)
                {
                    db++;
                }
            }
            Console.WriteLine("Átlag alatti ugrások száma: "+db);


        }

        static void feladat6()
        {
            StreamWriter sw = new StreamWriter("versenyzok.txt");
            for (int i = 0; i < atletak.Count; i++)
            {
                sw.WriteLine(atletak[i].Rajtszam + ";" + atletak[i].VezNev);
            }

            sw.Close();
        }



        static void Main(string[] args)
        {
            Beolvas();
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            Console.ReadKey();
        }  
    }
}
