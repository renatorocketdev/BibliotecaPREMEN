using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoBiblioteca.Code.BLL
{
    class ClienteBLL
    {
        internal void Logar(MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario, MaterialSkin.Controls.MaterialSingleLineTextField txtSenha)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
            {
                Controle NewControle = new Controle();
                NewControle.Show();
            }
        }
    }
}
