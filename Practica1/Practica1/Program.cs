using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Numero = 1;
            while (Numero <= 100)
            {
                Console.Write(Numero);
                Console.Write(" - ");
                Numero = Numero + 1;
            }
            Console.ReadKey();
        }
    }
}
