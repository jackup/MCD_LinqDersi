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

                musteriler.Add(m);
            }
            return musteriler;
        }


    }
}
