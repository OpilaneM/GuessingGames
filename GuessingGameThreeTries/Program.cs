using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrid ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata;
            // siis mängu võidab arvuti;
            //programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Mis number on?");
                
                int userPakkumine = Convert.ToInt32(Console.ReadLine());

                if ( userPakkumine == cpuNumber)
                {
                    Console.WriteLine("Sinu võit!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti, {3 - i} katset on veel!");
                }
            }

            Console.WriteLine("Kena päeva!");
            Console.Read();
        }
    }
}
