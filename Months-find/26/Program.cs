using System;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
        yeniden: Console.WriteLine("Ay numarası giriniz");
            int ayNo = Convert.ToInt32(Console.ReadLine());

            switch (ayNo)
            {

                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Girdiğiniz ay numarasıa göre kış ayındasınız.");
                    break;
                
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Girdiğiniz ay numarasıa göre ilkbahar ayındasınız.");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Girdiğiniz ay numarasıa göre yaz ayındasınız.");
                    break;
                
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Girdiğiniz ay numarasıa göre sonbahar ayındasınız.");
                    break;

                default:
                    Console.WriteLine("Ay numarasını yanlış girdiniz. Lütfen 1 ile 12 arasında bir sayı giriniz!");
                    goto yeniden;
               

            }
        }
    }
}
