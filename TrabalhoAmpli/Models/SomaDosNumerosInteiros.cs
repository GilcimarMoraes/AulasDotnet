using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAmpli.Models
{
    public class SomaDosNumerosInteiros
    {
        private const int ValorMaximo = 100;

        public int SomarNumeros()
        {
            int soma = 0;
            for(int i = 1; i <= ValorMaximo; i++)
            {
                soma += i;
                //Console.WriteLine(soma);
            }
            return soma;
        }
    }
}