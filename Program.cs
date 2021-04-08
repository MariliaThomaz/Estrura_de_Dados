using System;

namespace _05_alua_04_03_21_contas_2
{
    class Program
    {
        static void Main(string[] args)
        {

            ///// (2) Número  par  ou  impar

           double resto;
            int nume1;

           
            Console.WriteLine("Digite um umero inteiro: ");
            nume1 = Convert.ToInt32(Console.ReadLine());
            
            resto = nume1 % 2;         /*
                                        * Este % que da  resto da divisão ele já tem uma função imbotita
                                        * que é pegar o valor digitado e dividir  por dos 
                                        * SE o numero foe par ele  não havera resto
                                        *  é isto que % faz ela mostra se o valore digitado tem  resto
                                        *   9 / 2 = 1
                                        */


            //Console.WriteLine("este numero é: " + resto);
            
            if (resto == 0)/// quando se trata de == é  o  compador  igual 
            {
                Console.WriteLine("O Numeo digitado é Par");
            }
            else
            {
                Console.WriteLine("Numeo que foi digiado é Impar");


                /// OUTRO MODO  DE FAZER 
                /// 
               

                Console.WriteLine("Digite um umero inteiro: ");
                nume1 = Convert.ToInt32(Console.ReadLine();


                if ((nume1 % 2 )resto == 0)/// quando se trata de == é  o  compador  igual 
                {
                    Console.WriteLine("O Numeo digitado é Par");
                }
                else
                {
                    Console.WriteLine("Numeo que foi digiado é Impar");

                }








                    Console.ReadKey();
            }

        }
    }
}
