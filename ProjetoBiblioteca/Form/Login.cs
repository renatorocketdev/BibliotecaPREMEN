using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Logar = new LoginBLL();
            Logar.Logar(txtUsuario, txtSenha);
        }
    }
}
