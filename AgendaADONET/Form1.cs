using AgendaADONET.Classes;
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
            CarregarDataGridView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = (int)dgvAgenda.CurrentRow.Cells[0].Value;
            ContatoDAO contatoDAO = new ContatoDAO();
            contatoDAO.Excluir(id);
            CarregarDataGridView();
        }

        private void CarregarDataGridView()
        {
            ContatoDAO contato = new ContatoDAO();

            DataTable dataTable = contato.GetContatos();
            dgvAgenda.DataSource = dataTable;
            //DataSet dataSet = contato.GetContatos();
            //dgvAgenda.DataSource = dataSet.Tables["CONTATOS"];
            dgvAgenda.Refresh();
            CarregarStatusStrip();
                }

        private void CarregarStatusStrip()
        {
            ContatoDAO contato = new ContatoDAO();
            string quantidadeContatos = contato.ContarUsuarios();
            tssQuantidadeInfoUsuarios.Text = quantidadeContatos.ToString() + " usuário(s)";

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmIncluirAlterarContato form = new frmIncluirAlterarContato();
            form.ShowDialog();
            CarregarDataGridView();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato
            {
                Id = (int)dgvAgenda.CurrentRow.Cells[0].Value,
                Nome = dgvAgenda.CurrentRow.Cells[1].Value.ToString(),
                Email = dgvAgenda.CurrentRow.Cells[2].Value.ToString(),
                Telefone = (long)dgvAgenda.CurrentRow.Cells[3].Value
            };
            frmIncluirAlterarContato form = new frmIncluirAlterarContato(contato);
            form.ShowDialog();
            CarregarDataGridView();
        }
    }
}
