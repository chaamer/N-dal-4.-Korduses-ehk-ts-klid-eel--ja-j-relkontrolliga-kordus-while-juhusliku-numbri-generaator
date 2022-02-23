using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhusliku nr 1 kuni 10
            //Kasutaja peab seda numbrit arvama
            //Kui kasutaja suutis ära arvata, siis on võitnud
            //katsete arv piiramatu
            //programm genereerib juhuslikku nr

            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta nr:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == i)
                {
                    Console.WriteLine("Õige vastus");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale number, proovi veel");
                    
                }
            }
        }
    }
}
