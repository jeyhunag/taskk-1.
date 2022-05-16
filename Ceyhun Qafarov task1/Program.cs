using System;

namespace Ceyhun_Qafarov_task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random blur = new Random();
            int a = blur.Next(0, 100);
            int texmin;
            do
            {

                Console.WriteLine("bir reqem daxil edin");
                texmin = int.Parse(Console.ReadLine());
                if (texmin == a)
                {
                    Console.WriteLine("Tebrik edirik....");
                }
                if (texmin < a)
                {
                    Console.WriteLine("Yuxari");

                }
                if (texmin > a)
                {
                    Console.WriteLine("Asagi");
                }

            } while (texmin != a);

        }
    }
}
