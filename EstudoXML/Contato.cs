using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoXML
{
    public class Contato
    {
        public string Id;
        public string Nome;
        public string Idade;

        public Contato()
        {
            Id = string.Empty;
            Nome = string.Empty;
            Idade = string.Empty;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Id, Nome, Idade);
        }
    }
}
