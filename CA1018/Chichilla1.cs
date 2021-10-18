using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1018
{
    class Chichilla
    {
        public string Nev { get; set; }
        public DateTime Szul { get; set; }
        public int Suly { get; set; }
        public bool Simi { get; set; }

        public Chichilla(string r)
        {
            var t = r.Split(';');
            Nev = t[0];
            Szul = DateTime.Parse(t[1]);
            Suly = int.Parse(t[2]);
            Simi = bool.Parse(t[3]);

        }
    }
}
