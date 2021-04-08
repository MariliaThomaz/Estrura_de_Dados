using System;

namespace _03_exer_matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int nume1, nume2, total;

            Console.WriteLine("Digite o primerio numero: ");
            nume1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite so  segundo numero: ");
            nume2 = Convert.ToInt32(Console.ReadLine());

            total = nume1 + nume2;
            //Somando as duas  variveis 

            Console.WriteLine("A soma de  numero1 + numero2 " + total);
            //emando  que   + perto do total quer dizer  contanação

            Console.WriteLine("A soma de numero1 + numero2 usnado Console esibe " + nume1 + nume2);
            /*Caso queira faz conta  deste jeito não  vai  dar certo 
             pois ele deste modo esta reconhesneo como istrig  e sendo concatenado
            */

            Console.WriteLine("A somoa  a  numero1 + numero 2 usando no Console esibe:  " + (nume1 + nume2));
            // acontece que o compilado respieta ordem matematica e esguta a soma do parete

            Console.WriteLine("A Subitração  de  numero1 - numero 2 usando no Console esibe:  " + (nume1 - nume2));
            Console.WriteLine("A Mutipucação 'veses'  numero1 * numero 2 usando no Console esibe:  " + (nume1 * nume2));
            Console.WriteLine("A Divisão  numero1 / numero 2 usando no Console esibe:  " + (nume1 / nume2));
            Console.WriteLine("A sobra da divisao de  numero1 % numero 2 usando no Console esibe:  " + (nume1 % nume2));
        }
    }
}
