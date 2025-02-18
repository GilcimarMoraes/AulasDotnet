using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAmpli.Models
{
    public class Quadrados
    {
        private const int ValorMinimo = 15;
        private const int ValorMaximo = 200;

        public void CalcularQuadrados(){
            for (int i = ValorMinimo; i <= ValorMaximo; i++)
            {
                Console.WriteLine($"O quadrado de {i} é: {i *i}");
            }
        }
    }
}