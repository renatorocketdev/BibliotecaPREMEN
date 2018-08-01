using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using ProjetoBiblioteca.Code.DTO;

namespace ProjetoBiblioteca.Code.DAL
{
    class ClienteDAL
    {
        public static string BancoDs = "Data Source = BibliotecaDB";
        public static string BibliotecaDB = "BibliotecaDB.db";

        public void CarregarCriarDb()
        {
            if (!File.Exists(BibliotecaDB))
            {
                SQLiteConnection.CreateFile(BibliotecaDB);
                SQLiteConnection Conexao = new SQLiteConnection(BancoDs);
                Conexao.Open();

                StringBuilder sql = new StringBuilder();
                //=====================Tabela Livros====================
                sql.AppendLine("CREATE TABLE IF NOT EXISTS LIVROS ([ID] INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("[TITULO] VARCHAR(50), [AUTOR] VARCHAR(50), [CATEGORIA] VARCHAR(20), ");
                sql.AppendLine("[LANCAMENTO] INTEGER, [EXEMPLARES] INTEGER); ");
                //======================Tabela Alunos====================
                sql.AppendLine("CREATE TABLE IF NOT EXISTS ALUNOS ([ID] INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("[NOME] VARCHAR(50), [SERIE] INTEGER, [SALA] VARCHAR(1), [OBSERVACOES] VARCHAR(100)); ");
                //======================Tabela Gestao===================
                sql.AppendLine("CREATE TABLE IF NOT EXISTS GESTAO ([ID] INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("[LIVRO] VARCHAR(50), [ALUNO] VARCHAR(50), [RETIRADA] INTEGER, [STATUS] );");

                SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), Conexao);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro Ao Criar DB: " + ex.Message);
                }
            }
        }

        //===================================Livros================================
        public void CarregarDados(MetroFramework.Controls.MetroGrid mgLivros)
        {
            SQLiteConnection Conexao = new SQLiteConnection(BancoDs);
            if (Conexao.State == ConnectionState.Closed)
            Conexao.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM LIVROS", Conexao);
            SQLiteDataReader Dr = cmd.ExecuteReader();
            List<ClienteDTO.Livros> Lista = new List<ClienteDTO.Livros>();

            while (Dr.Read())
            {
                Lista.Add(new ClienteDTO.Livros
                { Id = Convert.ToInt32(Dr["ID"]), 
                  Titulo = Dr["TITULO"].ToString(), 
                  Autor = Dr["AUTOR"].ToString(),
                  Categoria = Dr["CATEGORIA"].ToString(),
                  Lancamento = Convert.ToInt32(Dr["LANCAMENTO"]),
                  Exemplares = Convert.ToInt32(Dr["EXEMPLARES"])
                });
            }
            mgLivros.DataSource = Lista;
        }

        //=====================================Alunos===========================
        public void CarregarDadosAlunos(MetroFramework.Controls.MetroGrid mgAlunos)
        {
            SQLiteConnection Conexao = new SQLiteConnection(BancoDs);
            if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM ALUNOS", Conexao);
            SQLiteDataReader Dr = cmd.ExecuteReader();
            List<ClienteDTO.Alunos> Lista = new List<ClienteDTO.Alunos>();

            while (Dr.Read())
            {
                Lista.Add(new ClienteDTO.Alunos
                {   Id = Convert.ToInt32(Dr["ID"]),
                    Nome = Dr["NOME"].ToString(),
                    Serie = Convert.ToInt32(Dr["SERIE"]),
                    Sala = Dr["SALA"].ToString()
                }); 
            }
            mgAlunos.DataSource = Lista;
        }
        //============================================Gestão==============================
        public void CarregarDadosAlunosGestao(MetroFramework.Controls.MetroGrid mgAlunos)
        {
            SQLiteConnection Conexao = new SQLiteConnection(BancoDs);
            if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT ID, NOME FROM ALUNOS", Conexao);
            SQLiteDataReader Dr = cmd.ExecuteReader();
            List<ClienteDTO.AlunoGestao> Lista = new List<ClienteDTO.AlunoGestao>();

            while (Dr.Read())
            {
                Lista.Add(new ClienteDTO.AlunoGestao
                {
                    Id = Convert.ToInt32(Dr["ID"]),
                    Nome = Dr["NOME"].ToString()
                });
            }
            mgAlunos.DataSource = Lista;
        }

        public void CarregarDadosLivrosGestao(MetroFramework.Controls.MetroGrid mgLivros)
        {
            SQLiteConnection Conexao = new SQLiteConnection(BancoDs);
            if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT ID, TITULO FROM LIVROS", Conexao);
            SQLiteDataReader Dr = cmd.ExecuteReader();
            List<ClienteDTO.LivroGestao> Lista = new List<ClienteDTO.LivroGestao>();

            while (Dr.Read())
            {
                Lista.Add(new ClienteDTO.LivroGestao
                {
                    Id = Convert.ToInt32(Dr["ID"]),
                    Titulo = Dr["TITULO"].ToString()
                });
            }
            mgLivros.DataSource = Lista;
        }

    }
}
