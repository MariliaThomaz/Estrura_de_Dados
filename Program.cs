using System;

namespace _011_Laso__de_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {

            String senha = "123";
            string emaia = "marilia@gamia";

            int rep = 0;

            while (emaia != "marilia@gamia")
            {
                rep++;

                Console.WriteLine("Digite seu  email");
                emaia = Console.ReadLine().ToUpper();

                Console.WriteLine("Digite seu  email");
                emaia = Console.ReadLine().ToUpper();



            }

            while (senha != "123")
            {
                rep++;

                Console.WriteLine("Digite seu  email");
                senha = Console.ReadLine().ToUpper();


                if (rep == 3)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Voce saiu  erro mais de 3 vese sua senha");
                    Console.BackgroundColor = ConsoleColor.Black;
                }



            }

        }
    }
}
