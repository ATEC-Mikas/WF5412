using System;
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

        public static void Registar(Contacto c,Conta conta)
        {
            List<KeyValuePair<string, string>> kv = new List<KeyValuePair<string, string>>();
            kv.Add(new KeyValuePair<string, string>("id_contacto", c.ID));
            kv.Add(new KeyValuePair<string, string>("id_modificador", conta.User));
            kv.Add(new KeyValuePair<string, string>("Data", DateTime.Now.ToString()));
            _dal.insert(kv);
        }

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
    }
}
