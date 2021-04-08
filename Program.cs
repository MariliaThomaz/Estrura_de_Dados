using System;

namespace _013_Repetisao_while
{
    class Program
    {
        static void Main(string[] args)
        {

            //vaitiverl de contole
            int x = 0;

              // X e vaivel de parada
              // ele tem criterio de parada 
            while(x<5)
            {
                Console.WriteLine("Vamore de x: " +x);

                // voce tem cira encremeto para laço parar 

                x++; // isto é contração x = + 1
                 // O encremto ele seve para conta quantidade de vese que estrutura esecutou 
                 // o emcremtar  ideia dela um dia faz ela parar
                 // por isto criterio de parada

            }



            // faz  while de controle
            string quer_sair = "N";
            //aqui estamosa atribuindo a vaivel já  conteudo dela


            // se  voce quiser saber a  quantidade de vese qu lué  roada
            int repete = 0;
            while( quer_sair != "S" )
            {                        
                repete++; // incremeto - > repete =  repete + 1

                 Console.WriteLine("Vocwe está preso no looping.");
                Console.WriteLine("Quer sair? S ou N");
                quer_sair = Console.ReadLine().ToUpper();// ToUpper para conveter  digitado para maiusculo

                // Modo senha  caso pessoa erra
                if (repete == 3)
                   // quer_sair = "S"; // este é um metodo para deixar rodar  3 vese 3 tentativa de senha
                break; // ou pode usar comando break siquifica parar o lupe

                


            }
            Console.WriteLine("Voce saiu do lupe");
            
                Console.WriteLine("Quantas vese rodou lupe: "+repete);// mosatra quantas ves  lupe rodou
            Console.ReadKey();
        }
    }
}
