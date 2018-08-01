using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoBiblioteca.Code.DAL;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjetoBiblioteca.Code.BLL
{
    class GestaoBLL
    {
        //=======================================Gestão==============================
        internal void CarregarDadosAlunosGestao(MetroFramework.Controls.MetroGrid mgAlunos)
        {
            var dal = new ClienteDAL();
            dal.CarregarDadosAlunosGestao(mgAlunos);
        }

        internal void CarregarDadosLivrosGestao(MetroFramework.Controls.MetroGrid mgLivros)
        {
            var dal = new ClienteDAL();
            dal.CarregarDadosLivrosGestao(mgLivros);
        }

        public DataTable PesquisarDadosAlunos(MaterialSkin.Controls.MaterialSingleLineTextField txtBuscaAluno)
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection Conexao = new SQLiteConnection(NewConexao);

            string sql = "SELECT ID, NOME FROM ALUNOS WHERE ID LIKE '" + txtBuscaAluno.Text + "%'";
            using (SQLiteConnection connection = new SQLiteConnection(Conexao))
            {
                Conexao.Open();
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Conexao))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                    catch (SQLiteException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        Conexao.Close();
                    }
                }
            }
        }

        public DataTable PesquisarDadosLivros(MaterialSkin.Controls.MaterialSingleLineTextField txtBuscaLivro)
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection Conexao = new SQLiteConnection(NewConexao);

            string sql = "SELECT ID, TITULO FROM LIVROS WHERE ID LIKE '" + txtBuscaLivro.Text + "%'";
            using (SQLiteConnection connection = new SQLiteConnection(Conexao))
            {
                Conexao.Open();
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Conexao))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                    catch (SQLiteException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        Conexao.Close();
                    }
                }
            }
        }

        internal void InserirAluno(MaterialSkin.Controls.MaterialSingleLineTextField txtLivro,
                           MaterialSkin.Controls.MaterialSingleLineTextField txtAluno,
                           MaterialSkin.Controls.MaterialSingleLineTextField txtRetirada
                           )
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection Conexao = new SQLiteConnection(NewConexao);
            if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO GESTAO (LIVRO, ALUNO, RETIRADA) VALUES (@LIVRO, @ALUNO, @RETIRADA); ", Conexao);
            cmd.Parameters.AddWithValue("LIVRO", txtLivro.Text.Trim());
            cmd.Parameters.AddWithValue("ALUNO", txtAluno.Text.Trim());
            cmd.Parameters.AddWithValue("RETIRADA", txtRetirada.Text.Trim());

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno Adicionado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar Livro: " + ex.Message);
            }
        }
    }
}
