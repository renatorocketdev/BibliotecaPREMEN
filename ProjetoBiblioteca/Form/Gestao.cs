using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjetoBiblioteca.Code.BLL;

namespace ProjetoBiblioteca
{
    public partial class Gestao : MetroFramework.Forms.MetroForm
    {
        public Gestao()
        {
            InitializeComponent();
        }

        private void Gestao_Load(object sender, EventArgs e)
        {
            var bll = new GestaoBLL();
            bll.CarregarDadosAlunosGestao(mgAlunos);
            var bll1 = new GestaoBLL();
            bll1.CarregarDadosLivrosGestao(mgLivros);
        }

        public void mgLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLivro.Text = mgLivros.CurrentRow.Cells[1].Value.ToString();
        }

        public void mgAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAluno.Text = mgAlunos.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtBuscaAluno_TextChanged(object sender, EventArgs e)
        {
            var ConsultaAluno = new GestaoBLL();
            ConsultaAluno.PesquisarDadosAlunos(txtBuscaAluno);

            mgAlunos.DataSource = ConsultaAluno.PesquisarDadosAlunos(txtBuscaAluno);
        }

        private void txtBuscaLivro_TextChanged(object sender, EventArgs e)
        {
            var ConsultaLivro = new GestaoBLL();
            ConsultaLivro.PesquisarDadosLivros(txtBuscaLivro);

            mgLivros.DataSource = ConsultaLivro.PesquisarDadosLivros(txtBuscaLivro);
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            var NewControle = new Controle();
            NewControle.Show();
            this.Hide();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
