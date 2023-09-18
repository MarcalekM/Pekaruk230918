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
        }
    }
}
