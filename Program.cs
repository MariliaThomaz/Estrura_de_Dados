using System;

namespace _07_alua_04_03_21_contas_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
             * A prefeitura de Mocoa abria uma linha de crédito para os funcionarios 
             * estaturios. O valor  maximi da prestação não podera ulrapassar 30%
             * do salário. Fazer um algoritmi que  permita entrea com o salario bruto
             * e o valor da  prestação, e informar se emprestimo pode ou ser concedido.
             */

            double salario_Bru, trinta_Porcnto, valor_Presracao;

            Console.WriteLine("Informe o salário bruto: ");
            salario_Bru = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Infomar o valor da prestção: ");
            valor_Presracao = Convert.ToDouble(Console.ReadLine());


            trinta_Porcnto = salario_Bru * 0.3;  //  3  /100
            // trinta_Porcnto = salario_Bru  * (30 /100);

            // O Valor da prestação não pode ser maer 30% o valor Trita_Porcnto

            if (valor_Presracao > trinta_Porcnto)
            {
                Console.WriteLine("Emprestimo negado. Presração maiio que 30% do salario.");
            }
            else
            {
                Console.WriteLine("Emprestimo aprovado.");
            }

        }
    }
}
