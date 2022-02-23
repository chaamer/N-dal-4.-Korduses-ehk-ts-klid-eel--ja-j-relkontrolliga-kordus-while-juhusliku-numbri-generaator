using System;

namespace Loopsandrandomnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib PIN koodi, võrdleb arvuga 1234
            //Kui on õige siis kuvatakse Tere tulemast
            //Kui vale siis kuvatakse "Vale PIN"
            //Kolm katset. i < 3


            int i = 0;

            while (i < 3)
            { 

                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //i = i + 1; = i++
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud,");
                }

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
