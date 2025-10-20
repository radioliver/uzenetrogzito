using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace uzenetVisszanezo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine(" PG - ÜZENETVISSZANÉZŐ");
            Console.WriteLine("---------------------");

            Console.WriteLine("11 - titkárság\n14 - tanári\n15 - kollégium\n16 - könyvtár\n0 - összes");
            Console.Write("\nVálasszon a fenti lehetőségek közül: ");
            int valasztott = int.Parse(Console.ReadLine());
            
            if (valasztott == 0)
            {
                List<string> strings = new List<string>();
                StreamReader sr = new StreamReader("../../../titkarsag.txt");
                foreach (var item in File.ReadLines("../../../titkarsag.txt").Skip(1))
                {
                    strings.Add(item);
                }
                sr = new StreamReader("../../../tanari.txt");
                foreach (var item in File.ReadLines("../../../tanari.txt").Skip(1))
                {
                    strings.Add(item);
                }
                sr = new StreamReader("../../../kollegium.txt");
                foreach (var item in File.ReadLines("../../../kollegium.txt").Skip(1))
                {
                    strings.Add(item);
                }
                sr = new StreamReader("../../../konyvtar.txt");
                foreach (var item in File.ReadLines("../../../konyvtar.txt").Skip(1))
                {
                    strings.Add(item);
                }
                foreach (var item in strings)
                {
                    string[] adatok = item.Split(';');
                    Console.WriteLine($"Sorszám: {adatok[0]}\nÜzenet: {adatok[1]}\nNév: {adatok[2]}\nTelefonszám: {adatok[3]}\nDátum: {adatok[4]}\n------------------");
                }
            }
            else if (valasztott == 11)
            {
                List<string> strings = new List<string>();
                StreamReader sr = new StreamReader("../../../titkarsag.txt");
                foreach (var item in File.ReadLines("../../../titkarsag.txt").Skip(1))
                {
                    strings.Add(item);
                }
                foreach (var item in strings)
                {
                    string[] adatok = item.Split(';');
                    Console.WriteLine($"Sorszám: {adatok[0]}\nÜzenet: {adatok[1]}\nNév: {adatok[2]}\nTelefonszám: {adatok[3]}\nDátum: {adatok[4]}\n------------------");
                }
            }
            else if (valasztott == 14)
            {
                List<string> strings = new List<string>();
                StreamReader sr = new StreamReader("../../../tanari.txt");
                foreach (var item in File.ReadLines("../../../tanari.txt").Skip(1))
                {
                    strings.Add(item);
                }
                foreach (var item in strings)
                {
                    string[] adatok = item.Split(';');
                    Console.WriteLine($"Sorszám: {adatok[0]}\nÜzenet: {adatok[1]}\nNév: {adatok[2]}\nTelefonszám: {adatok[3]}\nDátum: {adatok[4]}\n------------------");
                }
            }
            else if (valasztott == 15)
            {
                List<string> strings = new List<string>();
                StreamReader sr = new StreamReader("../../../kollegium.txt");
                foreach (var item in File.ReadLines("../../../kollegium.txt").Skip(1))
                {
                    strings.Add(item);
                }
                foreach (var item in strings)
                {
                    string[] adatok = item.Split(';');
                    Console.WriteLine($"Sorszám: {adatok[0]}\nÜzenet: {adatok[1]}\nNév: {adatok[2]}\nTelefonszám: {adatok[3]}\nDátum: {adatok[4]}\n------------------");
                }
            }
            else if (valasztott == 16)
            {
                List<string> strings = new List<string>();
                StreamReader sr = new StreamReader("../../../konyvtar.txt");
                foreach (var item in File.ReadLines("../../../konyvtar.txt").Skip(1))
                {
                    strings.Add(item);
                }
                foreach (var item in strings)
                {
                    string[] adatok = item.Split(';');
                    Console.WriteLine($"Sorszám: {adatok[0]}\nÜzenet: {adatok[1]}\nNév: {adatok[2]}\nTelefonszám: {adatok[3]}\nDátum: {adatok[4]}\n------------------");
                }
            }









            Console.ReadKey();
        }
    }
}
