using System;
using System.IO;

namespace uzenetrogzito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sorszam1 = 0;
            int sorszam2 = 0;
            int sorszam3 = 0;
            int sorszam4 = 0;

           
            File.WriteAllText("../../titkarsag.txt", "---------Titkárság üzenetei---------\n");
            File.WriteAllText("../../tanari.txt", "---------Tanári üzenetei---------\n");
            File.WriteAllText("../../kollegium.txt", "---------Kollégium üzenetei---------\n");
            File.WriteAllText("../../konyvtar.txt", "---------Könyvtár üzenetei---------\n");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------");
                Console.WriteLine(" PG - ÜZENETRÖGZÍTŐ");
                Console.WriteLine("---------------------");

                Console.WriteLine("11 - titkárság\n14 - tanári\n15 - kollégium\n16 - könyvtár");
                Console.Write("\nVálasszon a fenti lehetőségek közül: ");
                if (!int.TryParse(Console.ReadLine(), out int valasztott))
                {
                    Console.WriteLine("Hibás bemenet. Nyomjon egy gombot a folytatáshoz...");
                    Console.ReadKey();
                    continue;
                }

                string nev, uzenet, datum, telefonSzam;
                Random rnd = new Random();

                Console.Clear();
                Console.Write("\nKérem adja meg a nevét: ");
                nev = Console.ReadLine();
                Console.Write("Kérem adja meg az üzenetet: ");
                uzenet = Console.ReadLine();
                datum = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
                telefonSzam = "+36" + rnd.Next(100000000, 900000000).ToString();

                string sor = "";

                switch (valasztott)
                {
                    case 11:
                        sorszam1++;
                        sor = $"{sorszam1};{uzenet};{nev};{telefonSzam};{datum}";
                        using (StreamWriter sw = File.AppendText("../../titkarsag.txt"))
                        {
                            sw.WriteLine(sor);
                        }
                        break;

                    case 14:
                        sorszam2++;
                        sor = $"{sorszam2};{uzenet};{nev};{telefonSzam};{datum}";
                        using (StreamWriter sw2 = File.AppendText("../../tanari.txt"))
                        {
                            sw2.WriteLine(sor);
                        }
                        break;

                    case 15:
                        sorszam3++;
                        sor = $"{sorszam3};{uzenet};{nev};{telefonSzam};{datum}";
                        using (StreamWriter sw3 = File.AppendText("../../kollegium.txt"))
                        {
                            sw3.WriteLine(sor);
                        }
                        break;

                    case 16:
                        sorszam4++;
                        sor = $"{sorszam4};{uzenet};{nev};{telefonSzam};{datum}";
                        using (StreamWriter sw4 = File.AppendText("../../konyvtar.txt"))
                        {
                            sw4.WriteLine(sor);
                        }
                        break;

                    default:
                        Console.WriteLine("Nincs ilyen kategória. Nyomjon egy gombot a folytatáshoz...");
                        Console.ReadKey();
                        continue;
                }

                Console.Write("\nSzeretne mégegy üzenetet hagyni? (i/n): ");
                string valasz = Console.ReadLine().ToLower();
                if (valasz == "n")
                {
                    Console.WriteLine("Köszönjük hívását!\nViszont hallásra!");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
