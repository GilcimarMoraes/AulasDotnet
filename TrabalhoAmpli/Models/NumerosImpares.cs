using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAmpli.Models
{
    public class NumerosImpares
    {
        private const int ValorMaximo = 40;

        public void ContarImpares()
        {
            int contador = 1; // Contador para ordenar impressão
            for (int i = 0; i <= ValorMaximo; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{contador}º ímpar: " +i);
                    contador++;
                }
            }
        }
    }
}