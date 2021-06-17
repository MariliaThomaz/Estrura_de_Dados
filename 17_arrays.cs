using System;

namespace _017_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            {

                //  o que  é uma arreio?
                // imagine  uma  lita como dias semnas
                // Dias da semanas: 0-Segunda,1- Terça, 2-Quarta, 3-Quita, 4-Sexta, 5-sabado e 6-Domigo
                //
                //  Em ves voce cria uma  vaivele para armazena  todas estas respostas
                // 
                //Fazer em foma de Veotr e como  faz Veto?
                //
                // Como se trata de  lista dos dias da semana  é formato string
                //
                //Para fala que é  uma arreio tem usra um conhete que quadrado []
                // um arreio de string[]
                // voce tem colocar nome no array = [] semona
                // voce cria ela  = new string[7] tamanho dela  como 7  poisa  cabe sete dias da semanas 

                string[] semana = new string[7] { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", "Domigo" };
                // o sete limita possição caso queria lametar
                // outro metodo de falar  a  posação de cada  item é {"Segunda", "Terça","Quarta","Quinta","Sexta","Sabado","Domigo" }

                //Um dos metodos  para sitema saber  o que tem nesta  tabela 
                //voce  pode diz paral ela a posiçao ela está
                // o Arreio ele te i que é do index
                // o arreio comesa fempre com O Zero

                //   I |   Valor
                //   0  |  Segunda
                //   1  |  Terça 

                // este um metodo de faz o arreio mas ele repetitivo
                // semana[0] = "Segunda";
                //  semana[1] = "Terça";
                // semana[2] = "Quarta";
                //  semana[3] = "Quinta";
                // semana[4] = "Sexta";
                // semana[5] = "Sabado";
                // semana[6] = "Domigo";




                // Interação,  com estrura de repetição 
                // for  é estrura de repetição que ele andara  sobre todas as  posição
                // ele  ten  varivel i que index  varivel de controle

                // aposa declação da varivel  é feito  aposa ;  um comparcão com i <= semana
                //
                // Porque  semana  usa  ponto .
                //Quando usa  o ponto . sabemosa que quer diz que  há  propidades que  pode ser esolhida no C#
                // Nos esmosa trabalnado com String ela é obijeto 
                // este obieto sera propodade  pode ser uado
                //a preoidade mais uasada no arreio é:  Length
                // oque  faz Langth
                // ela mosata numero  de posaição do meui arreio 
                //
                // NÃO esquesça do crieterio de pada  poisa se voce não coloca i++ ele fira rodando infinitmate
                for (int i = 0; i < semana.Length; i++)

                {
                    //a qui pode mostra tudo esta seu arreio
                    Console.WriteLine("O dia da semada 1  é: " + semana[i]);//  fato por varivel i eu vou esibre toda ves que for roda na piemro ves vai oçha  i é zero então segunda
                }    //na segunda rorada i é 1 então terça



                //aqui  sera esibido o oq ue voce escolheo  no arreio que samado por semana [] dentro do 
                //conhetes  voce esolhre o que quer ser esibido

                //  Console.WriteLine("O dias da semana é : " + semana[2]);

                // Outro metodo de

                // Iteração com  FOREACH

                //       PARA CARA
                //       FOR   EACH 
                // Este  Foreach
                // ele  bom para  inciante logica simplres 
                // cria varivel que ira armazena todos item do array  fasrendo rodagem como for
                // cria varivel nome : dia
                // para que seve : in ele vai repetir para cada ves  que tiver  incrementação do lupe ele pega contrudo do arreio explo segunda e joga na varivel dia
                foreach (string dia in semana)
                {
                    Console.WriteLine("O dia da semada 2 é: " + dia);
                }

                // funsonalidade  do Array
                //  isto é da classe a  rreio Array.IndexOf(semana, "Quarta")
                //  Array.IndexOf(semana, "Quarta") ela manipula arreia
                // tem passar doi agumetos 
                // preimero argumto = seja areio semana,
                // seguna conteio esta arreio "Quarta"
                // qual é posição que dentro meu arremio  mostra numero
                Console.WriteLine("O dia da semada 3 é: " + Array.IndexOf(semana, "Quarta"));

                // com este metodo da para ve tem conteuo no arrio 
                // Array.IndexOf seve  para veficar o que dentro do arreio 

                // arrays dentro outro arrays 










                Console.ReadKey();




            }
        }
    }
}
