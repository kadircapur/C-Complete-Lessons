using System;

namespace HataYonetımı
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayi Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi:" + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Islem Tamamlandi:");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Bos Deger Girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Degil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Cok kucuk ya da cok buyuk bir deger girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Islem Basariyla Tamamlandi");
            }
            }
        }
}
