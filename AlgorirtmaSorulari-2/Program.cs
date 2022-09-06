using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorirtmaSorulari_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            int[] enBuyukler = new int[3];
            int[] enKucukler = new int[3];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0}. Sayıyı giriniz:", i + 1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
            }

            Array.Sort(sayilar);
            for (int j = 0; j < 3; j++)
            {
                enKucukler[j] = sayilar[j];
            }

            Array.Reverse(sayilar);
            for (int j = 0; j < 3; j++)
            {
                enBuyukler[j] = sayilar[j];
            }

            Console.WriteLine($"En büyüklerin ortalaması:{Math.Round(enBuyukler.Average(), 2)}");
            Console.WriteLine($"En küçüklerin ortalaması:{Math.Round(enKucukler.Average(), 2)}");
            Console.WriteLine($"Ortalamaların toplamı {Math.Round((enBuyukler.Average() + enKucukler.Average()), 2)}");
           
        }
    }
}
