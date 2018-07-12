using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjetoBiblioteca.Code.DAL;
using System.Data.SQLite;
using System.Data;

namespace ProjetoBiblioteca.Code.BLL
{
    class ClienteBLL
    {
        //==================================Form Login===================================
        internal void Logar(MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario, MaterialSkin.Controls.MaterialSingleLineTextField txtSenha)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
            {
                Controle NewControle = new Controle();
                NewControle.Show();
            }
            else if (txtUsuario.Text != "admin" && txtSenha.Text != "admin")
            {
                MessageBox.Show("Senha ou Usuario Incorreto");
            }
        }

        internal void CarregarCriarDB()
        {
            var Criar = new ClienteDAL();
            Criar.CarregarCriarDb();
        }
        //=================================Form Livro===================================
        internal void InserirLivro(MaterialSkin.Controls.MaterialSingleLineTextField txtTitulo,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtAutor,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria)
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection Conexao = new SQLiteConnection(NewConexao);
            if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO LIVROS (TITULO, AUTOR, CATEGORIA) VALUES (@TITULO, @AUTOR, @CATEGORIA); ", Conexao);
            cmd.Parameters.AddWithValue("TITULO", txtTitulo.Text.Trim());
            cmd.Parameters.AddWithValue("AUTOR", txtAutor.Text.Trim());
            cmd.Parameters.AddWithValue("CATEGORIA", txtCategoria.Text.Trim());

            try
            {
                cmd.ExecuteNonQuery();
                txtTitulo.Text = String.Empty;
                MessageBox.Show("Livro Adicionado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar Livro: " + ex.Message);
            }
        }
        internal void DeletarLivro(MetroFramework.Controls.MetroGrid mgLivros)
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection Conexao = new SQLiteConnection(NewConexao);
            if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM LIVROS WHERE ID = (@ID) ", Conexao);
            cmd.Parameters.AddWithValue("ID", Convert.ToInt32(mgLivros.CurrentRow.Cells[0].Value));

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro Deletado Com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Ao Deletar Livro: " + ex.Message);
            }
        }

        internal void CarregarGrid(MetroFramework.Controls.MetroGrid mgLivros)
        {
            var dal = new ClienteDAL();
            dal.CarregarDados(mgLivros);
            
        }
    }
}
