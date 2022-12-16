using System;

namespace Tugas1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1 , b = 2 , c = 3;
            int tambah = a + b + c , kurang = a - b - c;
            int bagi = a / b / c , kali = a * b * c;

            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui..");
            Console.WriteLine("-Password terdiri dari 4 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + tambah);
            Console.WriteLine("-Jika dikurang hasilnya " + kurang);
            Console.WriteLine("-Jika di kali hasilya " + kali);
            Console.WriteLine("-Jika dibagi hasilnya " + bagi);
            Console.Write("Enter Code : ");



        }
    }
}
