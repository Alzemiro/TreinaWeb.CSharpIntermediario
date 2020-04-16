using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EstudoXML
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            
        }

        private string CarregarTitulo()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"D:\Iago\TreinaWeb\TreinaWeb.CSharpIntermediario\TreinaWeb.CSharpIntermediario\EstudoXML\Agenda.xml");
            
            XmlNode noTitulo = documentoXml.SelectSingleNode("/agenda/titulo");
            return noTitulo.InnerText;
        }

        private void CarregarContatos()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"D:\Iago\TreinaWeb\TreinaWeb.CSharpIntermediario\TreinaWeb.CSharpIntermediario\EstudoXML\Agenda.xml");          
          
            XmlNodeList contatosLista = documentoXml.SelectNodes("//contato");         
            
            foreach(XmlNode contato in contatosLista)
            {
                string representacaoContato = string.Empty;
                string id = contato.Attributes["id"].Value;
                string nome = contato.Attributes["nome"].Value;
                string idade = contato.Attributes["idade"].Value;
                representacaoContato = string.Format("{0} - {1} - {2} anos", id, nome, idade);
                lbxContatos.Items.Add(representacaoContato);
            }          
             
        }

        private void frmAgenda_Shown(object sender, EventArgs e)
        {
           
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = CarregarTitulo();
            CarregarContatos();
            CriarContato();
        }

        private void CriarContato()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"D:\Iago\TreinaWeb\TreinaWeb.CSharpIntermediario\TreinaWeb.CSharpIntermediario\EstudoXML\Agenda.xml");

            //Cria atributos
            XmlAttribute atributoId = documentoXml.CreateAttribute("id");
            atributoId.Value = "4";

            XmlAttribute atributoNome = documentoXml.CreateAttribute("nome");
            atributoNome.Value = "Iago";

            XmlAttribute atributoIdade = documentoXml.CreateAttribute("idade");
            atributoIdade.Value = "24";
            //Fim cria atributos

            //Cria o elemento e adiciona os atributos
            XmlNode novoContato = documentoXml.CreateElement("contato");
            novoContato.Attributes.Append(atributoId);
            novoContato.Attributes.Append(atributoNome);
            novoContato.Attributes.Append(atributoIdade);
            //Fim cria elemento

            //Seleciona o elemento pai e adciona o elemento filho
            XmlNode contatos = documentoXml.SelectSingleNode("//contatos");
            contatos.AppendChild(novoContato);
            //Fim seleção e add

            //Sobre escreve o documento principal
            documentoXml.Save(@"D:\Iago\TreinaWeb\TreinaWeb.CSharpIntermediario\TreinaWeb.CSharpIntermediario\EstudoXML\Agenda.xml");
            //Fim
        }
    }
}
