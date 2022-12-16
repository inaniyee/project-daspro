using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace UTS_no_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = File.ReadAllLines("kata.txt");
            Random random = new Random();
            string words = inputText[random.Next(inputText.Length)];
            int kesempatan = 10;
            List<string> userGuess = new List<string>{};

            Console.WriteLine("Selamat datang di hangman game");
            Console.WriteLine("Untuk menebak kata ini , kamu memiliki {0} kesempatan", kesempatan);
            Console.WriteLine("Kata terdiri dari {0} huruf", words.Length);
            try{
            while (true)
            {
                Console.WriteLine("Tebakanmu ? :");
                string inputUser = Console.ReadLine().ToLower();

                userGuess.Add(inputUser);
                if(WinCon(userGuess,words))
                {
                    Console.WriteLine("Tebakanmu Benar");
                    Console.WriteLine("Tebakanmu :"+huruf(userGuess,words));
                    Console.WriteLine("Selamat, anda telah memenangkan permainan ini!");
                    
                    break;
                }else if(words.Contains(inputUser)){
                    Console.WriteLine("Tebakanmu benar");
                    Console.WriteLine("Tebakanmu"+huruf(userGuess,words));
                }
                else
                { 
                    Console.WriteLine("Huruf {0} tidak ada di dalam kata ini", inputUser);
                    Console.WriteLine("Tebakanmu : " +huruf(userGuess,words));
                    kesempatan--;
                    displayHangman(kesempatan);
                    Console.WriteLine("Kamu memiliki {0} kesempatan untuk menebak", kesempatan);
                }
                if (kesempatan == 0)
                {
                    Console.WriteLine("Kamu kalah dalam permainan ini");
                    break;
                }
            } 
            
        } catch(FormatException){
            Console.WriteLine("kesalahan input");}
    }
        public static string huruf(List<string> userLetGuess, string word){
            string output ="";
            string item = string.Join(",",userLetGuess);
            for (int i = 0; i < word.Length; i++)
            {
                string kata = Convert.ToString(word[i]);
                if (item.Contains(kata))
                {
                    output = output + kata;
                }else
                {
                    output = output + "*";
                }
            }
            return output;
        }
        public static bool WinCon(List<string> userLetGuess, string word){
            bool win = false;
            for (int i = 0; i < word.Length; i++)
            {
                string kata = Convert.ToString(word[i]);
                if (userLetGuess.Contains(kata))
                {
                    win = true;
                }else
                {
                    return win = false;
                }
            }
            return win;
        }
        public static void displayHangman(int kesempatan){
            if (kesempatan == 9)
            {
                Console.WriteLine("__________");
            }
            if (kesempatan == 8)
            {
                Console.WriteLine("__________");
                Console.WriteLine("||       |");
            }
            if (kesempatan == 7)
            {
                Console.WriteLine("__________");
                Console.WriteLine("||       |");
                Console.WriteLine("||       O");
            }
            if (kesempatan == 6)
            {
                Console.WriteLine("__________");
                Console.WriteLine("||       |");
                Console.WriteLine("||       O");
                Console.WriteLine("||      /|\\");
            }
            if (kesempatan == 5)
            {
                Console.WriteLine("__________");
                Console.WriteLine("||       |");
                Console.WriteLine("||       O");
                Console.WriteLine("||      /|\\");
                Console.WriteLine("||       |");
            }
            if (kesempatan == 4)
            {
                Console.WriteLine("__________");
                Console.WriteLine("||       |");
                Console.WriteLine("||       O");
                Console.WriteLine("||      /|\\");
                Console.WriteLine("||       |");
                Console.WriteLine("||      /\\");   
            }
            if (kesempatan == 3)
            {
                Console.WriteLine("__________");
                Console.WriteLine("||       |");
                Console.WriteLine("||       O");
                Console.WriteLine("||      /|\\");
                Console.WriteLine("||       |");
                Console.WriteLine("||      /\\");
                Console.WriteLine("||          ");
            }
            if (kesempatan == 2)
            {
                Console.WriteLine("__________");
                Console.WriteLine("||       |");
                Console.WriteLine("||       O");
                Console.WriteLine("||      /|\\");
                Console.WriteLine("||       |");
                Console.WriteLine("||      /\\");
                Console.WriteLine("||          ");
                Console.WriteLine("||           ");
            }
            if (kesempatan == 1)
            {
                Console.WriteLine("__________");
                Console.WriteLine("||       |");
                Console.WriteLine("||       O");
                Console.WriteLine("||      /|\\");
                Console.WriteLine("||       |");
                Console.WriteLine("||      /\\");
                Console.WriteLine("||          ");
                Console.WriteLine("||           ");
                Console.WriteLine("||           ");
            }
            if (kesempatan == 0)
            {
                Console.WriteLine("__________");
                Console.WriteLine("||       |");
                Console.WriteLine("||       O");
                Console.WriteLine("||      /|\\");
                Console.WriteLine("||       |");
                Console.WriteLine("||      /\\");
                Console.WriteLine("||          ");
                Console.WriteLine("||           ");
                Console.WriteLine("||           ");
                Console.WriteLine("\\___________");
                Console.WriteLine("");
                Console.WriteLine("Anda kalahh!!!");
            }
        }
    }
}
