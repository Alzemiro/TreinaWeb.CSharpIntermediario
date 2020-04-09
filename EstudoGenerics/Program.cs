using System;

namespace EstudoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa
            {
                Id = 1,
                Nome = "Iago"
            };
            Animal animal = new Animal
            {
                Id = 1,
                Nome = "Gato"
            };

            //Ao inves de criar um repositorio para cada Classe, contendo eles os mesmos metodos, fica mais facil criar um
            //repositorio genérico

            RepositorioGenerico<Pessoa> repositorioPessoa = new RepositorioGenerico<Pessoa>();
            RepositorioGenerico<Animal> repositorioAnimal = new RepositorioGenerico<Animal>();

            repositorioPessoa.Insert(pessoa);
            repositorioAnimal.Insert(animal);

            foreach(Pessoa p in repositorioPessoa.Get())
            {
                Console.WriteLine("Nome da pessoa: {0}", p.Nome);
            }
            
            foreach(Animal a in repositorioAnimal.Get())
            {
                Console.WriteLine("Nome do animal: {0}", a.Nome);
            }




            //PessoaRepositorio pessoaRepositorio = new PessoaRepositorio();
            //AnimalRepositorio animalRepositorio = new AnimalRepositorio();

            //pessoaRepositorio.Insert(pessoa);
            //animalRepositorio.Insert(animal);

            //foreach(Pessoa p in pessoaRepositorio.Get())
            //{
            //    Console.WriteLine("Nome da pessoa: {0}", p.Nome);
            //}

            //foreach(Animal a in animalRepositorio.Get())
            //{
            //    Console.WriteLine("Nome do animal: {0}", a.Nome);
            //}
        }
    }
}
