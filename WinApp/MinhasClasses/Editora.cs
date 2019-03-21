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
        private string id;
        private string nome;
        //Construtores
        public Editora()
        {
            id = Guid.NewGuid().ToString();
            nome = string.Empty;
        }
        public Editora(string n) : this()
        {
            if(!setNome(n))
                nome="erro";
        }
        //Get & Sets
        public string getID()
        {
            return id;
        }
        public string getNome()
        {
            return nome;
        }
        public bool setNome(string n)
        {
            if(!String.IsNullOrEmpty(n))
            {
                nome = n;
                return true;
            }
            return false;
        }
        //Metodo
        public string ImprimeDados()
        {
            return string.Format("id: {0} | Nome: {1}\n",id,nome);
        }
    }
}
