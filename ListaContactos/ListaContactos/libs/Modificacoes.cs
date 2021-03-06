﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public static class Modificacoes
    {
        private static DAL _dal = new DAL("Modificacao");

        /// <summary>
        /// Fazer um Resgisto
        /// </summary>
        /// <param name="c">Contacto modificado</param>
        /// <param name="conta">Conta que modificou</param>
        /// <param name="s">Descrição</param>
        public static void Registar(Contacto c,Conta conta,string s)
        {
            List<KeyValuePair<string, string>> kv = new List<KeyValuePair<string, string>>();
            kv.Add(new KeyValuePair<string, string>("id_contacto", c.ID));
            kv.Add(new KeyValuePair<string, string>("id_modificador", conta.User));
            kv.Add(new KeyValuePair<string, string>("descricao", s));
            //kv.Add(new KeyValuePair<string, string>("Data", DateTime.Now.ToString()));
            _dal.insert(kv);
        }

        /// <summary>
        /// Função para obter a Ultima modificação
        /// </summary>
        /// <param name="c">Contacto</param>
        /// <returns>String com a informação necessária</returns>
        public static string UltimaMod(Contacto c)
        {
            OleDbDataReader data = _dal.find("top 1 id_modificador,Data", $"where id_contacto='{c.ID}' order by Data desc");
            string r = null;
            if (data.HasRows)
            {
                while (data.Read())
                {
                    r = $"Ultima vez modificado por: {data.GetString(0)} [{data.GetDateTime(1)}]";
                }
            }
            data.Close();
            return r;
        }

        /// <summary>
        /// Função para obter as modificações de um contacto
        /// </summary>
        /// <param name="id">Id do contacto</param>
        /// <returns>lista das modificações</returns>
        public static List<string[]> GetModFromId(string id)
        {
            List<string[]> l = new List<string[]>();

            OleDbDataReader data = _dal.find("id_modificador,descricao,Data", $"where id_contacto = '{id}' order by Data desc");
            if(data.HasRows)
            {
                while(data.Read())
                {
                    l.Add(new string[3]{ data.GetString(0),data.GetString(1),data.GetDateTime(2).ToString()});
                }
            }
            data.Close();
            return l;
        }
    }
}
