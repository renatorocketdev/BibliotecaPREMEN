using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoBiblioteca.Code.DAL;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;


namespace ProjetoBiblioteca.Code.BLL
{
    class LivrosBLL
    {
        //=================================Form Livro===================================
        //======================================Botões==================================
        //==================================Inserir===================================
        internal void InserirLivro(MaterialSkin.Controls.MaterialSingleLineTextField txtTitulo,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtAutor,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtLancamento,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtExemplares)
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection Conexao = new SQLiteConnection(NewConexao);
            if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO LIVROS (TITULO, AUTOR, CATEGORIA, LANCAMENTO, EXEMPLARES) VALUES (@TITULO, @AUTOR, @CATEGORIA, @LANCAMENTO, @EXEMPLARES); ", Conexao);
            cmd.Parameters.AddWithValue("TITULO", txtTitulo.Text.Trim());
            cmd.Parameters.AddWithValue("AUTOR", txtAutor.Text.Trim());
            cmd.Parameters.AddWithValue("CATEGORIA", txtCategoria.Text.Trim());
            cmd.Parameters.AddWithValue("LANCAMENTO", txtLancamento.Text.Trim());
            cmd.Parameters.AddWithValue("EXEMPLARES", txtExemplares.Text.Trim());

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro Adicionado com Sucesso");
            }
            catch (Exception ex)
            {   MessageBox.Show("Erro ao Salvar Livro: " + ex.Message);   }
        }

        //======================Deletar=====================
        internal void DeletarLivro(MetroFramework.Controls.MetroGrid mgLivros)
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection Conexao = new SQLiteConnection(NewConexao);
            if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM LIVROS WHERE ID = (@ID) ", Conexao);
            cmd.Parameters.AddWithValue("ID", Convert.ToInt32(mgLivros.CurrentRow.Cells[0].Value));

            try
            {   cmd.ExecuteNonQuery(); 
                MessageBox.Show("Livro Deletado Com Sucesso"); 
            }
            catch (Exception ex)
            {   MessageBox.Show("Erro Ao Deletar Livro: " + ex.Message);    }
        }

        //===========================================Salvar=========================
        private static int IDRegistro;

        internal void SalvarLivros(MaterialSkin.Controls.MaterialSingleLineTextField txtTitulo,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtAutor,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtLancamento,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtExemplares)
        {
            string Conexao = ClienteDAL.BancoDs;
            SQLiteConnection conn = new SQLiteConnection(Conexao);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (IDRegistro > 0)
            {
                SQLiteCommand cmd = new SQLiteCommand("UPDATE LIVROS SET TITULO = @TITULO, AUTOR = @AUTOR, CATEGORIA = @CATEGORIA, LANCAMENTO = @LANCAMENTO, EXEMPLARES = @EXEMPLARES WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("ID", IDRegistro);
                cmd.Parameters.AddWithValue("TITULO", txtTitulo.Text);
                cmd.Parameters.AddWithValue("AUTOR", txtAutor.Text);
                cmd.Parameters.AddWithValue("CATEGORIA", txtCategoria.Text);
                cmd.Parameters.AddWithValue("LANCAMENTO", txtLancamento.Text);
                cmd.Parameters.AddWithValue("EXEMPLARES", txtExemplares.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Livro Atualizado Com Sucesso");
                }
                catch (Exception ex)
                {   MessageBox.Show("Erro Ao Atualizar Livro " + ex.Message);   }
            }
        }
        //========================================Limpar Campos=========================
        internal void LimparCampos(MaterialSkin.Controls.MaterialSingleLineTextField txtTitulo,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtAutor,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtLancamento,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtExemplares)
        {
            txtTitulo.Text = String.Empty;
            txtAutor.Text = String.Empty;
            txtCategoria.Text = String.Empty;
            txtLancamento.Text = String.Empty;
            txtExemplares.Text = String.Empty;
        }

        //=============================Grid====================================
        internal void CarregarGrid(MetroFramework.Controls.MetroGrid mgLivros)
        {
            var dal = new ClienteDAL();
            dal.CarregarDados(mgLivros);
        }
        //=============================Grid e TextBox
        internal void ExibirGridTxt(MaterialSkin.Controls.MaterialSingleLineTextField txtTitulo,
                                    MaterialSkin.Controls.MaterialSingleLineTextField txtAutor,
                                    MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria,
                                    MaterialSkin.Controls.MaterialSingleLineTextField txtLancamento,
                                    MaterialSkin.Controls.MaterialSingleLineTextField txtExemplares,
                                    MetroFramework.Controls.MetroGrid mgLivros)
        {
            IDRegistro = 0;
            IDRegistro = Convert.ToInt32(mgLivros.CurrentRow.Cells[0].Value);
            txtTitulo.Text = mgLivros.CurrentRow.Cells[1].Value.ToString();
            txtAutor.Text = mgLivros.CurrentRow.Cells[2].Value.ToString();
            txtCategoria.Text = mgLivros.CurrentRow.Cells[3].Value.ToString();
            txtLancamento.Text = Convert.ToString(mgLivros.CurrentRow.Cells[4].Value);
            txtExemplares.Text = Convert.ToString(mgLivros.CurrentRow.Cells[5].Value);
        }
    }
}
