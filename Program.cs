using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraNaKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karte = 0;
            int cardCounter = 0;

            Console.WriteLine("\n -- Igra na karte -- \n");
            
            while (cardCounter < 31)
            {
            unos: Console.Write("Unos: ");
                karte = Convert.ToInt32(Console.ReadLine());
                if (karte <= 13 && karte >= 1)
                {
                    cardCounter += karte;
                }
                else
                {
                    Console.WriteLine("Unesi ispravu kartu od 1 do 13");
                    goto unos;
                }
            }
            if (cardCounter == 31)
            {
                Console.WriteLine("Pobjeda!!");
            }
            if (cardCounter > 31)
            {
                Console.WriteLine("Gubitak!!");
            }

            Console.ReadKey();
        }
    }
}
