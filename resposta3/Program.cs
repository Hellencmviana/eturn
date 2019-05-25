using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resposta3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dicionário:
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("0", " ");
            dic.Add("1", "");
            dic.Add("2", "a");
            dic.Add("22", "b");
            dic.Add("222", "c");
            dic.Add("3", "d");
            dic.Add("33", "e");
            dic.Add("333", "f");
            dic.Add("4", "g");
            dic.Add("44", "h");
            dic.Add("444", "i");
            dic.Add("5", "j");
            dic.Add("55", "k");
            dic.Add("555", "l");
            dic.Add("6", "m");
            dic.Add("66", "n");
            dic.Add("666", "o");
            dic.Add("7", "p");
            dic.Add("77", "q");
            dic.Add("777", "r");
            dic.Add("7777", "s");
            dic.Add("8", "t");
            dic.Add("88", "u");
            dic.Add("888", "v");
            dic.Add("9", "w");
            dic.Add("99", "x");
            dic.Add("999", "y");
            dic.Add("9999", "z");

            string texto = "33 8 88 777 66 0 9 33 22 0 33 0 7777 666 333 8 9 2 777 33 0 7777 666 555 88 8 444 666 66";
            string[] array = texto.Split(' ');
            string resultado = "";

            foreach (var item in array)
            {
               resultado += dic[item] + " ";
            }
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
