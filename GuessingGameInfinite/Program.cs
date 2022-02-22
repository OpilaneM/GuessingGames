using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrid ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Mis number on?");
                int userPakkumine = Convert.ToInt32(Console.ReadLine());

                if (userPakkumine == cpuNumber)
                {
                    Console.WriteLine("Sinu võit!");
                    loopActive = false;
                }
                else 
                {
                    Console.WriteLine("Vale pakkumine, proovi uuesti!");
                }
            }
            Console.WriteLine("Kena päeva!");
            Console.Read();
        }
    }
}
