﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public static class Contactos
    {
        private static DAL _dal = new DAL("Contato");

        public static List<Contacto> All()
        {
            List<Contacto> contactos = new List<Contacto>();


            OleDbDataReader data = _dal.get("id,nome,titulo,morada,nif,criador,data_criado,publico");
            if (data.HasRows)
            {
                while (data.Read())
                {
                        string id = data.GetString(0);
                        contactos.Add(new Contacto(id,
                                                   data.GetString(1),
                                                   data.GetString(2),
                                                   data.GetString(3),
                                                   data.GetInt32(4),
                                                   Contas.FindByUser(data.GetString(5)),
                                                   data.GetDateTime(6),
                                                   data.GetBoolean(7),
                                                   Comunicacoes.FindById(id),
                                                   Empresas.FindById(id))
                            );
                }
            }
            data.Close();
            return contactos;
        }

        public static Contacto FindById(string id)
        {
            Contacto c=null;
            OleDbDataReader data = _dal.find("nome,titulo,morada,nif,criador,data_criado,publico", $"where id='{id}'");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    c=new Contacto(id,
                                    data.GetString(0),
                                    data.GetString(1),
                                    data.GetString(2),
                                    data.GetInt32(3),
                                    Contas.FindByUser(data.GetString(4)),
                                    data.GetDateTime(5),
                                    data.GetBoolean(6),
                                    Comunicacoes.FindById(id),
                                    Empresas.FindById(id)
                        );
                }
            }
            data.Close();
            return c;
        }


        public static List<KeyValuePair<string, string>> AllForListFiltered(Conta c,List<KeyValuePair<string,string>> filtros)
        {
            bool publico = false;
            bool comunicacao = false;
            bool empresa = false;

            string fpublico = null;
            List<string> idsComunicacoes = new List<string>();
            List<string> idsEmpresas = new List<string>();
            List<string> idsContactos = new List<string>();
            List<KeyValuePair<string, string>> contactos = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> _filtros = new List<KeyValuePair<string, string>>(filtros);
            List<KeyValuePair<string, string>> discarding = new List<KeyValuePair<string, string>>();

            foreach(KeyValuePair<string, string> kv in _filtros)
            {
                if (kv.Key == "publico")
                {
                    fpublico = kv.Value;
                    discarding.Add(kv);
                    publico = true;
                }
                if(kv.Key=="comunicacao")
                {
                    foreach (string s in Comunicacoes.FindByComunicacao(kv.Value))
                        if (!idsComunicacoes.Contains(s))
                            idsComunicacoes.Add(s);
                    discarding.Add(kv);
                    comunicacao = true;
                }
                if (kv.Key == "empresa")
                {
                    foreach (string s in Empresas.FindByEmpresa(kv.Value))
                        if (!idsEmpresas.Contains(s))
                            idsEmpresas.Add(s);
                    discarding.Add(kv);
                    empresa = true;
                }
            }
            

            foreach(KeyValuePair<string,string> kv in discarding)
            {
                _filtros.Remove(kv);
            }

            string query = string.Empty;
            string values = "and ";
            if (fpublico!=null)
            {
                if(fpublico=="True")
                    query = $"where publico=true";
                if(fpublico=="False")
                    query = $"where criador='{c.User}' and publico=false";
            }
            for(int i=0;i<_filtros.Count;i++)
            {
                    if (_filtros[i].Key == "nif")
                        values += $"nif={_filtros[i].Value}";
                    else
                        values += $"{_filtros[i].Key} like '%{_filtros[i].Value}%'";
                    if (i != _filtros.Count - 1)
                        values += " and ";
            }

            if (values == "and ")
                values = string.Empty;

            if(fpublico==null)
            {
                OleDbDataReader data = _dal.find("id", $"where criador='{c.User}' and publico=false {values}");
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        idsContactos.Add(data.GetString(0));
                    }
                }
                data.Close();

                data = _dal.find("id", $"where publico=true and criador='{c.User}' {values}");
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        idsContactos.Add(data.GetString(0));
                    }
                }

                data = _dal.find("id", $"where publico=true and criador<>'{c.User}' {values}");
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        idsContactos.Add(data.GetString(0));
                    }
                }
                data.Close();
            } else
            {
                OleDbDataReader data = _dal.find("id", $"{query} {values}");
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        idsContactos.Add(data.GetString(0));
                    }
                }
                data.Close();
            }

            List<string> r = new List<string>(idsContactos);

            if(comunicacao)
            {
                if (idsComunicacoes.Count > 0)
                {
                    foreach (string id in idsContactos)
                        if (!idsComunicacoes.Contains(id))
                            r.Remove(id);
                }
                else
                {
                    r.Clear();
                }
            }
            if(empresa)
            {
                if(idsEmpresas.Count>0)
                {
                    foreach (string id in idsContactos)
                        if (!idsEmpresas.Contains(id))
                            r.Remove(id);
                }
                else
                {
                    r.Clear();
                }
            }



            foreach (string s in r)
            {
                OleDbDataReader data = _dal.find("id,nome", $"where id='{s}'");
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        contactos.Add(new KeyValuePair<string, string>(data.GetString(0), data.GetString(1)));
                    }
                }
                data.Close();
            }
            
            return contactos;
        }





        public static List<KeyValuePair<string,string>> AllForList(Conta c)
        {
            List<KeyValuePair<string, string>> contactos = new List<KeyValuePair<string, string>>();


            OleDbDataReader data = _dal.find("id,nome", $"where criador='{c.User}' and publico=false");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    contactos.Add(new KeyValuePair<string, string>(data.GetString(0), data.GetString(1)));
                }
            }
            data.Close();

            data = _dal.find("id,nome", $"where publico=true and criador='{c.User}'");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    contactos.Add(new KeyValuePair<string, string>(data.GetString(0), data.GetString(1)));
                }
            }

            data = _dal.find("id,nome", $"where publico=true and criador<>'{c.User}'");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    contactos.Add(new KeyValuePair<string, string>(data.GetString(0), data.GetString(1)));
                }
            }
            data.Close();
            return contactos;
        }

        public static List<Contacto> All(Conta c)
        {
            List<Contacto> contactos = new List<Contacto>();


            OleDbDataReader data = _dal.find("id,nome,titulo,morada,nif,criador,data_criado,publico",$"where criador='{c.User}' and publico=false");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    string id = data.GetString(0);
                    contactos.Add(new Contacto(id,
                                               data.GetString(1),
                                               data.GetString(2),
                                               data.GetString(3),
                                               data.GetInt32(4),
                                               Contas.FindByUser(data.GetString(5)),
                                               data.GetDateTime(6),
                                               data.GetBoolean(7),
                                               Comunicacoes.FindById(id),
                                               Empresas.FindById(id))
                        );
                }
            }
            data.Close();
            data = _dal.find("id,nome,titulo,morada,nif,criador,data_criado,publico", $"where publico=true");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    string id = data.GetString(0);
                    contactos.Add(new Contacto(id,
                                               data.GetString(1),
                                               data.GetString(2),
                                               data.GetString(3),
                                               data.GetInt32(4),
                                               Contas.FindByUser(data.GetString(5)),
                                               data.GetDateTime(6),
                                               data.GetBoolean(7),
                                               Comunicacoes.FindById(id),
                                               Empresas.FindById(id))
                        );
                }
            }
            data.Close();
            return contactos;
        }

        public static bool Existe(string id)
        {
            return _dal.exists($"where id='{id}'");
        }

    }
}
