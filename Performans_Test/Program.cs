using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace PerformanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci_For();
            Fibonacci_Do_While();
            Fibonacci_While();
            BubbleSort();
            ikizkenarMi();
            
            //--------------------------------------------

        }
        static void BubbleSort()
        {
            Stopwatch performance = new Stopwatch();
            performance.Start();
            int gecici;
            int[] dizi = { 8, 0, 3, 5, 2, 4 };
            for (int i = 0; i <= dizi.Length - 1; i++)
            {
                for (int j = 1; j <= dizi.Length - 1; j++)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }
            Console.WriteLine();
            performance.Stop();
            Console.WriteLine( "Performans = " + performance.Elapsed);
            Console.ReadKey();
        }

        static void Fibonacci_While()
        {
            Stopwatch performance = new Stopwatch();
            performance.Start();
            int adet = 10;
            int a = 0;
            int b = 1;
            int toplam = 0;
            int i = 3;
            while (i < adet + 1)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
                if (c % 2 == 0)
                {
                    toplam += c;
                }
                i++;
            }
            Console.WriteLine();
            performance.Stop();
            Console.WriteLine(toplam + " \n" + "Performans = " + performance.Elapsed);
            Console.ReadKey();
        }

        static void Fibonacci_Do_While()
        {
            Stopwatch performance = new Stopwatch();
            performance.Start();
            int adet = 10;
            int a = 0;
            int b = 1;
            int toplam = 0;
            int i = 3;
            do
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
                if (c % 2 == 0)
                {
                    toplam += c;
                }
                i++;
            } while (i < adet + 1);
            Console.WriteLine();
            performance.Stop();
            Console.WriteLine(toplam + " \n" + "Performans = " + performance.Elapsed);
            Console.ReadKey();
        }
        static void Fibonacci_For()
        {
            Stopwatch performance = new Stopwatch();
            performance.Start();
            int adet = 10;
            int a = 0;
            int b = 1;
            int toplam = 0;

            for (int i = 3; i <= adet; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
                if (c % 2 == 0)
                {
                    toplam += c;
                }
            }
            Console.WriteLine();
            performance.Stop();
            Console.WriteLine(toplam + " \n" + "Performans = " + performance.Elapsed);
            Console.ReadKey();
        }
        static void ikizkenarMi()
        {

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Console.WriteLine("Lütfen Üçgenin 1. Kenarını Giriniz=");
            int kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Üçgenin 1. Kenarını Giriniz=");
            int kenar2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Üçgenin 1. Kenarını Giriniz=");
            int kenar3 = Convert.ToInt32(Console.ReadLine());

            if (kenar1 == kenar2 && kenar1 == kenar3 && kenar2 == kenar3)
            {
                Console.WriteLine("Eş Kenar Üçgendir");
            }
            else if (kenar1 == kenar2 && kenar1 != kenar3 || kenar2 == kenar3 && kenar3 != kenar1 || kenar1 == kenar3 && kenar3 != kenar2)
            {

                Console.WriteLine("İkiz Kenar Üçgen");

            }
            else
            {
                Console.WriteLine("Çeşit Kenar Üçgen");
            }

            stopwatch.Stop();

            Console.WriteLine("Sonuç=" + stopwatch.Elapsed);


            Console.ReadKey();
        }

    }
}
