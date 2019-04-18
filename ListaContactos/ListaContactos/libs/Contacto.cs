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
        private bool _publico;
        private bool _idChanged;
        private bool _nomeChanged;
        private bool _tituloChanged;
        private bool _moradaChanged;
        private bool _nifChanged;
        private bool _comunicacoesChanged;
        private bool _publicoChanged;

        private Contacto()
        {
            _idChanged = false;
            _nomeChanged = false;
            _tituloChanged = false;
            _moradaChanged = false;
            _nifChanged = false;
            _comunicacoesChanged = false;
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

        


    }
}
