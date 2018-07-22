using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoBiblioteca.Code.DAL;
using System.Data.SQLite;
using System.Data;

namespace ProjetoBiblioteca.Code.BLL
{
    class ConsultaBLL
    {
        internal void CarregarGridLivros(MetroFramework.Controls.MetroGrid mgLivros)
        {
            var Carregar = new ClienteDAL();
            Carregar.CarregarDados(mgLivros);
        }

        internal void CarregarGridAlunos(MetroFramework.Controls.MetroGrid mgAlunos)
        {
            var Carregar = new ClienteDAL();
            Carregar.CarregarDadosAlunos(mgAlunos);
        }

        public DataTable PesquisarDadosLivros(MetroFramework.Controls.MetroTextBox txtPesquisa)
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection Conexao = new SQLiteConnection(NewConexao);

            string sql = "SELECT ID, TITULO, AUTOR, CATEGORIA, LANCAMENTO, EXEMPLARES FROM LIVROS WHERE TITULO LIKE '" + txtPesquisa.Text + "%'";
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

        public DataTable PesquisarDadosAlunos(MetroFramework.Controls.MetroTextBox txtPesquisa2)
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection Conexao = new SQLiteConnection(NewConexao);

            string sql = "SELECT ID, NOME, SERIE, SALA FROM ALUNOS WHERE NOME LIKE '" + txtPesquisa2.Text + "%'";
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
    }
}
