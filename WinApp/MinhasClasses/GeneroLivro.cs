using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasClasses
{
    public class GeneroLivro
    {
        //Atributos
        private string _id;
        private string _descricao;
        //Construtores
        public GeneroLivro()
        {
            _id = Guid.NewGuid().ToString();
            _descricao = String.Empty;
        }
        public GeneroLivro(string desc) :  this()
        {
            Descricao = desc;
        }

        public string Id
        {
            get { return _id; }
        }
        public string Descricao
        {
            get { return _descricao; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _descricao = value;
            }
        }
        //Métodos
        public string ImprimeDados()
        {
            return string.Format("Id: {0} | Descricao: {1}", Id, Descricao);
        }
    }
}
