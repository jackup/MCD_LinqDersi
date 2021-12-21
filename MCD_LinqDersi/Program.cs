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

            #region Denemeler
            //Liste içerisinde bulunan isim değeri a ile başlayan kayıt sayısı


            //Console.WriteLine("Müşteriler " + musteriListe.Count);


            //var bulunan = musteriListe.Where(x => x.isim.StartsWith("A"));
            //foreach (var item in bulunan)
            //{
            //    Console.WriteLine(item.isim);
            //}
            ////Console.WriteLine("Liste içerisinde A harfi ile başlayan {0} adet isim bulundu",bulunan);
            #endregion

            #region Linq yöntemleri
            ////1.yol Linq method ile sorgulama
            //int toplamMusteriAdet = musteriListe.Where(x => x.isim.StartsWith("A")).Count();
            ////2.yol Linq to Query ile sorgulama
            //var toplamMusteriBulunan = from x in musteriListe
            //                           where x.isim.StartsWith("A")
            //                           select x;
            //int toplamMusteriAdet2 = toplamMusteriBulunan.Count();
            ////ya da
            //int toplamMusteriBulunan2 = (from x in musteriListe
            //                           where x.isim.StartsWith("A")
            //                           select x).Count();
            //Console.WriteLine(toplamMusteriAdet);
            //Console.WriteLine(toplamMusteriAdet2);
            //Console.WriteLine(toplamMusteriBulunan2);
            #endregion

            #region Sorular
            //1- Müşteriler içerisinde ülke değeri A ile başlayan müşterileri Linq to metot kullanarak bulalım

            //Enumerable ile kullanım :
            IEnumerable<Musteri> musteriAlistirma1 = musteriListe.Where(x => x.ulke.StartsWith("A"));
            Console.WriteLine(musteriAlistirma1.Count());
            //List ile kullanım :
            List<Musteri> musteriAlistirma2 = musteriListe.Where(x => x.ulke.StartsWith("A")).ToList();
            Console.WriteLine(musteriAlistirma2.Count());


            //2- Müşteriler listesi içerisindeki kayıtlardan isminin içerisinde b harfi geçen VE ülke değeri içinde A harfi geçen müşterilerin listesini getiriniz.
            var musteriAlistirma3 = musteriListe.Where(x => x.isim.Contains("b") && x.ulke.Contains("a"));
            foreach (var item in musteriAlistirma3)
            {
                Console.WriteLine("İsim : {0} Ülke : {1}",item.isim,item.ulke);
            }


            #endregion
        }

    }
}
