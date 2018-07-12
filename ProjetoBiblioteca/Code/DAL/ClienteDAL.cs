using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;

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
                sql.AppendLine("CREATE TABLE IF NOT EXISTS LIVROS ([ID] INTEGER PRIMARY KEY AUTOINCREMENT, [TITULO] VARCHAR(50));");
                //sql.AppendLine("[TITULO] VARCHAR(50))");
                sql.AppendLine("CREATE TABLE IF NOT EXISTS ALUNOS ([ID] INTEGER PRIMARY KEY AUTOINCREMENT, [NOME] VARCHAR(50))");
                //sql.AppendLine("[NOME] VARCHAR(50))");

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
    }
}
