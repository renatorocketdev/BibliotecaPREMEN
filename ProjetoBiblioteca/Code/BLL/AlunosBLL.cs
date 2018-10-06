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
    class AlunosBLL
    {
        //================================Form Alunos======================================
        //================================Grid===========================================
        internal void CarregarDadosAlunos(MetroFramework.Controls.MetroGrid mgAlunos)
        {
            var dal = new ClienteDAL();
            dal.CarregarDadosAlunos(mgAlunos);
        }
        //======================================Botões====================================
        //=======================================Inserir==================================
        internal void InserirAluno(MaterialSkin.Controls.MaterialSingleLineTextField txtNome,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtSerie,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtSala)
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection Conexao = new SQLiteConnection(NewConexao);
            if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO ALUNOS (NOME, SERIE, SALA) VALUES (@NOME, @SERIE, @SALA); ", Conexao);
            cmd.Parameters.AddWithValue("NOME", txtNome.Text.Trim());
            cmd.Parameters.AddWithValue("SERIE", txtSerie.Text.Trim());
            cmd.Parameters.AddWithValue("SALA", txtSala.Text.Trim());

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
        //========================================Deletar=============================
        internal void DeletarAluno(MetroFramework.Controls.MetroGrid mgAlunos)
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection Conexao = new SQLiteConnection(NewConexao);
            if (Conexao.State == ConnectionState.Closed)
                Conexao.Open();

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM ALUNOS WHERE ID = (@ID) ", Conexao);
            cmd.Parameters.AddWithValue("ID", Convert.ToInt32(mgAlunos.CurrentRow.Cells[0].Value));

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno Deletado Com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Ao Deletar Livro: " + ex.Message);
            }
        }

        private static int IDRegistro;

        //==============================Exibir o Grid================================
        internal void ExibirGridTxt(MaterialSkin.Controls.MaterialSingleLineTextField txtNome,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtSerie,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtSala,
                                   MetroFramework.Controls.MetroGrid mgAlunos)
        {
            IDRegistro = 0;
            IDRegistro = Convert.ToInt32(mgAlunos.CurrentRow.Cells[0].Value);
            txtNome.Text = mgAlunos.CurrentRow.Cells[1].Value.ToString();
            txtSerie.Text = mgAlunos.CurrentRow.Cells[2].Value.ToString();
            txtSala.Text = mgAlunos.CurrentRow.Cells[2].Value.ToString();
        }

        //================================Salvar======================================
        internal void Salvar(MaterialSkin.Controls.MaterialSingleLineTextField txtNome,
                             MaterialSkin.Controls.MaterialSingleLineTextField txtSerie,
                             MaterialSkin.Controls.MaterialSingleLineTextField txtSala)
        {
            string NewConexao = ClienteDAL.BancoDs;
            SQLiteConnection conn = new SQLiteConnection(NewConexao);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (IDRegistro > 0)
            {
                SQLiteCommand cmd = new SQLiteCommand("UPDATE ALUNOS SET NOME = @NOME, SERIE = @SERIE, SALA = @SALA WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("ID", IDRegistro);
                cmd.Parameters.AddWithValue("NOME", txtNome.Text);
                cmd.Parameters.AddWithValue("SERIE", txtSerie.Text);
                cmd.Parameters.AddWithValue("SALA", txtSala.Text);

                try
                { 
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("Salvo com Sucesso"); 
                }
                catch (Exception ex )
                { MessageBox.Show("Falha ao Salvar Aluno" + ex.Message); }
            }
        }

        //============================Limpar Campos===================================
        internal void LimparCampos(MaterialSkin.Controls.MaterialSingleLineTextField txtNome,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtSerie,
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtSala)
        {
            txtNome.Text = String.Empty;
            txtSerie.Text = String.Empty;
            txtSala.Text = String.Empty;
        }
    }
}
