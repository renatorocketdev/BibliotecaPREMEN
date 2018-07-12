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

        private void Livros_Load(object sender, EventArgs e)
        {
            var bll = new ClienteBLL();
            bll.CarregarGrid(mgLivros);
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            var bll = new ClienteBLL();
            bll.InserirLivro(txtTitulo, txtAutor, txtCategoria);
            bll.CarregarGrid(mgLivros);
        }
        private void CarregarDGV()
        {
            var bll = new ClienteBLL();
            bll.CarregarGrid(mgLivros);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var bll = new ClienteBLL();
            bll.CarregarGrid(mgLivros);
            MessageBox.Show("Atuazado Com Suecesso");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var bll = new ClienteBLL();
            bll.DeletarLivro(mgLivros);
            bll.CarregarGrid(mgLivros);
        }
    }
}
