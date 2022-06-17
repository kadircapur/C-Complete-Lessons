using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayindasiniz");
                    break;
                case 2:
                    Console.WriteLine("Subat Ayindasiniz");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayindasiniz");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayindasiniz");
                    break;
                case 5:
                    Console.WriteLine("Mayis Ayindasiniz");
                    break;
                case 6:
                    Console.WriteLine("Haziran Ayindasiniz");
                    break;
                case 7:
                    Console.WriteLine("Temmuz Ayindasiniz");
                    break;
                
                default:
                    Console.WriteLine("Yanlis Veri Girisi");
                break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis Ayindasiniz");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Ilkbahar Ayindasiniz");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Ayindasiniz");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Ayindasiniz");
                    break;

                default:
                    break;

            }
        }
    }
}
