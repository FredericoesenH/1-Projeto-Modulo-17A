using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1º_Projeto_Modulo_17A.Livros
{
    /// <summary>
    /// Responsável por manipular os livros na base de dados (CRUD)
    /// </summary>
    internal class c_livros : icrud
    {
        public int id;
        string isbn;
        public string titulo;
        public string autor;
        public string tipo;
        public DateTime data_entrada;
        public string estado;
        public bool disponvel;

        public override string ToString()
        {
            return id + $" - {titulo}";
        }
        public string validar()
        {
            string erros = "";

            return erros;
        }
        public void apagar()
        {
        }

        public void atualizar()
        {
        }

        public void listar()
        {
        }
        public void adicionar()
        {
            string sql = "INSERT INTO....";
        }
    }
}
