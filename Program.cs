using System;
using System.Globalization;
//aquie nova biblioteca using System.Globalization
//que ela que da famila ou da caixa do system
// ela seve para formata algo de codo local q esta sendo utiliada

namespace _05_alua_04_03_21_contas_5_clase
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
             * Definindo o formato de número brasileiro.
             */
            NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;// voce cria varivel nfi  ela do tipo  NumberFormatInfo
                                                                         // varivel nfi vai recerber  = new CultureInfo("es-AG").NumberFormat
                                                                         // a  inf  ela quare infomação  como nosa queromos a formatação
                        //a varivel nfi ele comvete os numeros comofome voce quer 
                        // mudar numero para forma que no brasil $
            /**
             * $1,000.00 => en-US
             * R$ 1.000,00 => pt-BR
             * E 1.000,00 => pt-PT
             */

            /**
             * 5) A CEF concederá um crédito especial com juros de 2% aos seus clientes de acordo com 
             *    o saldo médio no último ano. Fazer um programa que leia o saldo médio de 
             *    um cliente e calcule o valor do crédito de acordo com a tabela a seguir. Imprimir 
             *    uma mensagem informando o saldo médio e o valor de crédito. 
                Saldo Médio           Percentual
                De 0 a 500            Nenhum crédito
                De 501 a 1000         30% do valor do saldo médio
                De 1001 a 3000        40% do valor do saldo médio
                Acima de 3001         50% do valor do saldo médio 
             */


            // saldo_ medio ela  não sabe o que dentro dela difete de valor_credito ela ja  tem valor 0
            double saldo_medio, valor_credito = 0;
               /*
             * Porque eu  tenho  colocar vaitive valor_credito = 0
             * ***porque
             * poisa a linquagem de  progamação não tem certrza se vai consegir 
             * porder por entrada  que vai se encaichar pois ela passa por todos  estuturas que são -> else if
             *  quando nos pedimo para esibir  conteudo da varivel para usuario  ela não sabe poisa
             *  já que ela andou por vaios -> else if
             *  enão voce inicialisa ela com ZERO -> 0
             *  valor_credito = 0
             */



            Console.WriteLine("Informe o saldo médio da sua conta no último ano: ");
            saldo_medio = Convert.ToDouble(Console.ReadLine());
            //agora vai ganhar valor

            // saldo = 1000;
            if (saldo_medio>=0 && saldo_medio<=500)
             {
                valor_credito = 0;//De 0 a 500            Nenhum crédito

            }                        //e
            else if(saldo_medio>=501 && saldo_medio <= 100)  /// ou é  ||  conhesido por OR
            {
                
               valor_credito = saldo_medio * 0.3;// De 501 a 1000         30 % do valor do saldo médio



            }

                                         //e
            else if (saldo_medio >= 1001 && saldo_medio <= 3000)
            {
                valor_credito = saldo_medio * 0.4;// De 1001 a 3000        40 % do valor do saldo médio

            }
            else if (saldo_medio >= 3001)
            {
                valor_credito = saldo_medio * 0.5;//Acima de 3001         50% do valor do saldo médio 
            }

            Console.WriteLine("O saldo médio informado é: {0}", saldo_medio.ToString("C", nfi));
            Console.WriteLine("O valor do seu Crédito é: {0}", valor_credito.ToString("C", nfi));
            //metodo ToString ele metodo que convete

            Console.ReadKey();

















        }
    }
}
