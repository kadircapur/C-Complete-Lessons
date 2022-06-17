using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayiya kadar olan tek sayilari ekrana yazdir

            Console.Write("Lutfen bir sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++) 
            {
                if (i%2 == 1)
                    Console.WriteLine(i);
            }

            // 1 ile 1000 arasindaki tek ve cift sayilarin kendi iclerindeki toplamlarini ekrana yazdir

            int tekToplam = 0;
            int ciftToplam = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;
                else
                    ciftToplam = +i;
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Cift Toplam: " + ciftToplam);

        }
    }
}
