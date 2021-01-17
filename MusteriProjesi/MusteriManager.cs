using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriProjesi
{
    class MusteriManager
    {
        public void Ekle(Musteriler musteri)
        {
            Console.WriteLine("Eklenen Müşteriler :" + musteri.musteriAdi);
        }

        public void Sil(Musteriler musteri)
        {
            Console.WriteLine("Silinen Müşteriler : " + musteri.musteriAdi);
        }
    }
}
