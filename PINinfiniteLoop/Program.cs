using System;

namespace PINinfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib PIN koodi, võrdleb arvuga 1234
            //Kui on õige siis kuvatakse Tere tulemast
            //Kui vale siis kuvatakse "Vale PIN"
            //Lõpmata arv katseid

            bool loopActive = true;
            int i = 0;

            while(loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
