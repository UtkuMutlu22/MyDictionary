using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(0, "Utku");
            kullanicilar.Add(1, "Melek");
            kullanicilar.Add(2, "Dilan");

            for (int i = 0; i < kullanicilar.Count; i++)
            {
                Console.WriteLine("ID: "+kullanicilar.Keys+"İsim Soyisim: "+kullanicilar.Values);

            }
            string yeniKullanici = "Arzu";

            bool varMı = kullanicilar.TryGetValue(0, out yeniKullanici);
            if (varMı)
            {
                Console.WriteLine("Bu ID değerinde kullanıcı mevcuttur");
            }
            else
            {
                kullanicilar.Add(0, yeniKullanici);
                Console.WriteLine("işlem Başarı ile gerçekleşmiştir.");
            }

        }
    }
}
