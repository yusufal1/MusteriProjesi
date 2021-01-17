using System;

namespace MusteriProjesi
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Musteriler musteri1 = new Musteriler();
            musteri1.musteriAdi = "Yusuf";
            musteri1.musteriSoyad = "AL";
            musteri1.musteriTc = "6584795498";
            musteri1.musteriTlf = "05336584147";

            Musteriler musteri2 = new Musteriler();
            musteri2.musteriAdi = "Mert";
            musteri2.musteriSoyad = "Yılmaz";
            musteri2.musteriTc = "8881561621";
            musteri2.musteriTlf = "05334714654";

            Musteriler musteri3 = new Musteriler();
            musteri3.musteriAdi = "Yiğit";
            musteri3.musteriSoyad = "Karaman";
            musteri3.musteriTc = "56484138545";
            musteri3.musteriTlf = "05448415648";


            Musteriler[] musteriler = new Musteriler[] {musteri1, musteri2, musteri3 };

            foreach (Musteriler musteri in musteriler)
            {
                Console.WriteLine("Müşterinin Adı : " + musteri.musteriAdi);
                Console.WriteLine("Müşterinin Soyadı : " + musteri.musteriSoyad);
                Console.WriteLine("Müşterinin TC'si : " + musteri.musteriTc);
                Console.WriteLine("Müşterinin Telefon No : " + musteri.musteriTlf);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            _ = new MusteriManager();
            musteriManager.Sil(musteri1);
            





        }
    }

    class Musteriler
    {
        public string musteriAdi { get; set; }

        public string musteriSoyad { get; set; }
        public string musteriTc { get; set; }

        public string musteriTlf { get; set; }
    }
}
