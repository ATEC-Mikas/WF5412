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
        private string id;
        private string nome;
        private List<Editora> editorasUsadas;
        //Construtores
        public Autor()
        {
            id = Guid.NewGuid().ToString();
            nome = string.Empty;
            editorasUsadas = new List<Editora>();

        }
        public Autor(string nome,List<Editora> listaEdit) : this()
        {
            if (!setNome(nome))
                this.nome = "erro";
            if (!setLista(listaEdit))
                this.editorasUsadas = new List<Editora>();
        }
        //Sets&Gets
        public string getNome()
        {
            return nome;
        }
        public bool setNome(string nome)
        {
            if(!string.IsNullOrEmpty(nome))
            {
                this.nome = nome;
                return true;
            }
            return false;
        }
        public List<Editora> getLista()
        {
            return editorasUsadas;
        }
        public bool setLista(List<Editora> list)
        {
            if(list.Count!=0)
            {
                editorasUsadas = new List<Editora>(list);
                return true;
            }
            return false;
        }
        //Metodos
        public string ImprimeDados()
        {
            string r;
            r = string.Format("Id: {0}" +
                            "\nNome: {1}\n",id,nome);
            foreach(Editora x in editorasUsadas)
                r += "Editora: "+x.ImprimeDados();

            return r;
        }
    }
}
