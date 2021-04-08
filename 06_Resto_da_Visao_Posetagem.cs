using System;

namespace modulo_resto_divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //   % de módulo, pega o resto de uma divisão

        double resultado_divisao_por_dois;
        int numero;   

            Console.WriteLine("Digite um numero inteiro qualquer: ");
            numero = Convert.ToInt32(Console.ReadLine());

      

            resultado_divisao_por_dois = numero / 2;

            Console.WriteLine("O resultado da divisão é {0} ", resultado_divisao_por_dois);

            double resto_da_divisao = numero % 2;
            //obisve que ele crioi varivel já  dentro

            Console.WriteLine("O resto da divisao do número por dois é {0}", resto_da_divisao);
 

            // Modulo usado para  ver  par impar.








        }
    }
}
