using System;

//Hesaplama işlemleri için ayrı bir namespace
namespace MatematikIslemleri
{
    public class Hesaplama
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}

//Program çalıştırma kısmı için farklı namespace
namespace Uygulama
{
    using MatematikIslemleri; //Hesaplama sınıfını kullanabilmek için

    class Program
    {
        static void Main(string[] args)
        {
            Hesaplama hesap = new Hesaplama();

            int toplam = hesap.Topla(5, 7);
            int carpim = hesap.Carp(4, 6);

            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Carpim: " + carpim);
        }
    }
}
