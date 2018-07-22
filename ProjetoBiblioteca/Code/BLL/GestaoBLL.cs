using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoBiblioteca.Code.DAL;

namespace ProjetoBiblioteca.Code.BLL
{
    class GestaoBLL
    {
        //=======================================Gestão==============================
        internal void CarregarDadosAlunosGestao(MetroFramework.Controls.MetroGrid mgAlunos)
        {
            var dal = new ClienteDAL();
            dal.CarregarDadosAlunosGestao(mgAlunos);
        }

        internal void CarregarDadosLivrosGestao(MetroFramework.Controls.MetroGrid mgLivros)
        {
            var dal = new ClienteDAL();
            dal.CarregarDadosLivrosGestao(mgLivros);
        }
    }
}
