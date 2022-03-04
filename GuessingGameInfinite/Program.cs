using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {


            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //programm genererib juhuslikku numbrit ühte korda. Ehk võrdleb seda numbrit mille ta on juba eelnevalt ka genereerinud.


            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
            int i = 0;
            //genereerib ühe korra, Järjekorras järgmine juhuslik arv on suurem kui 0 <




             while (loopActive)
            {
                 //While sees Random numbrit ei genereeri.
                Console.WriteLine("Tere tulemast mängu. Mängu võitmiseks tuleb valida üks number 1 kuni 10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Õnnitlused! Oled mängu võitnud.");
                    loopActive = false;
                }
                else
                {
                    i++;  //i = i + 1;
                    Console.WriteLine("Kahjuks vale number. Proovi uuesti!");
                    Console.WriteLine($"Oled sisestanud vale numbri {i} korda.");
               }

           }

              Console.WriteLine($"Juhuslik number oli: {cpuNumber}");



        }
    }
}