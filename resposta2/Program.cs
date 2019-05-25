using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resposta2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 23, 5, 8, 17, 0, 3, 4, 2, 47, 32, 12, 51 };
            
            //Função recebe e retorna valor:
            int resultado = penultimoValor(array);

            //Imprimir:
            Console.Write("Segundo maior valor do array: "+resultado);
            Console.ReadLine();
        }
        private static int penultimoValor(int[] array)
        {
            Array.Sort(array);
            return array[array.Length - 2];
        }
    }
}
