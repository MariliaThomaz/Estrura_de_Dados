using System;

namespace _015_atividade_login_senha_for
{
    class Program
    {
        static void Main(string[] args)

        {
            

            /*
          * Faça um progrma de login, onde  o usario possa tentar digitar
          * o usario e a senha um número p´re faxado de vezes, caso não consiga
          * o sistema impede novas tentativas
          */

            string usario_correto = "marilia"; // aqui esmosa  decladondo a varivel
            //  aqui esmosa  decladondo a varivel com atribuição do que ela tem dentro dela.
            string senha_correta = "123";
            //  aqui esmosa  decladondo a varivel com atribuição do que ela tem dentro dela.

            int tentativa_permitadas = 3;
            // Aqui nos  atribunmos  valor de tentiva que o usarioo pode erar a senha e emai;

            int tentivas = 0; //esta varivel é para gardar quantidade de vese que rou as tentiva tipo Contador

            // aqui for  laço re repetição
            // int i =0; aqui  sendo criado vavivel de contole
            //  i < tentativa_permitadas ;  aqui esmos fazendo comação para  deteminar numero de  rodagem  e este numero etá  armasenaodna vaievel  numero_tentativa
            // i ++ : aqui faz  incremeto
            for (int i = 0; i < tentativa_permitadas; i++)
            {
                Console.WriteLine("Infome seu emal:");
                //Obieve qui  esta sendo  declado a vavel junto com lugar vai armazenar conteudo 
                string usario_infomado = Console.ReadLine();

                Console.WriteLine("Infome seu senha:");
                //Obieve qui  esta sendo  declado a vavel junto com lugar vai armazenar conteudo 
                string senha_infomado = Console.ReadLine();



                tentivas++;//é feito o incremto para poder faz a contagem ele  faz conta soma sabendo que foi feito



                //aqui faremos  comparação com valor que progamdor atribui com  valor do uario digitou
                if (usario_infomado == usario_correto && senha_infomado == senha_correta)
                {
                    // digitou usario correto
                    Console.WriteLine("Está certo, ben vindo ao sistema.");

                    break;//Colocado Break para caso o usario digite coretamte o que foi pedio para sistema não rodar naovamte poisa esta certo senha email
                }
                else
                {
                    Console.WriteLine("Uuario e Senha incorretos. Tetativas restante: " + tentativa_permitadas + "/" + +tentivas);
                }

            }
            Console.WriteLine("Saio do lupe");

            Console.ReadKey();
            
            


            //*******************************************************************************************************************************************


            


        }
    }
}
