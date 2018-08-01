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
    public partial class Consulta : MetroFramework.Forms.MetroForm
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            var Carregar = new ConsultaBLL();
            Carregar.CarregarGridAlunos(mgAlunos);
            Carregar.CarregarGridLivros(mgLivros);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            var Pesquisa = new ConsultaBLL();
            Pesquisa.PesquisarDadosLivros(txtPesquisa);

            mgLivros.DataSource = Pesquisa.PesquisarDadosLivros(txtPesquisa);
        }

        private void txtPesquisa2_TextChanged(object sender, EventArgs e)
        {
            var Pesquisa = new ConsultaBLL();
            Pesquisa.PesquisarDadosAlunos(txtPesquisa2);

            mgAlunos.DataSource = Pesquisa.PesquisarDadosAlunos(txtPesquisa2);
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
