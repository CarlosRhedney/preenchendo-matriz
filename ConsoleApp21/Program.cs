using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] c = new int[2, 2];
            int[,] d = new int[2, 2];
            int i, j;

            Console.Write("\nPreenchendo a matriz A2x2");
            for (i = 0; i < 2; i++)
                for (j = 0; j < 2; j++)
                {
                    Console.Write("\nEntre com um número inteiro na posição {0} e {1}: ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            Console.Write("\nPreenchendo a matriz B2x2");
            for (i = 0; i < 2; i++)
                for (j = 0; j < 2; j++)
                {
                    Console.Write("\nEntre com um número inteiro na posição {0} e {1}: ", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }


            for (i = 0; i < 2; i++)
                for (j = 0; j < 2; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    d[i, j] = a[i, j] - b[i, j];
                }

            Console.Write("\nMatriz A");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                    Console.Write("Elemento {0},{1}={2}\t", i, j, a[i, j]);
            }
            Console.Write("\n");

            Console.Write("\nMatriz B");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                    Console.Write("Elemento {0},{1}={2}\t", i, j, b[i, j]);
            }
            Console.Write("\n");

            Console.Write("\nMatriz C");
            for (i = 0; i <2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                    Console.Write("Elemento {0},{1}={2}\t", i, j, c[i, j]);
            }
            Console.Write("\n");

            Console.Write("\nMatriz D");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                    Console.Write("Elemento {0},{1}={2}\t", i, j, d[i,j]);
            }
            Console.Write("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
