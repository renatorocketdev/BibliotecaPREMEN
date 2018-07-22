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
    public partial class Alunos : MetroFramework.Forms.MetroForm
    {
        public Alunos()
        {
            InitializeComponent();
        }

        private void Alunos_Load(object sender, EventArgs e)
        {
            var bll = new AlunosBLL();
            bll.CarregarDadosAlunos(mgAlunos);
        }
        //=================================Botões==============================
        private void btnNovo_Click(object sender, EventArgs e)
        {
            var bll = new AlunosBLL();
            bll.InserirAluno(txtNome, txtSerie, txtSala);
            bll.CarregarDadosAlunos(mgAlunos);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var bll = new AlunosBLL();
            bll.DeletarAluno(mgAlunos);
            bll.CarregarDadosAlunos(mgAlunos);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var bll = new AlunosBLL();
            bll.Salvar(txtNome, txtSerie, txtSala);
            bll.CarregarDadosAlunos(mgAlunos);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var bll = new AlunosBLL();
            bll.LimparCampos(txtNome, txtSerie, txtSala);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var bll = new AlunosBLL();
            bll.CarregarDadosAlunos(mgAlunos);
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

        private void mgAlunos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var bll = new AlunosBLL();
            bll.ExibirGridTxt(txtNome, txtSerie, txtSala, mgAlunos);
        }

    }
}
