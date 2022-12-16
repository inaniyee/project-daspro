using System;

namespace Tugas2
{
    class Program
    {
        static Random acak = new Random();
        
        static int kodeA , kodeB , kodeC;
        static int kesempatan = 3;
        static int level = 1;
        static int jumKode = 3;

        static string tebakanA , tebakanB , tebakanC;
        static bool gameTamat = true;

        static bool cancel = false;

        static void Main(string[] args)
        {
            intro();

            while (gameTamat)
            {
                PlayGame();

                if (cancel == true)
                {
                    break;
                }
            }

        }

        static void intro(){

            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server..");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui..");
        }

        static void PlayGame(){

            kodeA = acak.Next(1, level);
            kodeB = acak.Next(1, level);
            kodeC = acak.Next(1, level);

            int hasilTambah = kodeA+kodeB+kodeC;
            int hasilKali = kodeA*kodeB*kodeC;

            Console.WriteLine("- level " + level);
            Console.WriteLine("- password terdiri dari " + jumKode + " angka");
            Console.WriteLine("- jika ditambahkan hasilnya " + hasilTambah);
            Console.WriteLine("- jika di kali hasilnya " + hasilKali);

            Console.Write("masukkan kode 1 : ");
            tebakanA = Console.ReadLine();
            Console.Write("masukkan kode 2 : ");
            tebakanB = Console.ReadLine();
            Console.Write("masukkan kode 3 : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan kamu " + tebakanA + " " + tebakanB + " " + tebakanC + "?");

            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString()){
                Console.WriteLine("yeyyy betulll!");

                level = level + 1;

                if(level > 5){
                    Console.WriteLine("selamattt kamu menang");
                    cancel = true;
                }
            }
            else
            {
                Console.WriteLine("anda salah!");
                

                kesempatan = kesempatan - 1;
                Console.WriteLine("kesempatan anda tinggal " + kesempatan );

                if (kesempatan < 1)
                {
                    cancel = true;
                    Console.WriteLine("anda kalahh huuuu");
                }
            }


        }
    }
}
