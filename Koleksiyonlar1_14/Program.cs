using System;
using System.Collections.Generic;

namespace Koleksiyonlar1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);
            
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            if (sayiListesi.Contains(10))
                Console.WriteLine("10 Liste icerisine bulundu");
            
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            string[] hayvanlar = {"Kedi", "Kopek", "Kus"};
            List<string> hayvanList = new List<string>(hayvanlar);
            
            hayvanList.Clear();

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayse";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 26;
            
            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalışkan";
            kullanıcı2.Yas = 26;
            
            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniliste = new List<Kullanıcılar>();
            
            yeniliste.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşi: " + kullanıcı.Yas);
            }
            
            yeniliste.Clear();
        }
        public class Kullanıcılar
        {
            private string isim;
            private string soyisim;
            private int yas;
            
            public string Isim
            {
                get => isim;
                set => isim = value;
            }
            public string Soyisim
            {
                get => soyisim;
                set => soyisim = value;
            }
            public int Yas
            {
                get => yas;
                set => yas = value;
            }
        }
    }
}