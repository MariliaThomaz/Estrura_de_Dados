using System;

namespace _02_aula_25_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            // INDETÇÃO CTRL + K + D

            // Operadores
            //   + de adição (observar o contexto)
            //   - de subtração
            //   * de multiplicação
            //   / de divisão
            //   % de módulo, pega o resto de uma divisão         

            // % Ele pega  o  resto de  uma divisão 



            /*int numero;
            Console.WriteLine("Digite um numero inteiro qualquer: ");
            numero = Convert.ToInt32(Console.ReadLine());
            double resultado_divisao_por_dois;
            resultado_divisao_por_dois = numero / 2;
            Console.WriteLine("O resultado da divisão é {0} ", resultado_divisao_por_dois);
            double resto_da_divisao = numero % 2;
            Console.WriteLine("O resto da divisao do número por dois é {0}", resto_da_divisao);
            */





            /**
             * imc = peso / (altura * altura)
             */


            double imc, peso, altura;
            /*  usamos o  double poisa  pode dar  numero quebado como peso, atura
             *  poisa  pode pesa 35.50 ou atura  1,67.5
            */

            string nome;

            Console.WriteLine("Cálculo do Indice de Massa Corporal - IMC");




            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();// Quabdo colocamos ReadLine quer diz que peamosa o que uario digitou


            /*
             * Pq a string não usa convert como nos  outros  Double INT?
             * 
             * pq computado ele reconhe tudo que  digitando como TEXTO
             * Então voce forçar indicar insplicitamte que esta digitando é  numero
            */


            Console.WriteLine("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());// Quabdo colocamos ReadLine quer diz que peamosa o que uario digitou

            Console.WriteLine("Didite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine()); // Quabdo colocamos ReadLine quer diz que peamosa o que uario digitou

            imc = peso / (altura * altura);
            /*o Visual ele respeira as regras  matematicas então ele efetua
             * a conta primero que esta no parentes.
            */


            ///////////////////Não é pontrito o asterisco ////////////////////


            Console.WriteLine("O valor do seu IMC: " + nome + ", IMC: " + imc);

            /*
             * Regras de Classificação  do IMC
             * IMC abaio de  18,5,    = "Muito abaixo do peso".
             * IMC entre 18,5 e 24,9  = "O Peso normal".
             * IMC entre 25,0 e 29,9  = "Sobre  peso">
             * IMC entre 30,0 e 24,9  = "Obesidade Grau 1".
             * IMC entre 35,0 e 39,9   = "Obesidade Grau 2".
             * IMC maior que 40 =  "Obesidade  Grau 3 ou Morbida".
             * 
             */

            // SE = IF
            // SENÃO  = else

            Console.WriteLine("Seu  IMC é {0} ", imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Muito abaixo do peso");

            }
            else if (imc >= 18.5 && imc <= 24.9)
            /* lembrando que   a  leiitura feita por                                                * **************OPERADORES  LOGICOS**************
                 ((imc >= 18.5) && (imc <= 24.9))                                                             * MAIS UASO SÃO: and e OR
                    VERDEIRA    E    VERDADEIRA                                                               * AND  É  && : siquinificado=  E
             */
            {
                Console.WriteLine("O Peso normal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Sobre  peso");

            }
            else if (imc >= 30 && imc <= 34.9)
            // visial para separa  o decima é ponto . 
            {
                Console.WriteLine("Voce esta  obesidade Grau I");

            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Voce esta  obesidade Grau II");

            }
            else if (imc >= 40)
            {
                Console.WriteLine("Voce esta  obesidade Grau III Morbito");
            }

            Console.WriteLine("Seu IMC  EDIATADO é:  " + imc.ToString("0.00"));
            // o metodo ToSteing  ele seve para esecutar  uma ação 
            //  esta ação convete  um Numero para Palavra
            // Ele  tem opição depassa modo que vc  quer a  converção
            //             ToString("0.00") é passar padão
            // uma coisa  é mostra
            // usar todas as casa
            // use sempre todas as casa diz profi



            Console.ReadLine();//TIRA SUEJEIRA

        }
    }
}
