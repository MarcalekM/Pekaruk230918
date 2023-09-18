using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    class Pekaru
    {
        public string Nev { get; set; }
        public float Zsir { get; set; }
        public float Szenhidrat { get; set; }

        public Pekaru(string r)
        {
            var v = r.Split(';');
            Nev = v[0];
            Zsir = float.Parse(v[1]);
            Szenhidrat = float.Parse(v[2]);
        }
    }
}
