using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public static class Contas
    {
        private static DAL _dal = new DAL("Conta");

        public static List<Conta> all()
        {
            List<Conta> contas = new List<Conta>();
            OleDbDataReader data = _dal.get("username,nome,password");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    contas.Add(new Conta(data.GetString(0), data.GetString(1), data.GetString(2)));
                }
                data.Close();
            }
            return contas;
        }

        public static List<Conta> find(string s)
        {
            List<Conta> contas = new List<Conta>();
            OleDbDataReader data = _dal.find("username,nome,password",s);
            if (data.HasRows)
            {
                while (data.Read())
                {
                    contas.Add(new Conta(data.GetString(0), data.GetString(1), data.GetString(2)));
                }
                data.Close();
            }
            return contas;
        }

        public static Conta FindByUser(string id)
        {
            OleDbDataReader data = _dal.find("username,nome,password", $"where username='{id}'");
            Conta t=null;
            if (data.HasRows)
            {
                while (data.Read())
                {
                    t = new Conta(data.GetString(0), data.GetString(1), data.GetString(2));
                }
                data.Close();
            }
            return t;
        }
    }
}
