using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    class Contacto
    {
        private string _id;
        private string _nome;
        private string _titulo;
        private string _morada;
        private int _nif;
        private Conta _criador;
        private DateTime _dataCriada;
        private List<KeyValuePair<string,string>> _comunicacoes;
        private List<string> _empresas;
        private bool _publico;
        private bool _nomeChanged;
        private bool _tituloChanged;
        private bool _moradaChanged;
        private bool _nifChanged;
        private bool _comunicacoesChanged;
        private bool _empresasChanged;
        private bool _publicoChanged;

        private Contacto()
        {
            _nomeChanged = false;
            _tituloChanged = false;
            _moradaChanged = false;
            _nifChanged = false;
            _comunicacoesChanged = false;
            _empresasChanged = false;
            _publicoChanged = false;
        }

        public Contacto(Conta c) : this()
        {
            DAL dal = new DAL("Contacto");
            string guid_temp;
            do
            {
                guid_temp = Guid.NewGuid().ToString();
            }
            while (dal.exists("where id='" + guid_temp + "'"));
            _id = guid_temp;
            _nome = string.Empty;
            _titulo = string.Empty;
            _morada = string.Empty;
            _nif = -1;
            _criador = new Conta(c);
            _dataCriada = DateTime.Now;
            _comunicacoes = new List<KeyValuePair<string, string>>();
            _empresas = new List<string>();
            _publico = false;

        }

        public Contacto(string id,string nome,string titulo,string morada,int nif,Conta criador,DateTime dataCriada,List<KeyValuePair<string,string>> comunicacoes, bool publico) : this()
        {
            _id = id;
            _nome = nome;
            _titulo = titulo;
            _morada = morada;
            _nif = nif;
            _criador = new Conta(criador);
            _dataCriada = dataCriada;
            _comunicacoes = new List<KeyValuePair<string, string>>(comunicacoes);
            _publico = publico;
        }

        private bool validarString(string s,int max = 100,int min = 3)
        {
            return !String.IsNullOrEmpty(s) && !String.IsNullOrWhiteSpace(s) && s.Count() < max && s.Count() > min;
        }



        public string ID { get { return _id; } }
        public string Nome { get { return _nome; } set { if (validarString(value)) { _nome = value; _nomeChanged = true; } } }
        public string Titulo { get { return _titulo; } set { if (validarString(value)) { _titulo = value; _tituloChanged = true; } } }
        public string Morada { get { return _morada; } set { if (validarString(value)) { _morada = value; _moradaChanged = true; } } }
        public int Nif { get { return _nif; } set { if (value > 100000000 && value < 999999999) { _nif = value; _nifChanged = true; } } }
        public Conta Criador { get { return _criador; } }
        public DateTime DataCriada { get { return _dataCriada; } }
        public List<KeyValuePair<string,string>> Comunicacoes { get { return _comunicacoes; } }
        public bool Publico { get { return _publico; } set { if (value != _publico) { _publico = value; _publicoChanged = true; } } }

        public void AdicionarComunicacao(string k,string v)
        {
            Comunicacoes.Add(new KeyValuePair<string, string>(k, v));
            _comunicacoesChanged = true;
        }

        public bool RemoverComunicacao(int i)
        {
            if(i>=0&&i>Comunicacoes.Count-1)
            {
                Comunicacoes.RemoveAt(i);
                _comunicacoesChanged = true;
                return true;
            }
            return false;
        }

        public bool RemoverComunicacao(string k,string v)
        {
            if(!_comunicacoesChanged)
                return _comunicacoesChanged = Comunicacoes.Remove(new KeyValuePair<string, string>(k, v));
            else 
                return Comunicacoes.Remove(new KeyValuePair<string, string>(k, v));
        }

        public bool save()
        {
            //private bool _nomeChanged;
            //private bool _tituloChanged;
            //private bool _moradaChanged;
            //private bool _nifChanged;
            //private bool _comunicacoesChanged;
            //private bool _empresasChanged;
            //private bool _publicoChanged;
            DAL dal = new DAL("Contacto");
            List<KeyValuePair<string, string>> kv = new List<KeyValuePair<string, string>>();
            if (_nomeChanged)
                kv.Add(new KeyValuePair<string, string>("nome", _nome));
            if (_tituloChanged)
                kv.Add(new KeyValuePair<string, string>("titulo", _titulo));
            if (_moradaChanged)
                kv.Add(new KeyValuePair<string, string>("morada", _morada));
            if(_nifChanged)
                kv.Add(new KeyValuePair<string, string>("nif", _nif.ToString()));
            if(_comunicacoesChanged)
            {
                //TODO : Criar classe comunicacoes para auxiliar esta parte
            }
            if(_empresasChanged)
            {
                //TODO : criar classe empresa para auxiliar esta parte
            } 
            if(_publicoChanged)
                kv.Add(new KeyValuePair<string, string>("publico", _publico.ToString()));

            if (dal.exists($"where id = '{_id}'"))
            {
                return dal.update(kv, $"where id = '{_id}'");
            }
            else
            {
                kv.Add(new KeyValuePair<string, string>("id", _id));
                return dal.insert(kv);
            }
        }

        public bool delete()
        {
            DAL dal = new DAL("Contacto");
            if (dal.exists($"where id = '{_id}'"))
                return dal.delete($"where id = '{_id}'");
            return false;
        }


    }
}
