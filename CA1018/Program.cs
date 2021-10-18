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



            Console.ReadKey(true);
        }
    }
}
