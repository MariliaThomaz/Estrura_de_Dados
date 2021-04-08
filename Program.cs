using System;

namespace _04_alua_04_03_21_contas
{
    class Program
    {
        static void Main(string[] args)// ele é biblioteta começo  poisa é isto é  ligangem que auto nivel  que voltado para 
                                        //ele é progamação  de  ortada  obije
                                        // se  trata de  promagar dentro outros  progams  e  são  divida em blocos
                                        // este proga roda em sima do Windos é  progama  em sima de  progama
                                        //quando  eu propamamdo  como usar  Console eu assenddo biblioteta  Usnig System se voce 
                                        //apgar System ele não reconhese Console   

            /////////////////////////////////////////////
            // quando  falando using -> quer dix vc esta usando Abioteta System 


        {
            /////////////////////////////////////////////////////////////////////
            //(1) Numero posivo ou negativo

           int nume1;

            Console.WriteLine("Digte numero qualquer: ");
            nume1 = Convert.ToInt32(Console.ReadLine());//Sobe  Int 16 ou 64 ou 32 espaço que  esta vairivel ocupa de espaço na memomoria
                                                        //O Cchape  ele  permite escolhar  para ajudar na criação

            if (nume1 > 0)
            {

                Console.WriteLine("Voce digitou numeo positovo:.");
            }
            else if (nume1 < 0)
            {
                Console.WriteLine("Voce diditou nume negativo");
            }
            else
            {
                Console.WriteLine("Voce digitou Zero");// este furo da questão caso o usarioo ditar zero ele  tera esta  opição

            }
                



            Console.ReadKey();

        }
    }
}
