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

            OleDbDataReader data = _dal.find("nome_empresa", $"where id_contacto={id}");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    //kv.Add();
                }
                data.Close();   
            }


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
                    dic.Add(data.GetString(0),data.GetString(1));
                }
                data.Close();
            }
            
            return dic;
        }
        
        public static string GetTipo(string tipo)
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
                data.Close();
            }

            return r;
        }
            
        

    }
}
