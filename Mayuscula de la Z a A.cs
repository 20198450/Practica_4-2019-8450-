using System;

namespace Muesta_Letra_Z_a_A_Mayuscula
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            for (letra = 'Z'; letra >= 'A'; letra--)
                Console.Write("{0} ", letra);
        }
    }
}
