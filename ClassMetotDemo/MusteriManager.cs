using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
     class MusteriManager
    {
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : "+ musteri.Adi + musteri.SoyAdi + musteri.Id);
        }
        public void Listeleme(string musteriAdi, string musteriSoyAdi, int Id)
        {
            Console.WriteLine("Müşteri Listesi :" + musteriAdi + musteriSoyAdi + Id);
        }
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Adi + musteri.SoyAdi + musteri.Id);
        }
    }
}
