using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using ProjetoBiblioteca.Code.BLL;

namespace ProjetoBiblioteca
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red400, /*Login, e Btn*/ Primary.Red400, /*Border*/ 
                Primary.Blue400, Accent.Red400, /*Cor do CheckBox*/
                TextShade.WHITE);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Logar = new ClienteBLL();
            Logar.Logar(txtUsuario, txtSenha);
            this.Hide();
        }

    }
}
