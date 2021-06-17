using System;

namespace _020_Aula_swtch
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 0;
            Console.WriteLine("Digite o numeri do mes" );
            mes = Convert.ToInt32(Console.ReadLine());

           // int case = 0;
            //switch ele  é igula a escolha
            switch (mes)
            {
                case 1: // case  mesma coisa caso
                    Console.WriteLine("Janeiro");
                    break;// ele delimita  a onde conhece caso e onde ele termina

                case 2:// Porque  não  usar uma  varivel   qualque no case
                    // case tem que ser valo consatante como numeroa são infinutos
                    // mas  porque  umas contante? 
                    // supondo que eu coloco case jannerio sendo 1
                    //case fefereio senso 1 
                    // o sitema ele  não deixa  fazer redundacia 
                    Console.WriteLine("Ferveriaro");
                    //monte de coidigo
                    // mote de codigo
                    //monte de codigo
                    break;// usa  break para delimita bolocao em ves de  chaves
                    // papel do break é  intreroper o CASe
                    //voce não coloca break sitema não compila




                    //o bisando erros
                    // quando sitmea  tem erro ele abre tela preta Console 
                    // ele roda e o que ele exibe  é valor da utima rodagem que estava certa

                //  Estrura do Switch  ela é mas  legivel  que  if e eles 
                // um dos  motivos  de ser nas  legivel que ele não tme  monte abre fecha chaves
                // chave  seve para limitação dos  blos de comandos, ustilisa elas
                // na switch  pode escrever  monte de codico sem usa chvas então moemtos  que sim não necita de blos litadpes

                case 3:
                    Console.WriteLine("Março");
                    break;


                case 4:
                    Console.WriteLine("Abril");
                    break;

                case 5:
                    Console.WriteLine("Maio");
                    break;

                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;

                case 9:
                    Console.WriteLine("Setwmbro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;

                case 11:
                    Console.WriteLine("Novebro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;

                //exite  uma diretija chmada defoukt
                // tradução para defoukt  é  padrão ou comum uma coisa se não eicaicho um caso então usa  defoukt
                // usa defoukt para cai qualquer coisa
                default:
                    Console.WriteLine("Opição invalida");
                    break;

                    // este sitema esta empanho mesmo que if e else mas  uma difeça
                    // mas se o usario digita numero dinhre como 13?
                    //ia cair  numa opição invalida
                    //mas no swtch tambem tem como faz a opição invale como eles


                    Console.ReadKey();

                    // Devido as chaves do  IF E Else é dificil dar manutentão 
            }










        }
    }
}
