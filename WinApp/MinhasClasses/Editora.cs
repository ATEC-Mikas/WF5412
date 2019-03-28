using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasClasses
{
    public class Editora
    {
        //Atributos
        private string _id;
        private string _nome;
        //Construtores
        public Editora()
        {
            _id = Guid.NewGuid().ToString();
            _nome = string.Empty;
        }
        public Editora(string n) : this()
        {
            Nome = n;
        }
        public Editora(Editora x) 
        {
            _id = x.Id;
            _nome = x.Nome;
        }
        //Get & Sets
        public string Id
        {
            get
            {
                return _id;
            }
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _nome = value;
            }
        }
        //Metodo
        public string ImprimeDados()
        {
            return string.Format("id: {0} | Nome: {1}\n",Id,Nome);
        }
    }
}
