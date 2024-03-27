using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV5_CJ3016862
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a, temp;
            // int soma = 0;

            //for (a=0; a<3; a++) {
            // Console.WriteLine("Digite um valor");
            // temp = int.Parse(Console.ReadLine());
            // if (temp < 0);
            // break;
            // soma = soma + temp;
            // Console.WriteLine("A média é {0}", soma / 3);

            Console.WriteLine("===========MENU DO MARQUESITO===========");
            Console.WriteLine("Digite 1 para o exercício 1            =");
            Console.WriteLine("Digite 2 para o exercício 2            =");
            Console.WriteLine("Digite 0 para SAIR                     =");
            Console.WriteLine("========================================");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 0:
                    Console.WriteLine("Obrigado por utilizar o Sistema do Marquesito!");
                    break;
                case 1:
                    Console.WriteLine("Codificação do exercício 1 aqui!");
                    break;
                case 2:
                    Console.WriteLine("Codificação do exercício 2 aqui!");
                    break;
                default:
                    Console.WriteLine("A opção digitada é inválida!");
                    break;
            }






        }
    }
}
