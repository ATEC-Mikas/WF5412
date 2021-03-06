﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public class Contacto
    {
        private string _id;
        private string _nome;
        private string _titulo;
        private string _morada;
        private int _nif;
        private Conta _criador;
        private DateTime _dataCriada;
        private string _foto;
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
        private bool _fotoChanged;

        /// <summary>
        /// Contrutor base
        /// </summary>
        /// <param name="t">Boolean para determinar se inicia a false ou a true</param>
        private Contacto(bool t)
        {
            _nomeChanged = t;
            _tituloChanged = t;
            _moradaChanged = t;
            _nifChanged = t;
            _comunicacoesChanged = t;
            _empresasChanged = t;
            _publicoChanged = t;
            _fotoChanged = t;
    }

        /// <summary>
        /// Construtor de novo contacto
        /// </summary>
        /// <param name="c">Conta Criadora</param>
        public Contacto(Conta c) : this(true)
        {
            DAL dal = new DAL("Contato");
            string guid_temp;
            do
            {
                guid_temp = Guid.NewGuid().ToString();
            }
            while (dal.exists($"where id='{guid_temp}'"));
            _id = guid_temp;
            _nome = string.Empty;
            _titulo = string.Empty;
            _morada = string.Empty;
            _nif = -1;
            _criador = new Conta(c);
            _comunicacoes = new List<KeyValuePair<string, string>>();
            _empresas = new List<string>();
            _publico = false;
            _foto = "default.jpg";

        }

        /// <summary>
        /// Construtor de Contacto já criado
        /// </summary>
        /// <param name="id">ID do Contacto</param>
        /// <param name="nome">Nome do Contacto</param>
        /// <param name="titulo">Titulo do Contacto</param>
        /// <param name="morada">Morada do Contacto</param>
        /// <param name="nif">Nif do Contacto</param>
        /// <param name="criador">Criador do Contacto</param>
        /// <param name="dataCriada">Data criada do Contacto</param>
        /// <param name="publico">Contacto Publico?</param>
        /// <param name="comunicacoes">Lista de Comunicacoes</param>
        /// <param name="empresas">Lista de Empresas</param>
        /// <param name="foto">Local Foto</param>
        public Contacto(string id,string nome,string titulo,string morada,int nif,Conta criador,DateTime dataCriada, bool publico, List<KeyValuePair<string, string>> comunicacoes, List<string> empresas, string foto) : this(false)
        {
            _id = id;
            _nome = nome;
            _titulo = titulo;
            _morada = morada;
            _nif = nif;
            _criador = new Conta(criador);
            _dataCriada = dataCriada;
            _publico = publico;
            _comunicacoes = new List<KeyValuePair<string, string>>(comunicacoes);
            _empresas = new List<string>(empresas);
            _foto = foto;
        }

        /// <summary>
        /// Contrutor Cópia do Contacto
        /// </summary>
        /// <param name="c">Contacto a Copiar</param>
        public Contacto(Contacto c) : this(c.ID,c.Nome,c.Titulo,c.Morada,c.Nif,c.Criador,c.DataCriada,c.Publico,c.Comunicacoes,c.Empresas,c.Foto)
        {
        }

        private bool validarString(string s,int max = 100,int min = 3)
        {
            return !String.IsNullOrEmpty(s) && !String.IsNullOrWhiteSpace(s) && s.Count() <= max && s.Count() >= min;
        }


        /// <summary>
        /// Id do Contacto
        /// </summary>
        public string ID { get { return _id; } }

        /// <summary>
        /// Nome do Contacto
        /// </summary>
        public string Nome { get { return _nome; } set { if (validarString(value) && value!=Nome) { _nome = value; _nomeChanged = true; } } }

        /// <summary>
        /// Titulo do Contacto
        /// </summary>
        public string Titulo { get { return _titulo; } set { if (value != Titulo) { _titulo = value; _tituloChanged = true; } } } 

        /// <summary>
        /// Morada do Contacto
        /// </summary>
        public string Morada { get { return _morada; } set { if (value != Morada) { _morada = value; _moradaChanged = true; } } }

        /// <summary>
        /// Nif do Contacto
        /// </summary>
        public int Nif { get { return _nif; } set { if (((value > 100000000 && value < 999999999) || value==-1) && value!=Nif) { _nif = value; _nifChanged = true; } } }

        /// <summary>
        /// Conta do criador do Contacto
        /// </summary>
        public Conta Criador { get { return _criador; } }

        /// <summary>
        /// Data Criação do Contacto
        /// </summary>
        public DateTime DataCriada { get { return _dataCriada; } }
        
        /// <summary>
        /// Lista de Comunicações
        /// </summary>
        public List<KeyValuePair<string,string>> Comunicacoes { get { return new List<KeyValuePair<string, string>>(_comunicacoes); } }

        /// <summary>
        /// Lista de Empresas
        /// </summary>
        public List<string> Empresas { get { return new List<string>(_empresas); } }

        /// <summary>
        /// Contacto é publico?
        /// </summary>
        public bool Publico { get { return _publico; } set { if (value != _publico) { _publico = value; _publicoChanged = true; } } }

        /// <summary>
        /// Local da Fotografia
        /// </summary>
        public string Foto { get { return _foto; } set{ _foto = value; _fotoChanged = true; } }

        /// <summary>
        /// Adicionar uma comunicacao
        /// </summary>
        /// <param name="k">Nome da Comunicação</param>
        /// <param name="v">Valor da Comunicação</param>
        /// <returns>Boolean de Sucesso da operação</returns>
        public bool AdicionarComunicacao(string k,string v)
        {
            if(!_comunicacoes.Contains(new KeyValuePair<string, string>(k, v)))
            {
                _comunicacoes.Add(new KeyValuePair<string, string>(k, v));
                _comunicacoesChanged = true;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Remover a Comunicação
        /// </summary>
        /// <param name="i">Numero index na lista</param>
        /// <returns>Boolean de Sucesso da operação</returns>
        public bool RemoverComunicacao(int i)
        {
            if(i>=0&&i>_comunicacoes.Count-1)
            {
                _comunicacoes.RemoveAt(i);
                _comunicacoesChanged = true;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Remover a Comunicação
        /// </summary>
        /// <param name="k">Nome da Comunicacoes</param>
        /// <param name="v">Valor da Comunicacao</param>
        /// <returns>Boolean de Sucesso da operação</returns>
        public bool RemoverComunicacao(string k,string v)
        {
            if(!_comunicacoesChanged)
                return _comunicacoesChanged = _comunicacoes.Remove(new KeyValuePair<string, string>(k, v));
            else 
                return _comunicacoes.Remove(new KeyValuePair<string, string>(k, v));
        }

        /// <summary>
        /// Adicionar uma empresa
        /// </summary>
        /// <param name="s">Nome da Empresa</param>
        /// <returns>Boolean de Sucesso da operação</returns>
        public bool AdicionarEmpresa(string s)
        {
            if(!_empresas.Contains(s))
            {
                _empresas.Add(s);
                _empresasChanged = true;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Remover uma empresa
        /// </summary>
        /// <param name="i">Numero index na lista</param>
        /// <returns>Boolean de Sucesso da operação</returns>
        public bool RemoverEmpresa(int i)
        {
            if (i >= 0 && i > _empresas.Count - 1)
            {
                _empresas.RemoveAt(i);
                _empresasChanged = true;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Remover uma empresa
        /// </summary>
        /// <param name="s">Nome da Empresa</param>
        /// <returns>Boolean de Sucesso da operação</returns>
        public bool RemoverEmpresa(string s)
        {
            if (!_empresasChanged)
                return _empresasChanged = _empresas.Remove(s);
            else
                return _empresas.Remove(s);
        }

        /// <summary>
        /// Salvar o Contacto
        /// </summary>
        /// <param name="c">Conta atual</param>
        /// <returns>Boolean de Sucesso da operação</returns>
        public bool save(Conta c)
        {
            bool sucesso = false;
            string log = string.Empty;
            
            DAL dal = new DAL("Contato");
            List<KeyValuePair<string, string>> kv = new List<KeyValuePair<string, string>>();
            if (_nomeChanged)
                kv.Add(new KeyValuePair<string, string>("nome", Mikas.EscapeSQLSQ(_nome)));
            if (_tituloChanged)
                kv.Add(new KeyValuePair<string, string>("titulo", Mikas.EscapeSQLSQ(_titulo)));
            if (_moradaChanged)
                kv.Add(new KeyValuePair<string, string>("morada", Mikas.EscapeSQLSQ(_morada)));
            if(_nifChanged)
                kv.Add(new KeyValuePair<string, string>("nif", Mikas.EscapeSQLSQ(_nif.ToString())));
            if(_publicoChanged)
                kv.Add(new KeyValuePair<string, string>("publico", Mikas.EscapeSQLSQ(_publico.ToString())));
            if (_fotoChanged)
                kv.Add(new KeyValuePair<string, string>("foto", Mikas.EscapeSQLSQ(_foto)));

            if (dal.exists($"where id = '{_id}'"))
            {
                sucesso = dal.update(kv, $"where id = '{_id}'");
            }
            else
            {
                kv.Add(new KeyValuePair<string, string>("id", _id));
                kv.Add(new KeyValuePair<string, string>("criador", Mikas.EscapeSQLSQ(_criador.User)));
                sucesso = dal.insert(kv);

                log = "Contacto criado.";

                System.Data.OleDb.OleDbDataReader data = dal.find("data_criado", $"where id='{_id}'");
                data.Read();
                _dataCriada = data.GetDateTime(0);
                data.Close();

            }

            if(_comunicacoesChanged)
            {
                ListaContactos.Comunicacoes.Sync(_comunicacoes,_id);
            }
            if(_empresasChanged)
            {
                ListaContactos.Empresas.Sync(_empresas, _id);
            }
            //logs
            if(sucesso)
            {
                if(log!= "Contacto criado.")
                {
                    log = "Campos afetados: ";
                    if (_nomeChanged)
                        log += "nome ";
                    if (_tituloChanged)
                        log += "titulo ";
                    if (_moradaChanged)
                        log += "morada ";
                    if (_nifChanged)
                        log += "nif ";
                    if (_publicoChanged)
                        log += "publico ";
                    if (_comunicacoesChanged)
                        log += "comunicações ";
                    if (_empresasChanged)
                        log += "empresas ";
                    if (_fotoChanged)
                        log += "foto ";
                }
                Modificacoes.Registar(this, c,log);
                _nomeChanged = false;
                _tituloChanged = false;
                _moradaChanged = false;
                _nifChanged = false;
                _comunicacoesChanged = false;
                _empresasChanged = false;
                _publicoChanged = false;
                _fotoChanged = false;
            }

            return sucesso;
        }

        /// <summary>
        /// Apagar o Contacto
        /// </summary>
        /// <returns>Boolean de Sucesso da operação</returns>
        public bool delete()
        {
            bool sucesso = false;
            DAL dal = new DAL("Contato");
            DAL empresa = new DAL("Contacto_Empresa");
            DAL comunicacao = new DAL("Comunicacao");
            if (dal.exists($"where id = '{_id}'"))
                if (dal.delete($"where id = '{_id}'"))
                    sucesso = true;
            if (empresa.exists($"where id_contacto='{_id}'"))
                if (!comunicacao.delete($"where id_contacto='{_id}'") && sucesso)
                    sucesso = false;
            if (comunicacao.exists($"where id_contacto='{_id}'"))
                if (!comunicacao.delete($"where id_contacto='{_id}'") && sucesso)
                    sucesso = false;

            if(sucesso)
                Modificacoes.Registar(this, this.Criador, "Contato eliminado.");
            return sucesso;
        }


    }
}
