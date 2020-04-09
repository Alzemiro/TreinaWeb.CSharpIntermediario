using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoGenerics
{
    public class RepositorioGenerico<T>
    {
        private List<T> itens;

        public RepositorioGenerico()
        {
            itens = new List<T>();
        }

        public List<T> Get()
        {
            return itens;
        }

        public void Insert(T objeto)
        {
            itens.Add(objeto);
        }
    }
}
