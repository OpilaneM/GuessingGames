using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajalt PIn-koodi;
            // programm võrdleb sisestatud pin-koodi arvuga 1234;
            // kui sisestatud pin-kood on 1234, siis konsool kuvab "Tere tulemast";
            // kui sisestatud pin-kood on midagi muud, siis konsool kuvab "Vale pin, proovi uuesti."
            // katsete arv on piiramatu.

            bool loopActive = true;
            int i = 0;
            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:"); //cw=double TAB
                int userPin = Convert.ToInt32(Console.ReadLine());
                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud");
                }
            }
            Console.WriteLine("Kena päeva!");
            Console.Read();
        }
    }
}
