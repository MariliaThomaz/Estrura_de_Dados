using System;

namespace _05_alua_04_03_21_contas_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * O  etanol rende 70% em relação au seja, seum carro da 10 km com
             * gaslina fara  70 km etano. Portanto opreço do etanal não pode ultrapassar
             * 70% do preço gasolina prara ser viavel financeiramento.
             * 
             * redimeto_etanol = (preco_etanol * 100)/ preço_gasolia
             * 
             * */
            decimal preco_etanol, preco_gasolina, redimeto_etanol;

            Console.WriteLine("Infome o preço do Etanal: ");
            preco_etanol = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Infoma o preço  da Gasolina: ");
            preco_gasolina = Convert.ToDecimal(Console.ReadLine());

            //para resover a regra de 3
            /*
            |valor da gaolina  5,15           100
                                       X
             valor do etanlo  4.00              x
            ------------------------------------------------------
            5,15 X = 4.00 * 100

            X  = 4 * 100 = Respta da  400

            4000 / 5.15 = respota 77,6699...
            NÃO  DAUSAR A GASOLIA  PQ  PASSOU DE 71
            */


            redimeto_etanol = (preco_etanol * 100) / preco_gasolina;

            if(redimeto_etanol > 70)
            {
                Console.WriteLine("Compenda a Gasolina.");
            }
            else
            {
                Console.WriteLine("Comoensa o Etanal.");
            }











            Console.ReadKey();
        }
    }
}
