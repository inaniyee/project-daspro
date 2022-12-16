using System;
//created by sabrina awaliah

namespace UTS_no_1
{
    class nameTAG
    {
        static void Main(string[] args)
        {   Console.WriteLine("*- Pembuatan NameTag Mahasiswa -* ");
            Console.Write("Nama        : ");
            string Nama = Console.ReadLine();
            Console.Write("NIM         : ");
            string NIM = Console.ReadLine();
            Console.Write("Konsentrasi :");
            string Konsentrasi = Console.ReadLine();
            Console.WriteLine("=== Mahasiswa Teknik INFORMATIKA ===");
            System.Console.WriteLine("|********************|");
            System.Console.WriteLine("|Nama :\t{0}\t     |", Nama);
            System.Console.WriteLine("|NIM  :\t{0}\t     |", NIM);
            System.Console.WriteLine("|--------------------|");
            System.Console.WriteLine("|\t{0}\t     |", Konsentrasi);
            System.Console.WriteLine("|********************|");
            Console.ReadLine();
               
        }
    }
}
