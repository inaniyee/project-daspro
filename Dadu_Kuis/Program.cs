using System;

namespace Dadu_Kuis
{
    class Program
    {
        static void Main(string[] args)
        {
            int daduaku,dadukom;
            int skoraku = 0, skorkom = 0;
            int game = 1;

            Random acak = new Random();

            for (int i = 1; i <= 10; i++)
            {
                {
                Console.WriteLine("round : " + game);
                Console.WriteLine("  ");
                Console.WriteLine("tekan enter utk melempar dadu");
                Console.ReadKey();

                daduaku = acak.Next(1,7);
                Console.WriteLine("dadu mu " + daduaku);

                dadukom = acak.Next(1,7);
                Console.WriteLine("dadu kom " + dadukom);
                }
                if (daduaku > dadukom)
                {
                    game++;
                    skoraku++;
                    Console.WriteLine("kamu menang.. ");
                    Console.WriteLine("skor kamu : "+ skoraku + ", skor kom : " + skorkom);
                    Console.WriteLine("---");
                }
                else if (daduaku < dadukom)
                {
                    game++;
                    skorkom++;
                    Console.WriteLine("kamu kalah ");
                    Console.WriteLine("skor kamu : " + skoraku + ", skor kom : " + skorkom);
                    Console.WriteLine("---");
                }
                else
                {
                    game++;
                    Console.WriteLine("skor kamu dengan komputer seri");
                    Console.WriteLine("skor kamu : " + skoraku + ", skor kom : " + skorkom);
                    Console.WriteLine("---");
                }
                if (skoraku > skorkom && i >= 10)
                {
                    Console.WriteLine("kamu memenangkan game ini..");
                    Console.WriteLine("tekan enter untuk hapus");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (skoraku < skorkom && i >= 10)
                {
                    Console.WriteLine("kamu kalah dalam game inii..");
                    Console.WriteLine("tekan enter untuk menghapus");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (skoraku == skorkom && i >= 10)
                {
                    Console.WriteLine("hasil game seri");
                    Console.WriteLine("tekan enter untuk menghapus");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
                
        }
    }
}

