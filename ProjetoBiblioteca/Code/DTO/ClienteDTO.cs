using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Code.DTO
{
    class ClienteDTO
    {
        public class Livros
        {
            private int id;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            private string titulo;

            public string Titulo
            {
                get { return titulo; }
                set { titulo = value; }
            }

            private string autor;

            public string Autor
            {
                get { return autor; }
                set { autor = value; }
            }

            private string categoria;

            public string Categoria
            {
                get { return categoria; }
                set { categoria = value; }
            }

            private int lancamento;

            public int Lancamento
            {
                get { return lancamento; }
                set { lancamento = value; }
            }

            private int exemplares;

            public int Exemplares
            {
                get { return exemplares; }
                set { exemplares = value; }
            }
        }
    }


}

