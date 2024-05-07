using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_ma = int.MinValue;
            int num_me = int.MaxValue;

            Console.WriteLine("Informe a quantidade de números: ");
            int quant = int.Parse(Console.ReadLine());

            int[] num = new int[quant];

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite o número: ");
                num[i] = int.Parse(Console.ReadLine());

                if (num_ma < num[i])
                {
                    num_ma = num[i];
                }
                if (num_me > num[i] )
                {
                    num_me = num[i];
                }
            }

            Console.Write("Os números digitados foram: ");

            for (int j = 0; j < quant; j++)
            {
                Console.Write(" " + num[j]);
            }

            Console.WriteLine("\n  O menor número é " + num_me);
            Console.WriteLine("O maior número é " + num_ma);

            Console.ReadKey();
        }
    }
}
