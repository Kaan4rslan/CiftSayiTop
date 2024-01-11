using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.soru9bkaan
{
    class Program
    {
        static void Main(string[] args)
        {

            int toplamsayi = 0;
            Console.WriteLine("bir sayı gir");
            int sayi = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i < sayi; i+=2)
            {
                toplamsayi = toplamsayi + i;
            }

            Console.WriteLine("çift sayıların toplamı: " + toplamsayi);
            Console.Read();

        }
    }
}
