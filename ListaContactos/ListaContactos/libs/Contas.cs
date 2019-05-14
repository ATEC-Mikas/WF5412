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

        /// <summary>
        /// Função que retorna uma lista de todas as contas
        /// </summary>
        /// <returns>Lista com todas as contas</returns>
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
            }
            data.Close();
            return contas;
        }

        /// <summary>
        /// Função que encontra as contas que cumprem um certo requesito
        /// </summary>
        /// <param name="s">Query com o requesito Exemplo: "where id==1"</param>
        /// <returns>Lista com contas que cumprem esse requesito</returns>
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
            }
            data.Close();
            return contas;
        }

        /// <summary>
        /// Função que encontra a conta com aquele username
        /// </summary>
        /// <param name="id">Username da conta</param>
        /// <returns>Conta com aquele username | Se não encontrar a conta é nula</returns>
        public static Conta FindByUser(string id)
        {
            OleDbDataReader data = _dal.find("username,nome,password", $"where username='{Mikas.EscapeSQLSQ(id)}'");
            Conta t=null;
            if (data.HasRows)
            {
                while (data.Read())
                {
                    t = new Conta(data.GetString(0), data.GetString(1), data.GetString(2));
                }
            }
            data.Close();
            return t;
        }

        /// <summary>
        /// Verifica se a conta existe
        /// </summary>
        /// <param name="user">Username da conta</param>
        /// <returns>Booleano com a existência da conta</returns>
        public static bool exists(string user)
        {
            return _dal.exists($"where username='{Mikas.EscapeSQLSQ(user)}'");
        }
    }
}
