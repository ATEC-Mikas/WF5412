using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public static class Comunicacoes
    {
        private static DAL _dal = new DAL("Comunicacao");


        public static List<KeyValuePair<string,string>> FindById(string id)
        {
            List<KeyValuePair<string, string>> kv = new List<KeyValuePair<string, string>>();

            OleDbDataReader data = _dal.find("tipo_comunicacao,comunicacao", $"where id_contacto='{id}'");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    kv.Add(new KeyValuePair<string, string>(GetTipoById(data.GetInt32(0).ToString()), data.GetString(1)));
                }
            }
            data.Close();   


            return kv;
        }

        public static Dictionary<string,string> GetTipos()
        {
            DAL tipodal = new DAL("Tipo_Comunicacao");
            Dictionary<string, string> dic = new Dictionary<string, string>();
            OleDbDataReader data = tipodal.get("id_comunicacao,nome");
            if(data.HasRows)
            {
                while(data.Read())
                {
                    dic.Add(data.GetInt32(0).ToString(),data.GetString(1));
                }
            }
            data.Close();
            
            return dic;
        }

        public static List<string> FindByComunicacao(string nome)
        {
            List<string> list = new List<string>();
            OleDbDataReader data = _dal.find("id_contacto",$"where comunicacao like '%{Mikas.EscapeSQL(nome)}%'");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    list.Add(data.GetString(0));
                }
            }
            data.Close();
            return list;
        }


        public static string GetTipoById(string tipo)
        {
            DAL tipodal = new DAL("Tipo_Comunicacao");
            string r=null;
            OleDbDataReader data = tipodal.find("nome",$"where id_comunicacao={tipo}");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    r=data.GetString(0);
                }
            }
            data.Close();

            return r;
        }

        public static string GetTipoByName(string nome)
        {
            DAL tipodal = new DAL("Tipo_Comunicacao");
            string r = null;
            OleDbDataReader data = tipodal.find("id_comunicacao", $"where nome='{nome}'");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    r = data.GetInt32(0).ToString();
                }
            }
            data.Close();

            return r;
        }

        public static void Sync(List<KeyValuePair<string,string>> kvl, string id)
        {
            List<KeyValuePair<string,string>> l = FindById(id);

            foreach (KeyValuePair<string, string> s in l)
                if (!kvl.Contains(s))
                    _dal.delete($"where id_contacto='{id}' and tipo_comunicacao={GetTipoByName(s.Key)} and comunicacao='{s.Value}'");

            l = FindById(id);

            foreach (KeyValuePair<string,string> s in kvl)
            {
                if (!l.Contains(s))
                {
                    List<KeyValuePair<string, string>> kv = new List<KeyValuePair<string, string>>();
                    kv.Add(new KeyValuePair<string, string>("id_contacto", id));
                    kv.Add(new KeyValuePair<string, string>("tipo_comunicacao", GetTipoByName(s.Key)));
                    kv.Add(new KeyValuePair<string, string>("comunicacao", s.Value));
                    _dal.insert(kv);
                }
            }
        }

        public static void AddTipo(string s)
        {
            if(GetTipoByName(s)==null){
                DAL tipodal = new DAL("Tipo_Comunicacao");
                List<KeyValuePair<string,string>> kv = new List<KeyValuePair<string, string>>();
                kv.Add(new KeyValuePair<string, string>("nome", s));
                tipodal.insert(kv);
            }
        }

    }
}
