using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public class Conta
    {
        private string _user;
        private string _nome;
        
        public Conta(string user,string nome)
        {
            User = user;
            Nome = nome;
        }

        public string User
        {
            get { return _user; }
            set { if (validarString(value)) _user = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { if (validarString(value)) _nome = value; }
        }

        private bool validarString(string s)
        {
            return !String.IsNullOrEmpty(s) && !String.IsNullOrWhiteSpace(s) && s.Count()<100;
        }
    }
}
