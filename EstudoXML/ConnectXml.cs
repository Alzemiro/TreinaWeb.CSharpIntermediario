using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EstudoXML
{
    public class ConnectXml
    {   
        
        public ConnectXml()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"D:\Iago\TreinaWeb\TreinaWeb.CSharpIntermediario\TreinaWeb.CSharpIntermediario\EstudoXML\Agenda.xml");
        }
    }
}
