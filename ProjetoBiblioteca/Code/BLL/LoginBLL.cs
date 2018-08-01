using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBiblioteca.Properties;

using ProjetoBiblioteca.Code.DAL;
using System.Windows.Forms;

namespace ProjetoBiblioteca.Code.BLL
{
    class LoginBLL
    {
        //internal void Logar(MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario, MaterialSkin.Controls.MaterialSingleLineTextField txtSenha, MaterialSkin.Controls.MaterialCheckBox CBLembrar)
        //{

        //}

        internal void CarregarCriarDB()
        {
            var Criar = new ClienteDAL();
            Criar.CarregarCriarDb();
        }
    }
}
