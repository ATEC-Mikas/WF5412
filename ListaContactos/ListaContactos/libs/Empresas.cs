using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public static class Empresas
    {
        private static DAL _dal = new DAL("Contacto_Empresa");

        public static List<string> FindById(string id)
        {
            List<string> l = new List<string>();

            OleDbDataReader data = _dal.find("nome_empresa", $"where id_contacto='{id}'");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    l.Add(data.GetString(0));
                }
            }
            data.Close();
            return l;
        }
        public static void Sync(List<string> l,string id)
        {
            List<string> lb = FindById(id);

            foreach (string s in lb)
                if (!l.Contains(s))
                    _dal.delete($"where id_contacto='{id}' and nome_empresa='{s}'");

            lb = FindById(id);
            foreach(string s in l)
            {
                if(!lb.Contains(s))
                {
                    List<KeyValuePair<string, string>> kv = new List<KeyValuePair<string, string>>();
                    kv.Add(new KeyValuePair<string, string>("id_contacto", id));
                    kv.Add(new KeyValuePair<string, string>("nome_empresa", s));
                    _dal.insert(kv);
                }
            }
        }
        public static List<string> FindByEmpresa(string nome)
        {
            List<string> list = new List<string>();
            OleDbDataReader data = _dal.find("id_contacto", $"where nome_empresa like '%{nome}%'"); 
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
    }
}
