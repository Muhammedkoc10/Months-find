using System;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Kullanıcıdan alınan iki sayıdan önce girilen mi daha büyük sonra girilen mi büyük sonucu ekrana yazan program 
            
            Console.WriteLine("Birinci sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                Console.WriteLine("1. Girilen sayı daha büyüktür");
            }
            else if (sayi2 > sayi1)
            {
                Console.WriteLine("2. Girilen sayı daha büyüktür");
            }
            else
            {
                Console.WriteLine("Girilen iki sayı birbirine eşittir.");
            }

        }
    }
}
