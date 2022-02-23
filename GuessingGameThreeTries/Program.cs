using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhusliku nr 1 kuni 10
            //Kasutaja peab seda numbrit arvama
            //Kui kasutaja suutis ära arvata, siis on võitnud
            //katsete arv 3
            //programm genereerib juhuslikku nr

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)
            {

                Console.WriteLine("Sisesta arv");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == i)
                {
                    Console.WriteLine("Õigesti arvasid");
                    break;
                }
                else
                {
                    //i = i + 1; = i++
                    i++;
                    Console.WriteLine($"Vale vastus {3 - i} katset on jäänud,");
                }

            }
        }
    }
}
