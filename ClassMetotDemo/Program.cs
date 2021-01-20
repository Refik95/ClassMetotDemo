using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Refik";
            musteri1.SoyAdi = "Günhan";
            musteri1.Id = 34;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ray";
            musteri2.SoyAdi = "Allen";
            musteri2.Id = 35;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.SoyAdi);
                Console.WriteLine(musteri.Id);
                Console.WriteLine("--------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekleme(musteri1);
            musteriManager.Ekleme(musteri2);

            musteriManager.Silme(musteri2);

            musteriManager.Listeleme("Refik", "Günhan", 34);
        }
    }
}
