using System;

namespace _015_atividade_login_senha_do_while
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


            //string usario_correto = "marilia"; este tipo de motagem que voce  atibui o conteudo da vairvel para ela sem opição de 
            //de um usario digitar é tambem chamdo de constante, porque não muda (Contante nao é uma varivel)


            string usario_infomado; // string senha_infomado                                                                
            string senha_infomado;  // Voce tera decara varivel fora do Do poisa para while 
                                  // mesma coisa que não esite pois esta dentro do 
                                                                                                      


            string senha_correta = "123";
            //  aqui esmosa  decladondo a varivel com atribuição do que ela tem dentro dela.

            int tentativa_permitadas = 3;
            // Aqui nos  atribunmos  valor de tentiva que o usarioo pode erar a senha e emai;

            int tentivas = 0; //esta varivel é para gardar quantidade de vese que rou as tentiva tipo Contador


            //veradeio ou falço 
            bool login_valida = false; // estamoe falando login começa com falso 
            //bool login_valida = false; !
            //! => NOT negação de false e true e vise e versa




            //FAÇA
            do
            {

                Console.WriteLine("Infome seu emal:");
                //Cria varivel  senha_infomado  fora do DO para  reconhecer no WHILE

                usario_infomado = Console.ReadLine();

                Console.WriteLine("Infome seu senha:");
                //Cria varivel  senha_infomado  fora do DO para  reconhecer no WHILE
                senha_infomado = Console.ReadLine();




                //tentivas++; Acabou de de ser digitado o valor do usario então soma a rogadem (tetativa)
                // incremetando
                tentivas++;


                //aqui faremos  comparação com valor que progamdor atribui com  valor do uario digitou
                if (usario_infomado == usario_correto && senha_infomado == senha_correta)
                {
                    //aui  voce falando que se a comação for verdadeita
                    login_valida = true;

                    break;//Colocado Break para caso o usario digite coretamte o que foi pedio para sistema não rodar naovamte poisa esta certo senha email
                }
                else
                {

                    Console.WriteLine("Uuario e Senha incorretos. Tetativas restante: " + tentativa_permitadas + "/" + +tentivas);
                }




                //verifiCANDO SE TEM TENATIVAS DISPONIVEL
                //para faz parda de quntas tentativas foi pemitidas voce faz compação com vaivel  tentativas_permitdas
                if (tentivas == tentativa_permitadas)
                {
                    Console.WriteLine("Exedeu o numeo maximo de tentativas");
                    break;//usa para para assim que laço tentar 3 vese que é valor da varive tentativa_permitadas
                    

                }


                
               //While Engato
     
                // o que sinal de estacmação faz? 
                // ele inteve  valo  colo falso para verdadeio
                // false para vira  true 
                //eganto o login não foir valido. fica repetido
            } while (!login_valida);

            // vo tem saber  se  login é veradeio faz comparação 
            //se login_valido = true;
            //ela se tona vervadeira quando usario  digita emial e senha coreta
             if(login_valida)

             Console.WriteLine("Está certo, ben vindo ao sistema.");

            Console.WriteLine("saio do for");


            /*
             * quando se tara de  bolenao BOOL
             * Se vove tem item falso  como login_valido = false  e voce nega ele ese tona vernadeio
             * isto ´é carateritica boenaa
             * 
             * se voce tem um item  vertaveiro como tru voce quer acontario vc nega ele
             * 
             * 
             */

















            Console.ReadKey();
        }
    }
}
