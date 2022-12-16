using System;
using System.Collections.Generic;

namespace Tugas3
{
    class Program
    {
        static int chance = 5;
        static string word = "chevrolet";
        static List<string> listtebakan = new List<string>();

        static void Main(string[] args)
        {
            Intro();
            Playgame();
            Endgame();
        }
        static void Intro()
        {
            Console.Clear();
            Console.WriteLine("selamat datang di game tebak kata");
            Console.WriteLine($"kamu mempunyai { chance} kesempatan untuk menebak");
            Console.WriteLine("petunjuknya yaitu salah satu merek otomotif dari amerika serikat");
            Console.WriteLine($"kata ini terdiri dari { word.Length } huruf");
            Console.WriteLine("kata apakah yang dimaksud?");
        }
        static void Playgame()
        {
            while (chance > 0)
            {
                Console.WriteLine("masukkan huruf tebakanmu : ");
                string input = Console.ReadLine();
                listtebakan.Add(input);

                if (cekjawaban (word,listtebakan))
                {
                    Console.WriteLine("selamat anda berhasil menebak..");
                    Console.WriteLine("kata misteri hari ini adalah " + word );
                    break;
                }
                else if (word.Contains(input))
                {
                    Console.WriteLine("tebakan kamu benar");
                    Console.WriteLine(CekHuruf(word,listtebakan));
                    Console.WriteLine("silahkan tebak huruf yang lainnya");
                }
                else
                {
                    chance--;
                    Console.WriteLine("tebakan anda salah");
                    Console.WriteLine("kesempatan anda sisa : " + chance );
                }
            }
        }

        static bool cekjawaban(string kata, List<string> List)
        {
            bool net = false;
            for (int i = 0; i < kata.Length; i++)
            {
                string x = Convert.ToString(kata[i]);
                if (List.Contains(x))
                {
                    net = true;
                }
                else
                {
                    return net = false;
                }
            }
            return net;
        }
        static string CekHuruf(string kata, List<string> List)
        {
            string net = " ";
            for (int i = 0; i < kata.Length; i++)
            {
                string x = Convert.ToString(kata[i]);
                if (List.Contains(x))
                {
                    net += x;
                }
                else
                {
                    net += "-";
                }
            }
            return net;
        }
        static void Endgame()
        {
            Console.WriteLine("permainan berakhir");
            Console.WriteLine("byee..");
            Console.ReadKey();
        }
    }
}
