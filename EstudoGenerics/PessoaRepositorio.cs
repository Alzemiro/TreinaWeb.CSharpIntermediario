using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoGenerics
{
    public class PessoaRepositorio
    {
        private List<Pessoa> pessoas;

        public PessoaRepositorio()
        {
            pessoas = new List<Pessoa>();
        }
        
        public List<Pessoa> Get()
        {
            return pessoas;
        }

        public void Insert(Pessoa pessoa)
        {            
            pessoas.Add(pessoa);
        }
       
    }
}
