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

        private void mgLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLivro.Text = mgLivros.CurrentRow.Cells[0].Value.ToString();
        }

        private void mgAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAluno.Text = mgAlunos.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
