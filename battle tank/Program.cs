/*create by sabrina awaliah
*/

using System;

namespace battletank
{
    class Program
    {
        static char[,] Tank = {
            {' ','1','2','3','4','5'},
            {'1','~','~','~','~','~'},
            {'2','~','~','~','~','~'},
            {'3','~','~','~','~','~'},
            {'4','~','~','~','~','~'},
            {'5','~','~','~','~','~'}
        };
        static int[,] answer = {
            {1,2},
            {2,3},
            {3,4}
        };
        static int[,] recent = {
            {0,0},
            {0,0},
            {0,0}
        };
        static int[] tebakan = {0,0};
        static int jumlah_benar = 0;
        static bool gstate = true;
        static int benar_salah = 0;

        static void Main(string[] args)
        {
            while(gstate)
            {
                drawTank();
                try
                {
                    Console.Write("Pilih baris: "); tebakan[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Pilih kolom: "); tebakan[1] = Convert.ToInt32(Console.ReadLine());
                }catch(Exception e){
                    Console.WriteLine("Error: Yang anda masukkan bukan angka valid");
                }
                benar_salah = cekTank();
                if(benar_salah == 2)
                {
                    Console.WriteLine("Sudah hancur!");
                }
                else
                if(benar_salah == 1)
                {
                    Console.WriteLine("Boom! Tank hancur!");
                    jumlah_benar++;
                }
                else
                {
                    Console.WriteLine("Miss! Meleset!");
                }
                if(jumlah_benar >= 3)
                {
                    drawTank();
                    Console.WriteLine("\nMenang! Tank hancur semua!");
                    gstate=false;
                }
                Console.WriteLine();
            }
        }

        static void drawTank()
        {
            for(int i=0;i<6;i++)
            {
                for(int j=0;j<6;j++)
                {
                    Console.Write(Tank[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int cekTank()
        {
            for(int i=0;i<3;i++)
            {
                if(recent[i,0] == tebakan[0] && recent[i,1] == tebakan[1])
                {
                    return 2;
                }
            }
            for(int i=0;i<3;i++)
            {
                if(answer[i,0] == tebakan[0] && answer[i,1] == tebakan[1])
                {
                    Tank[tebakan[0],tebakan[1]] = 'X';
                    recent[i,0] = tebakan[0];
                    recent[i,1] = tebakan[1];
                    return 1;
                }
                else
                {
                    Tank[tebakan[0],tebakan[1]] = '0';
                }
            }
            return 0;
        }
    }
}
