using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAmpli.Models
{
    public class DivisoresDeQuatro
    {
        private const int ValorMaximo = 40;

        public void Divisor()
        {
            int contador = 1;
            for (int i = 1; i < ValorMaximo; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine($"O {contador}º divisor de 4 no intervalo proposto é: {i}");
                    contador++;
                }
            }
        }
    }
}