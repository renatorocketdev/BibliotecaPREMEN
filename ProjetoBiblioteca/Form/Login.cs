using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoBiblioteca.Properties;

using MetroFramework;
using MaterialSkin;
using ProjetoBiblioteca.Code.BLL;

namespace ProjetoBiblioteca
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var Criar = new LoginBLL();
            Criar.CarregarCriarDB();
            //========================Função Lembrar-me========================
            if (Settings.Default.Password == "admin" && Settings.Default.Username == "admin")
            {
                txtSenha.Text = Settings.Default.Password;
                txtUsuario.Text = Settings.Default.Username;
                CBLembrar.Checked = true;
            }
            if (CBLembrar.Checked == false)
            {
                Settings.Default.Password = "";
                Settings.Default.Username = "";
                Settings.Default.Save();
            }
        }
        //======================Função Login=======================
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
            {
                if (CBLembrar.Checked == true)
                {
                    Settings.Default.Password = txtSenha.Text;
                    Settings.Default.Username = txtUsuario.Text;
                    Settings.Default.Save();

                    ProjetoBiblioteca.Login.ActiveForm.Hide();
                    (new Controle()).Show();
                }
                if (CBLembrar.Checked == false)
                {
                    Settings.Default.Password = "";
                    Settings.Default.Username = "";
                    Settings.Default.Save();
                }

                ProjetoBiblioteca.Login.ActiveForm.Hide();
                (new Controle()).Show();
            }
            else if (txtUsuario.Text != "admin" && txtSenha.Text != "admin")
            {
                MessageBox.Show("Senha ou Usuario Incorreto");
            }
        }
    }
}
