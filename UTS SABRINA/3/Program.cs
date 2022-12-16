using System;

namespace UTS_no_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Pemesanan Tiket ==");
            Console.Write("Nama         : ");
            string Nama = Console.ReadLine();
            Console.Write("Tahun Lahir  : ");
            try{
                int tlahir = int.Parse(Console.ReadLine());
                int umur = 2022 - tlahir;
                if (umur < 10 || umur > 60)
            {
                Console.WriteLine("---------TIKET BIOSKOP---------");
                Console.WriteLine("===============================");
                Console.WriteLine("|          Studio 1           |");
                Console.WriteLine("| Nama   :          {0}\t|", Nama);
                Console.WriteLine("| Harga  :         Rp.10000.00|");
                Console.WriteLine("===============================");
            }
                else{
                    Console.WriteLine("-------TIKET BIOSKOP-------");
                    System.Console.WriteLine("==========================");
                    System.Console.WriteLine("|         Studio 1        |");
                    System.Console.WriteLine("| Nama    :        {0} |", Nama);
                    System.Console.WriteLine("| Harga        Rp.25000.00|");
                    System.Console.WriteLine("==========================");
                }
            }
                catch(FormatException){
                    Console.WriteLine("Kesalahan input");
                }
            }
        }
    }

