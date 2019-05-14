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

        /// <summary>
        /// Construtor da Conta vazia
        /// </summary>
        public Conta()
        {
            _user = string.Empty;
            _nome = string.Empty;
            _password = string.Empty;
        }

        /// <summary>
        /// Contrutor da Conta Atributos
        /// </summary>
        /// <param name="user">Username</param>
        /// <param name="nome">Nome da Pessoa</param>
        /// <param name="password">Palavra-Passe Encriptada</param>
        public Conta(string user,string nome,string password)
        {
            User = user;
            Nome = nome;
            _password = password;
        }

        /// <summary>
        /// Contrutor da Conta Cópia
        /// </summary>
        /// <param name="c">Conta a copiar</param>
        public Conta(Conta c)
        {
            User = c.User;
            Nome = c.Nome;
            _password = c.Password;
        }

        /// <summary>
        /// Username do Utilizador
        /// </summary>
        public string User
        {
            get { return _user; }
            set { if (validarString(value)) _user = value; }
        }

        /// <summary>
        /// Nome do Utilizador
        /// </summary>
        public string Nome
        {
            get { return _nome; }
            set { if (validarString(value)) { _nome = value; _nomeChanged = true; } }
        }

        /// <summary>
        /// Palavra pass do Utilizador
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { if (validarString(value)) { _password = BCrypt.Net.BCrypt.HashPassword(value); _passwordChanged = true; } }
        }

        private bool validarString(string s)
        {
            return !String.IsNullOrEmpty(s) && !String.IsNullOrWhiteSpace(s) && s.Count()<100 && s.Count() > 2;
        }

        /// <summary>
        /// Função para salvar a conta
        /// </summary>
        /// <returns>Boolean do sucesso da operação</returns>
        public bool save()
        {
            DAL dal = new DAL("Conta");
            List < KeyValuePair<string, string> > kv = new List<KeyValuePair<string, string>>();
            if (_nomeChanged)
                kv.Add(new KeyValuePair<string, string>("nome", _nome));
            if (_passwordChanged)
                kv.Add(new KeyValuePair<string, string>("password", _password));

            if(dal.exists($"where username = '{Mikas.EscapeSQLSQ(_user)}'"))
            {
                return dal.update(kv, $"where username = '{Mikas.EscapeSQLSQ(_user)}'");
            }else
            {
                kv.Add(new KeyValuePair<string, string>("username", Mikas.EscapeSQLSQ(_user)));
                return dal.insert(kv);
            }
        }

        /// <summary>
        /// Função para apagar a conta
        /// </summary>
        /// <returns>Boolean do sucesso da operação</returns>
        public bool delete()
        {
            DAL dal = new DAL("Conta");
            if (dal.exists($"where username = '{Mikas.EscapeSQLSQ(_user)}'"))
                return dal.delete($"where username = '{Mikas.EscapeSQLSQ(_user)}'");
            return false;
        }

        /// <summary>
        /// Função para comparar a password não encriptada com a encripatada
        /// </summary>
        /// <param name="p">Password não encriptada</param>
        /// <returns>Boolean do sucesso da operação</returns>
        public bool comparePassword(string p)
        {
            return BCrypt.Net.BCrypt.Verify(p, _password);
        }
    }
}
