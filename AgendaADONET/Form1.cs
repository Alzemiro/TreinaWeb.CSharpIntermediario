using AgendaADONET.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaADONET
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            ContatoDAO contato = new ContatoDAO();

            DataTable dataTable = contato.GetContatos();
            dgvAgenda.DataSource = dataTable;
            //DataSet dataSet = contato.GetContatos();
            //dgvAgenda.DataSource = dataSet.Tables["CONTATOS"];
            dgvAgenda.Refresh();
        }
    }
}
