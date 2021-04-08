using System;

namespace _09_aula_11_03_21_aulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
            * Um vendendor trabalha com frios. Para cada produto há uma aliquota de comissão,
            * conforme a especificação abaixo:
            * Mussarela:     5.0%   Preço kg: 22,60
            * Mortadela:     6.5%   Preço kg:  8,98
            * Presunto:      4.5%   Preço kg: 31,03
            * Peito de Peru: 2.5%   Preço kg: 58,90
            * Sabendo da aliquota da comissão: faça um programa que leia as quantidades vendidas
            * pelo vendedor e calcule a comissão.
            */

            double Mussarela, Mortadela, Presunto, Peito_Peru,Valor;
          

            Console.WriteLine("Dite o valor do km: ");
            Valor = Convert.ToDouble(Console.ReadLine());

            Mussarela =  Valor * 22.60;
            double Mussarela_Comi = Mussarela * 0.05;
            Console.WriteLine("Valor km  da musarela: " + Mussarela);
            Console.WriteLine("Valor da comição da  mussarela 5.0%: " + Mussarela_Comi);

            Mortadela =  Valor * 8.98;
            double Mortadela_Comi = Mortadela * 00.65;
            Console.WriteLine("Valor km  da mortadela: " + Mortadela);
            Console.WriteLine("Valor da comição da  Mortadela 6.5%: " + Mortadela_Comi);

            Presunto = Valor * 31.3;
            double Presunto_Comi = Presunto * 0.045;
            Console.WriteLine("Valor km  da presuntado " + Presunto);
            Console.WriteLine("Valor da comição da  presuntado 4.5%: " + Presunto_Comi);


            Peito_Peru = 58.90 * Valor;
            double Peito_Peru_Comi = Peito_Peru * 0.025;
            Console.WriteLine("Valor km  da Peito de Peru: " + Peito_Peru);
            Console.WriteLine("Valor da comição da  Peito de Peru 2.5%: " + Peito_Peru_Comi);









        }
    }
} 
