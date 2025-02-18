using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAmpli.Models
{
    public class SomaPares
    {
        private const int ValorMaximo = 50;

        public int SomarPares()
        {
            int soma = 0;
            for (int i = 1; i <= ValorMaximo; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                   // Console.WriteLine(soma);
                }
                
            }
            return soma;
        }
    }
}