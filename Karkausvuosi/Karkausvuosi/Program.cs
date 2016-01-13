using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karkausvuosi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna vuosiluku");
            int Vuosi = int.Parse(Console.ReadLine());
            if (Vuosi % 4 == 0)
            {
                if (Vuosi % 100 == 0)
                {
                    if (Vuosi % 400 == 0)
                    {
                        Console.WriteLine("Vuosi on karkausvuosi");
                    }
                    else
                    {
                        Console.WriteLine("Vuosi ei ole karkausvuosi");
                    }
                }
                else
                {
                    Console.WriteLine("Vuosi on karkausvuosi");
                }
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
        }
    }
}
