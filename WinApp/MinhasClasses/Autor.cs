using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasClasses
{
    public class Autor
    {
        //Atributos
        private string _id;
        private string _nome;
        private List<Editora> _editorasUsadas;
        //Construtores
        public Autor()
        {
            _id = Guid.NewGuid().ToString();
            _nome = string.Empty;
            _editorasUsadas = new List<Editora>();

        }
        public Autor(string nome,List<Editora> listaEdit) : this()
        {
            Nome = nome;
            EditorasUsadas = new List<Editora>(listaEdit);
        }

        public string Id
        {
            get { return _id; }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _nome = value;
            }
        }
        public List<Editora> EditorasUsadas
        {
            get { return _editorasUsadas; }
            set { if (value.Count != 0) _editorasUsadas = new List<Editora>(value); }
        }
        //Sets&Gets
        //Metodos
        public string ImprimeDados()
        {
            string r;
            r = string.Format("Id: {0}" +
                            "\nNome: {1}\n",Id,Nome);
            foreach(Editora x in EditorasUsadas)
                r += "Editora: "+x.ImprimeDados();

            return r;
        }
    }
}
