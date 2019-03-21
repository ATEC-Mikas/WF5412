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
        private string id;
        private string descricao;
        //Construtores
        public GeneroLivro()
        {
            id = Guid.NewGuid().ToString();
            descricao = String.Empty;
        }
        public GeneroLivro(string desc) :  this()
        {
            if (!setDesc(desc))
                desc = "erro";
        }
        //Sets & gets
        public string getID()
        {
            return id;
        }
        public string getDesc()
        {
            return descricao;
        }
        public bool setDesc(string d)
        {
            if(!string.IsNullOrEmpty(d))
            {
                descricao = d;
                return true;
            }
            return false;
        }
        //Métodos
        public string ImprimeDados()
        {
            return string.Format("Id: {0} | Descricao: {1}", id, descricao);
        }
    }
}
