using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm genereerib juhusliku numbri vahemikus 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti
            //programm genereerib juhusliku numbri ühe korra, ehk võrdleb seda numbrit mille ta on juba eelnevalt ka genereerinud.




            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;


            while (i < 3)
            {
               Console.WriteLine("Tere tulemast mängu. Mängu võitmiseks tuleb valida üks number 1 kuni 10:");
               int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Õnnitlused! Oled mängu võitnud.");
                    break;
                }
                else
                {
                      i++;  //i = i + 1;
                    Console.WriteLine("Kahjuks vale number. Proovi uuesti!");
                    Console.WriteLine($"Sul on jäänud {3 - i} katset.");
                }
            }
         }
     }
}
