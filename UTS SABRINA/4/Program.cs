using System;
using System.Text;

namespace UTS_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Teks Enkripsi===");
            char[] alfabet = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','V','W','X','Y','Z'};
            char chara;
            var output = new StringBuilder();
            Console.Write("Teks : ");
            try{
                string input = Console.ReadLine();
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsUpper(input[i]))
                    {
                        chara = (char)(((int)input[i] +3 - 65) % 26+65);
                        output.Append(chara);
                    }else
                    {
                        chara = (char)(((int)input[i] +3 - 97) % 26+97);
                        output.Append(chara);
                    }
                }
                Console.WriteLine("===Hasil Teks===");
                Console.WriteLine("|Teks        : {0}", input);
                Console.WriteLine("|Teks Enkripsi : {0}", output);
                Console.WriteLine("==========");
            }
            catch(FormatException){
                Console.WriteLine("Kesalahan Input");
            }
        }
    }
}
