using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru3
{
    internal class Program
    {   
        public static int x_ussu_n_rec(int x , int n)
        {
            if (n == 0) return 1;
            return x_ussu_n_rec(x , n -1) * x ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ussu alinacak elemani giriniz.");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("ussu alinacak eleman kac kere carpilacak giriniz.");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(x_ussu_n_rec(a, b));

            Console.ReadKey();
        }
    }
}
