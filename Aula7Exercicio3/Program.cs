using System;

//Considerando a classe Par
//Crie dois métodos genéricos, 
//um que itera arrays de objetos desta classe, e outro que troca os valores das propriedades.

namespace Aula7Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testando o método Iterator
            var array = new Par<int, string>[] {
                        new Par<int, string>(1, "C#"),
                        new Par<int, string>(2, "VB.NET"),
                        new Par<int, string>(3, "Java"),
                        new Par<int, string>(4, "PHP")
            };

            Iterator(array);

            Console.WriteLine("\n\n");

            //testando a troca de valores das propriedades
            var obj = new Par<int, int>(10, 20);
            Console.WriteLine("O valor original do objeto:\n{0}", obj);

            Swap(obj);
            Console.WriteLine("O valor trocado do objeto:\n{0}", obj);

            Console.ReadKey();
        }

        //Iterando o array da classe
        private static void Iterator<T, U>(Par<T, U>[] array)
        {
            foreach (var item in array)
                Console.WriteLine(item);
        }

        //Trocando os valores das propriedades
        //Para não dar erro, obriga o objeto a 
        // ter as duas propriedades do mesmo tipo
        private static void Swap<T>(Par<T, T> obj)
        {
            T aux;

            aux = obj.Var1;
            obj.Var1 = obj.Var2;
            obj.Var2 = aux;
        }
    }
}
