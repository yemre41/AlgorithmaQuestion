using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgortimaSorulari_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float asalav = 0;
            float normalav = 0;
            ArrayList asalsayi = new ArrayList();
            ArrayList normalsayi = new ArrayList();
            int kontrol = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}.sayıyı giriniz", i + 1);
            bas:
                string sayi = Console.ReadLine();
                int sayii = Convert.ToInt32(sayi);
                for (int j = 2; j < sayii; j++)
                {
                    if (sayii % j == 0)
                    {
                        kontrol++;

                    }
                }
                if (kontrol == 0)
                {
                    asalsayi.Add(sayii);
                }
                else if (kontrol != 0)
                {
                    normalsayi.Add(sayii);
                }
                else
                {
                    Console.WriteLine("Yanlış değer {0}. sayı hatalı", i + 1);
                    goto bas;
                }
            }

            asalsayi.Sort();
            asalsayi.Reverse();
            normalsayi.Sort();
            normalsayi.Reverse();

            Console.WriteLine("****Aasal olmayan sayılar****");
            foreach (var normal in normalsayi)
            {
                Console.WriteLine(normal);
                normalav += Convert.ToInt32(normal);
            }
            Console.WriteLine($"Toplam {normalsayi.Count} normal sayı gırısı yapılmıstır ve ortalaması {normalav / normalsayi.Count} ");

            foreach (var asal in asalsayi)
            {
                Console.WriteLine(asal);
                asalav += Convert.ToInt32(asal);
            }
            Console.WriteLine($"Toplam {asalsayi.Count} normal sayı gırısı yapılmıstır ve ortalaması {asalav / asalsayi.Count} ");
        }
    }
    
}
