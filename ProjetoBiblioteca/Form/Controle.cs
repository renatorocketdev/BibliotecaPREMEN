using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class Controle : MetroFramework.Forms.MetroForm
    {
        public Controle()
        {
            InitializeComponent();
        }

        //Quando Form Controle Abrir, o Form Login Fecha
        private void Controle_Load(object sender, EventArgs e)
        {
            Login.ActiveForm.Hide();
        }

        //============================Sair e Voltar========================
        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            var NewLogin = new Login();
            NewLogin.Show();
            this.Hide();
        }
        //===============================Livros e Alunos===========================


    }
}
