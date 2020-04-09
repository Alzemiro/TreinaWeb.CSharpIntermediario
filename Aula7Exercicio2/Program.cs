using System;
using System.Linq;
/*

2 – Declare um delegate genérico que não retornará nenhum valor, mas receberá um parâmetro do tipo T. 
Em seguida declare um método genérico que receberá por parâmetro o delegate e um array de T.

Dentro do método aplique a função vinculada no delegate a todos os elementos do array. 

*/

namespace Aula7Exercicio2
{
    public delegate void Action<T>(T[] array);
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //mostrando o array original
            Console.WriteLine("Lista origianal!");
            foreach (var item in array)
                Console.Write("{0}, ", item);

            //aplicando o delegate
            var del = new Action<int>(DuplicandoElementos);
            del(array);

            Console.WriteLine("\n\n");

            //mostrado o array transformado pelo delegate
            Console.WriteLine("Lista transformada pelo delegate!");
            foreach (var item in array)
                Console.Write("{0}, ", item);

            Console.ReadKey();
        }

        public static void DuplicandoElementos(int[] array)
        {
            //duplicando os elementos do array
            for (int i = 0; i < array.Count(); i++)
                array[i] *= 2;
        }

      }
    }

