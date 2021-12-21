using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_LinqDersi
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSource ds = new DataSource();
            List<Musteri> musteriListe = ds.musteriListesi();

            Console.WriteLine("Müşteriler " + musteriListe.Count);
        }
    }
}
