using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajalt PIn-koodi;
            // programm võrdleb sisestatud pin-koodi arvuga 1234;
            // kui sisestatud pin-kood on 1234, siis konsool kuvab "Tere tulemast";
            // kui sisestatud pin-kood on midagi muud, siis konsool kuvab "Vale pin, proovi uuesti."
            // kasutajal on kolm katset.


            int i = 0;
            while (i < 3)  //While-loop >> i=1; 1<3 --> true; 2<3 --> true; 3<3 --> false
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                }
            }
            Console.WriteLine("Kena päeva!");

            Console.Read();
            
        }
    }
}
