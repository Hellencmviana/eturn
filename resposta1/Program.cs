using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resposta1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] conjunto1 = { 23, 5, 8, 17, 0, 3, 4, 2 };
            int[] conjunto2 = { 3, 6, 8, 12, 100, 10, 15 };
           
            //Função que recebe e retorna o valor:
            int[] resultado = juntarArrays(conjunto1, conjunto2);

            //Imprimir:
            int tam = resultado.Length;
            for (int i = 0; i < tam; i++)
            {
                if (i == tam - 1)
                {
                    Console.Write(resultado[i]);
                }
                    else
                    {
                        Console.Write(resultado[i] + ", ");
                    }
            }
            Console.ReadLine();
        }

        private static int [] juntarArrays (int [] array1, int [] array2)
        {
            int[] resultado = array1.Concat(array2).ToArray();
            Array.Sort(resultado);
            return resultado;
       }
    }
    
}
