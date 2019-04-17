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
        private string _password;
        private bool _nomeChanged;
        private bool _passwordChanged;

        public Conta()
        {
            _user = string.Empty;
            _nome = string.Empty;
            _password = string.Empty;
        }

        public Conta(string user,string nome,string password)
        {
            User = user;
            Nome = nome;
            _password = password;
        }

        public string User
        {
            get { return _user; }
            set { if (validarString(value)) _user = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { if (validarString(value)) { _nome = value; _nomeChanged = true; } }
        }

        public string Password
        {
            get { return _password; }
            set { if (validarString(value)) { _password = BCrypt.Net.BCrypt.HashPassword(value); _passwordChanged = true; } }
        }

        private bool validarString(string s)
        {
            return !String.IsNullOrEmpty(s) && !String.IsNullOrWhiteSpace(s) && s.Count()<100 && s.Count() > 3;
        }

        public bool save()
        {
            DAL dal = new DAL("Conta");
            List < KeyValuePair<string, string> > kv = new List<KeyValuePair<string, string>>();
            if (_nomeChanged)
                kv.Add(new KeyValuePair<string, string>("nome", _nome));
            if (_passwordChanged)
                kv.Add(new KeyValuePair<string, string>("password", _password));

            if(dal.exists("where username = '"+_user+"'"))
            {
                return dal.update(kv, "where username = '" + _user + "'");
            }else
            {
                kv.Add(new KeyValuePair<string, string>("username", _user));
                return dal.insert(kv);
            }
        }

        public bool delete()
        {
            DAL dal = new DAL("Conta");
            if (dal.exists("where username = '" + _user + "'"))
                return dal.delete("where username = '" + _user + "'");
            return false;
        }
        public bool comparePassword(string p)
        {
            return BCrypt.Net.BCrypt.Verify(p, _password);
        }
    }
}
