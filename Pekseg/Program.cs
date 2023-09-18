using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pekseg
{
    class Program
    {
        static void Main(string[] args)
        {
            var pekaruk = new List<Pekaru>();
            var sr = new StreamReader(
                path: @"..\..\..\src\Pekaruk.txt",
                Encoding.UTF8);
            while (!sr.EndOfStream) pekaruk.Add(new Pekaru(sr.ReadLine()));
            foreach (var p in pekaruk)
            {
                Console.WriteLine($"\t{p.Nev},\n\t{p.Zsir},\n\t{p.Szenhidrat}\n");
            }

            var zs = new List<Pekaru>(pekaruk.OrderBy(zs => zs.Zsir));
            Console.WriteLine($"A legkisebb zsírtartalmú pékáru:  {zs[0].Nev}");

            var sz = new List<Pekaru>(pekaruk);
            sz.Sort();
            foreach (var p in sz)
            {
                Console.WriteLine($"\t{p.Nev},\n\t{p.Zsir},\n\t{p.Szenhidrat}");
            }

            var zst = false;
            float count = 0;
            foreach (var p in pekaruk)
            {
                if (p.Zsir == 0.7)
                {
                    Console.WriteLine(p.Nev);
                    zst = true;
                }
                count += p.Zsir;
            }
            count /= pekaruk.Count();
            if (!zst) Console.WriteLine($"Nincs ilyen elem. A pékáruk átlak zsírtartalma:  {count}");


        }
    }
}
