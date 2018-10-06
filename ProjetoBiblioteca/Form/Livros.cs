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
    public partial class Livros : MetroFramework.Forms.MetroForm
    {
        public Livros()
        {
            InitializeComponent();
        }
        //=====================Carregamento=================
        private void Livros_Load(object sender, EventArgs e)
        {
            var bll = new LivrosBLL();
            bll.CarregarGrid(mgLivros);
        }

        private void CarregarDGV()
        {
            var bll = new LivrosBLL();
            bll.CarregarGrid(mgLivros);
        }

        //==============================Botões====================================
        private void btnNovo_Click(object sender, EventArgs e)
        {
            var bll = new LivrosBLL();
            bll.InserirLivro(txtTitulo, txtAutor, txtCategoria, txtLancamento, txtExemplares);
            bll.CarregarGrid(mgLivros);
            bll.LimparCampos(txtTitulo, txtAutor, txtCategoria, txtLancamento, txtExemplares);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var bll = new LivrosBLL();
            bll.CarregarGrid(mgLivros);
            bll.LimparCampos(txtTitulo, txtAutor, txtCategoria, txtLancamento, txtExemplares);
            MessageBox.Show("Atualizado Com Sucesso");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var bll = new LivrosBLL();
            bll.DeletarLivro(mgLivros);
            bll.CarregarGrid(mgLivros);
            bll.LimparCampos(txtTitulo, txtAutor, txtCategoria, txtLancamento, txtExemplares);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var bll = new LivrosBLL();
            bll.SalvarLivros(txtTitulo, txtAutor, txtCategoria, txtLancamento, txtExemplares);
            bll.CarregarGrid(mgLivros);
            bll.LimparCampos(txtTitulo, txtAutor, txtCategoria, txtLancamento, txtExemplares);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var bll = new LivrosBLL();
            bll.LimparCampos(txtTitulo, txtAutor, txtCategoria, txtLancamento, txtExemplares);
        }

        //====================================Grid===================================
        private void mgLivros_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var bll = new LivrosBLL();
            bll.ExibirGridTxt(txtTitulo, txtAutor, txtCategoria, txtLancamento, txtExemplares, mgLivros);
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
