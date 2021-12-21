using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_LinqDersi
{
    public class DataSource
    {
        List<Musteri> musteriler;

        public DataSource()
        {
            musteriler = new List<Musteri>();
        }

        public List<Musteri> musteriListesi()
        {
            for (int i = 0; i < 50; i++)
            {
                Musteri m = new Musteri();
                m.musteriNumara = i;
                m.isim = FakeData.NameData.GetFirstName();
                m.soyisim = FakeData.NameData.GetSurname();
                m.dogumTarihi = FakeData.DateTimeData.GetDatetime(new DateTime(1984,01,01), new DateTime(1999,12,31));
                m.ulke = FakeData.PlaceData.GetCountry();
                m.il = FakeData.PlaceData.GetCity();
                m.ilce = FakeData.PlaceData.GetCounty();
                m.emailAdres = $"{ m.isim.ToLower()}.{ m.soyisim.ToLower()}@{ FakeData.NetworkData.GetDomain()}";
                m.telefonNumara = FakeData.PhoneNumberData.GetPhoneNumber();

                musteriler.Add(m);
            }
            //------------------------------------
            //Linq kullanmadan yapılan yöntem :


            //int alar = 0;
            //foreach (var item in musteriler)
            //{
            //    if (item.isim.StartsWith("A"))
            //    {
            //        alar++;
            //        Console.WriteLine(item.isim);
            //    }
            //}
            //Console.WriteLine("a ile başlayan {0} adet isim bulundu.", alar);
            //--------------------------------------
            return musteriler;
        }


    }
}
