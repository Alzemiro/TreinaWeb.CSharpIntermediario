using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoGenerics
{
    public class AnimalRepositorio
    {
        private List<Animal> animais;

        public AnimalRepositorio()
        {
            animais = new List<Animal>();
        }
        public List<Animal> Get()
        {
            return animais;
        }

        public void Insert(Animal animal)
        {
            animais.Add(animal);
        }
        
    }
}
