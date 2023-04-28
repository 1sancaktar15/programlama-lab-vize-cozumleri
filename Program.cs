using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru2
{
    internal class Program
    {
        public static int ikiliArama(int[] d, int a)
        {
            int sol = 0;
            int sag = d.Length - 1;
            while (sol <= sag)
            {
                int orta = (sag + sol) / 2;
                if (d[orta] == a)
                {
                    return orta;
                }
                else if (d[orta] < a)
                {
                    sol = orta + 1;
                }
                else
                {
                    sag = orta - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            /*int[] dizi = { 1, 2, 3, 4, 5, 6 };
            int deneme = ikiliArama(dizi, 9);
            Console.Write(deneme);*/

            Console.WriteLine("dizinin kapasitesini giriniz.");
            int diziKapasite = int.Parse(Console.ReadLine());

            Console.WriteLine("aranacak elemanı giriniz.");
            int arananEleman = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[] dizi = new int[diziKapasite];

            for (int i = 0; i < diziKapasite; i++)
            {
                dizi[i] = rnd.Next(10, 101);
            }
            Array.Sort(dizi);//binary search yapmak icin gerekli.

            int result = ikiliArama(dizi, arananEleman);

            if (result == -1) Console.WriteLine("aradığınız sonuç dizide bulunmamaktadır.");
            else Console.WriteLine("girdiğiniz " + arananEleman + " sayısı dizide su indiste bulunmustur: " + result);
            Console.ReadKey();
        }
    }
}