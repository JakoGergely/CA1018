using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1018
{
    class Program
    {
        static List<Chichilla> csincsillak = new List<Chichilla>();
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"..\..\res\chi.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream) csincsillak.Add(new Chichilla(sr.ReadLine()));
            }
            Console.WriteLine($"2. feladat:\nÖsszesen {csincsillak.Count} csincsilla van.\n");

            var szereti = csincsillak.Count(x => x.Simi);

            Console.WriteLine("3. feladat:\nA csincsillák {0:0.00}%-a szereti ha simogatják.\n ", (float)szereti / csincsillak.Count * 100);

            var oscs = csincsillak.Where(x => x.Kor > 8 && x.Suly < 360).FirstOrDefault();
            Console.WriteLine($"4.feladat:\n{(oscs != null ? "nincs ilyen csincsilla" : $"{oscs.Nev} {Math.Floor(oscs.Kor)} éves és {oscs.Suly}")}");

            Console.ReadKey(true);
        }
    }
}
