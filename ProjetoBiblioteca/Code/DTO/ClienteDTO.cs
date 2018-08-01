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

        public class Alunos
        {
            private int id;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            private string nome;

            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            private int serie;

            public int Serie
            {
                get { return serie; }
                set { serie = value; }
            }

            private string sala;

            public string Sala
            {
                get { return sala; }
                set { sala = value; }
            }

            private string observacoes;

            public string Observacoes
            {
                get { return observacoes; }
                set { observacoes = value; }
            }
        }

        public class AlunoGestao
        {
            private int id;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            private string nome;

            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }
        }

        public class LivroGestao
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
        }

        public class Gestao
        {
            private int retirada;

            public int Retirada
            {
                get { return retirada; }
                set { retirada = value; }
            }

            private string status;

            public string Status
            {
                get { return status; }
                set { status = value; }
            }
        }
    }
}

