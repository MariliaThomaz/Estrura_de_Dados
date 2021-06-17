using System;

namespace _020_Caculadora_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacao;// aqui évarivel pega  operação que usario escolheu 
            double numero1, numero2, resultado=0;
            bool fazer_outra_operacao = false  ;
            do
            {

                //toas vese que repetie  limpa tela
                Console.Clear();

                //*****************luper para  repetir  para usario quer fazer nova  operaçao*****************

                //case ele atribui
                //SE for numero que  ele é case 1 
                //ELE FARA que sera
                // atribuido ele
                Console.WriteLine("Informe a operação desejada e em seguida dois numeos");
                Console.WriteLine("Informe a Operação");
                Console.WriteLine("DiGITE + para Adição");
                Console.WriteLine("DiGITE - para Subritração");
                Console.WriteLine("DiGITE * para Multiplicação");
                Console.WriteLine("DiGITE / para Divisão");

                //*****************luper para verificar es digitol o operador certo*****************
                bool digitação_valida_operador = false;//
                do
                {
                    operacao = Console.ReadLine();


                    switch (operacao)
                    {
                        case "+":// isto é chamdao de alinhameto das case
                        case "-":
                        case "*":
                        case "/":
                            digitação_valida_operador = true;
                            break;
                        // usando swtch para faz verificação

                        default:

                            digitação_valida_operador = false;
                            Console.WriteLine("Digite uma operação  valida. Voce ditou {0} ", operacao);
                            break;

                    }
                } while (!digitação_valida_operador);//SEMPRE REPETE


                //*****************luper para vefificar se digitol numero certo*****************

                // vou atribui para varivel  que elaentra valor falso

                bool digitação_valida_numero1 = false; // boll vem bolendo que verdadeiro e falço 
                do
                {
                    Console.WriteLine("Digite  o primero Numero:");
                    digitação_valida_numero1 = Double.TryParse(Console.ReadLine(), out numero1);
                    //Doublre é tipo de dado
                    //TryParse ele tenta comvete o que usario digitol
                    // Ele tenta comveter  para tipo Double
                    // Se ele cosequer comveter -->  usa  -> , out  varivel numero1  i out numero1
                    // ele colca valor comvetido na vairivel  numero1 
                    // o que siquinifica  aut  numero1?
                    //se a comvesção der  certo o out expota valor para varivel numero1
                    // Como saber  deu certp?
                    // Atraves das respota que  tryparse ele  envia  falco ou verdadero 

                } while (!digitação_valida_numero1);//Repete equanto   digitação_valida_numero1  NÃO (!) For valilida (tru)
                                                    // Para o while repete boolenoa debtri do(



                // SUPONDO QUE USUARIO DIGITA O VALOR 8
                // AOU PASSAR  PELO  TRYPARSE ELE COMVETE  E  DEIXA  O VALOR COMVEETIDO NA VAVIRAVEL  digitação_valida_numero1
                // E TRYPASE SERA VERTADERI  TRU
                // E PARA SAIR SO LUPE  TEM SER FALSO   ENTO NEGO  NO WILE
                // FUNSONA ASSIM
                // VALOR  = 8 = F
                //TRYPARSSE = 8 = V
                //WHILE NEGA = V-F = F
                //Sai lupe

                // OUTRAS  POSIBILIDADE

                // VALOR  = g = F
                //TRYPARSSE = g = F
                //WHILE NEGA = F-F = V
                //Figa no lupe 

                // Poque valor digitação_valida_numero1 ele atribuido como falso para caso  o usario digite  algo já errado

                bool digitação_valida_numero2 = false;
                do
                {
                    Console.WriteLine("Digite  o segundo  Numero:");
                    digitação_valida_numero2 = double.TryParse(Console.ReadLine(), out numero2);

                } while (!digitação_valida_numero2);//SEMPRE REPETE





                switch (operacao)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;

                    case "-":
                        resultado = numero1 - numero2;
                        break;

                    case "*":
                        resultado = numero1 * numero2;
                        break;

                    case "/":
                        resultado = numero1 / numero2;
                        break;

                    default:

                        Console.WriteLine("Operação invalida");
                        break;



                }

                Console.WriteLine("Valor de 1:" + numero1 + " |Valoor de 2: " + numero2);
                Console.WriteLine("O resulatado é {0}", resultado);

                //TESTE  PARA VER SE QUER RODE  S  e  N
                Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não? ");

                // O biser que FI e ElSE não usara chaves :O
                //Quando voce tem uma  linha só IF não presia usar  chave
                //Mas só pode usar quando um linha



                /*
                if (Console.ReadLine().ToUpper() == "S")
                    fazer_outra_operacao = true;
                else
                    fazer_outra_operacao = false;

                */

                // esite  outro modo de  faz  este  IF

                // ************************* Operador  Ternário*********************

                //O operadoe ternario tem mesma  função do IF  E ELSE 
                //


                fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;

                //Dentro dos pates  é teste ()
                //O que siquinifica Console.ReadLine().ToUpper() == "S" | Eu vou ler  o que escrito   na respta uario compara se S 
                // sabemosa  que  IF neste caso ele retona  Verdadeiro ou Falso 
                //apos faz teste -->Console.ReadLine().ToUpper() == "S"-->  pode ser Verdade  ou falso 
                // Teste --> Console.ReadLine().ToUpper() == "S" --> Se der Verdade --> ele atende depoisa da Integasação ? --> True
                //Testa --> Console.ReadLine().ToUpper() == "S"--> se for Falso --> Pula para o ? True  vai para SeNão que é os doisa  pontos : --> False


            } while (fazer_outra_operacao);

            Console.WriteLine("Fim do progama ");
            Console.ReadKey();
        }
    }
}
