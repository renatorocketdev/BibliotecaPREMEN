using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Code.DTO
{
    class ClienteDTO
    {
        class Livros
        {
            int id;
            public int Id { get { return id; } set { id = value; } }

            string titulo;
            public string Titulo {get { return titulo; } set { titulo = value; } }

            string autor;
            public string Autor {get { return autor; } set { autor = value; } }

            string categoria;
            public string Categoria { get { return categoria; } set { categoria = value; } }

            int exemplares;
            public int Exemplares { get { return exemplares; } set { exemplares = value;  } }
        }
        class Alunos
        {
            int id;
            public int Id { get { return id; } set { id = value;  } }

            string nome;
            public string Nome { get { return nome; } set { nome = value;  } }

            string serie;
            public string Serie { get { return serie; } set { serie = value; } }

            int ano;
            public int Ano { get { return ano; } set { ano = value;  } }
        }
    }
}
