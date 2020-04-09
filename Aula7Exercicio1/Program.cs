using System;
using System.Collections.Generic;

namespace Aula7Exercicio1
{
    //1 – Crie um método genérico que receba por parâmetro dois valores: uma lista de valores, e um valor mínimo; 
    //e que retorne a quantidade de elementos maior que o valor mínimo presente na lista.
    class Program
    {
        static void Main(string[] args)
        {
            var listaInteiro = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var valorMinimoInt = 5;
            var listaFloat = new List<float>() { 1.5F, 2.7F, 4.6F, 7.8F, 9.9F, 10.12F };
            var valorMinimoFloat = 4.8F;
            var listaString = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8" };
            var valorMinimoString = "3";


            var result = ContaMaiores(listaInteiro, valorMinimoInt);
            Console.WriteLine("Quantidade de valores maiores que {0} na lista de inteiros {1}", valorMinimoInt, result);


            result = ContaMaiores(listaFloat, valorMinimoFloat);
            Console.WriteLine("Quantidade de valores maiores que {0} na lista de float {1}", valorMinimoFloat, result);

            result = ContaMaiores(listaString, valorMinimoString);
            Console.WriteLine("Quantidade de valores maiores que {0} na lista de strings {1}", valorMinimoString, result);

        }

        private static int ContaMaiores<T>(List<T> lista, T min)
        {
            int count = 0;
            try
            {

                foreach (var item in lista)
                {

                    double elemento = (double)Convert.ChangeType(item, typeof(double));
                    double minimo = (double)Convert.ChangeType(min, typeof(double));

                    if(elemento > minimo)
                    {
                        count++;
                    }
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Erro: {0}", ex);
            }
            return count;

        }


    }
}
