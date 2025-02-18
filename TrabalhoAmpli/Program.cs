using TrabalhoAmpli.Models;

class Program
{
    static void Main(string[] args)
    {
        int opcao;

        Console.WriteLine("Escolha a opção desejada: ");
        Console.WriteLine("1 - Apresentar todos os valores numéricos inteiros ímpares situados na faixa de 0 a 40.");
        Console.WriteLine("2 - Apresentar o total da soma dos 100 primeiros números inteiros.");
        Console.WriteLine("3 - Apresentar todos os números divisíveis por 4 que sejam menores que 40.");
        Console.WriteLine("4 - Apresentar os quadrados dos números inteiros de 15 a 200.");
        Console.WriteLine("5 - Apresentar o resultado da soma de todos os valores pares existentes na faixa numérica de 1 a 50.");
        Console.WriteLine();
        opcao = Convert.ToInt32(Console.ReadLine());

        // Validação da entrada do Usuário
        //if (!int.TryParse(Console.ReadLine(), out opcao))
        //{
        //    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
        //    return;
        //}

        switch (opcao)
        {
            case 1: 
                NumerosImpares ni = new NumerosImpares();
                ni.ContarImpares();
                break;

            case 2:
                SomaDosNumerosInteiros sni = new SomaDosNumerosInteiros();
                int resultado = sni.SomarNumeros();
                Console.WriteLine($"A soma dos 100 primeiros números inteiros é: {resultado}");
                break;

            case 3:
                DivisoresDeQuatro dq = new DivisoresDeQuatro();
                dq.Divisor();
                break;

            case 4: 
                Quadrados quadrados = new Quadrados();
                quadrados.CalcularQuadrados();
                break;

            case 5:
                SomaPares sp = new SomaPares();
                int soma = sp.SomarPares();
                Console.WriteLine($"A soma dos pares no intervalo proposto é: {soma}");
                break;
        
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}