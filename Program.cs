using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzenetrogzito
{
    class Hivo
    {
        public int telefonSzam { get; set; }
        public string nev { get; set; }
        public string uzenet { get; set; }
        public DateTime datum { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            int sorszam1 = 0;
            int sorszam2 = 0;
            int sorszam3 = 0;
            int sorszam4 = 0;
            StreamWriter sw = new StreamWriter("../../titkarsag.txt", true);
            sw.Write("---------Titkárság üzenetei---------\n");
            StreamWriter sw2 = new StreamWriter("../../tanari.txt", true);
            sw.Write("---------Tanári üzenetei---------\n");
            StreamWriter sw3 = new StreamWriter("../../kollegium.txt", true); 
            sw.Write("---------Kollégium üzenetei---------\n");
            StreamWriter sw4 = new StreamWriter("../../konyvtar.txt", true);
            sw.Write("---------Könyvtár üzenetei---------\n");


            while (true)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine(" PG - ÜZENETRÖGZÍTŐ");
                Console.WriteLine("---------------------");


                Console.WriteLine("11 - titkárság\n14 - tanári\n15 - kollégium\n16 - könyvtár");
                Console.Write("\nVálasszon a fenti lehetőségek közül:");
                int valasztott = int.Parse(Console.ReadLine());

                switch (valasztott)
                {


                    case 11:
                        
                        Console.Clear();
                        Random rnd = new Random();
                        Console.Write("\nKérem adja meg a nevét: ");
                        string nev = Console.ReadLine();
                        Console.Write("Kérem adja meg az üzenetet: ");
                        string uzenet = Console.ReadLine();
                        string datum = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
                        string telefonSzam = "+36" + rnd.Next(100000000, 900000000).ToString();
                          
                        sorszam1 = sorszam1 + 1;
                        sw.WriteLine($"{sorszam1};{uzenet};{nev};{telefonSzam};{datum}");
                        Console.Write("Szeretne mégegy üzenetet hagyni? (i/n)");
                        sw.Close();
                        string valasz = Console.ReadLine();
                        if (valasz == "i")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Viszontlátásra!");
                            return;
                        }


                    case 14:
                        Console.Clear();
                        Random rnd2 = new Random();
                        Console.Write("\nKérem adja meg a nevét: ");
                        string nev2 = Console.ReadLine();
                        Console.Write("Kérem adja meg az üzenetet: ");
                        string uzenet2 = Console.ReadLine();
                        string datum2 = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
                        string telefonSzam2 = "+36" + rnd2.Next(100000000, 900000000).ToString();

                        sorszam2 = sorszam2 + 1;
                        sw2.WriteLine($"{sorszam2};{uzenet2};{nev2};{telefonSzam2};{datum2}");
                        sw2.Close();
                        Console.Write("Szeretne mégegy üzenetet hagyni? (i/n)");                        
                        string valasz2 = Console.ReadLine();
                        if (valasz2 == "i")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Viszontlátásra!");
                            return;
                        }

                    case 15:
                        Console.Clear();
                        Random rnd3 = new Random();
                        Console.Write("\nKérem adja meg a nevét: ");
                        string nev3 = Console.ReadLine();
                        Console.Write("Kérem adja meg az üzenetet: ");
                        string uzenet3 = Console.ReadLine();
                        string datum3 = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
                        string telefonSzam3 = "+36" + rnd3.Next(100000000, 900000000).ToString();

                        sorszam3 = sorszam3 + 1;
                        sw3.WriteLine($"{sorszam3};{uzenet3};{nev3};{telefonSzam3};{datum3}");
                        sw3.Close();
                        Console.Write("Szeretne mégegy üzenetet hagyni? (i/n)");
                        string valasz3 = Console.ReadLine();
                        if (valasz3 == "i")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Viszontlátásra!");
                            return;
                        }

                    case 16:
                        Console.Clear();
                        Random rnd4 = new Random();
                        Console.Write("\nKérem adja meg a nevét: ");
                        string nev4 = Console.ReadLine();
                        Console.Write("Kérem adja meg az üzenetet: ");
                        string uzenet4 = Console.ReadLine();
                        string datum4 = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
                        string telefonSzam4 = "+36" + rnd4.Next(100000000, 900000000).ToString();

                        sorszam4 = sorszam4 + 1;
                        sw4.WriteLine($"{sorszam4};{uzenet4};{nev4};{telefonSzam4};{datum4}");
                        sw4.Close();
                        Console.Write("Szeretne mégegy üzenetet hagyni? (i/n)");
                        string valasz4 = Console.ReadLine();
                        if (valasz4 == "i")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Viszontlátásra!");
                            return;
                        }


                }
            }








        }
         static void uzenetRogzito()
        {

            Random rnd = new Random();
            Console.Write("\nKérem adja meg a nevét: ");
            string nev = Console.ReadLine();
            Console.Write("Kérem adja meg az üzenetet: ");
            string uzenet = Console.ReadLine();
            string datum = DateTime.Now.ToString("yyyy.MM.dd HH:mm");
            StreamWriter sw = new StreamWriter("uzenetek.txt", true);


        }
        static void telefonSzam()
        {
            string telefonszam = "";

        }
    }
}
