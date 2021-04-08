using System;

namespace _014_Repetição_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // E caso que eu presio faz  uma repetição e ferificar se para
            //Do ele ele esecuta uma ves testa

            int y = 50; 
          // int y = 25;  ele vai esecutar  uma ves só  e while  bara poisa maior que ele
            do// faça
                // ele não esta fazendo neum teste
            {
                Console.WriteLine("o  valor de y:" + y);

                y++; // encremto para não faz lupe infinto 

            //Criterio de  parada 
            } while (y < 5);

            Console.WriteLine("Sai do DO... Wile com Y valendo: " + y);

            Console.ReadKey();

            //foreach ele maisa vetor
        }
    }
}
