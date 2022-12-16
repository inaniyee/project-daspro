using System;

namespace UTS_no_2
{
    class Program
    {
        static void Main(string[] args){
            int Rate = 15276;
            try{
                Console.WriteLine("+===Konversi USD Ke RP===+");
                Console.WriteLine("|Rate USD hari ini adalah " +Rate);
                Console.Write("|Jumlah USD : ");
                double USD = double.Parse(Console.ReadLine());
                double RP = Rate*USD;
                Console.WriteLine("|Hasil Konversi : {0}", RP);
                Console.WriteLine("+=======+");
                Console.ReadLine();
               }

            catch(FormatException){
                Console.WriteLine("INPUTAN SALAH");
            }
        
        
        }
    }
}
