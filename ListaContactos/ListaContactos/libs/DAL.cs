using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public class DAL
    {
        private OleDbConnection _conexao;
        private string _tabela;
        private Log _logs;
        private Log _querylogs;

        public DAL(string tabela) {
            _conexao = new OleDbConnection();
            _conexao.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db\\listacontactos.mdb;";
            _tabela = tabela;
            _logs = new Log($"logs/{_tabela}.txt");
            _querylogs = new Log($"logs/{_tabela}-queries.txt");
        }

        public OleDbDataReader get(string s)
        {
            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();


            OleDbCommand comando = new OleDbCommand();
            comando.CommandText = $"SELECT {s} FROM [{_tabela}]";
            _querylogs.EscreverLog(comando.CommandText);

            comando.Connection = _conexao;
            OleDbDataReader t = comando.ExecuteReader();
            //_conexao.Close();
            return t;
        }

        public OleDbDataReader find(string s,string a)
        {
            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();


            OleDbCommand comando = new OleDbCommand();
            comando.CommandText = $"SELECT {s} FROM [{_tabela}] {a}";
            _querylogs.EscreverLog(comando.CommandText);

            comando.Connection = _conexao;
            OleDbDataReader t = comando.ExecuteReader();
            //_conexao.Close();
            return t;
        }

        public bool insert(List<KeyValuePair<string,string>> kv)
        {
            bool falhou = false;
            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();

            string id = string.Empty;
            string valor = string.Empty;
            for (int i = 0; i < kv.Count; i++)
            {
                id += $"[{kv[i].Key}]";
                if (kv[i].Key == "nif" || kv[i].Key == "tipo_comunicacao" || kv[i].Key == "publico")
                     valor += kv[i].Value;
                else 
                     valor += $"'{kv[i].Value}'";
                if (i != kv.Count - 1)
                {
                    id += ",";
                    valor += ",";
                }

            }


            OleDbCommand comando = new OleDbCommand();
            comando.Connection = _conexao;
            comando.CommandText = $"INSERT INTO [{_tabela}]({id}) VALUES ({valor})";
            _querylogs.EscreverLog(comando.CommandText);
            try {
                comando.ExecuteNonQuery();     
            }
            catch(Exception e)
            {
                falhou = true;
                _logs.EscreverLog(e.Message);
            }
            _conexao.Close();

            return !falhou;
        }

        public bool update(List<KeyValuePair<string, string>> kv, string a)
        {
            bool falhou = false;
            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();

            string set = string.Empty;
            for (int i = 0; i < kv.Count; i++)
            {
                if (kv[i].Key == "nif" || kv[i].Key == "tipo_comunicacao" || kv[i].Key == "publico")
                    set += $"[{kv[i].Key}] = {kv[i].Value}";
                else
                    set += $"[{kv[i].Key}] = '{kv[i].Value}'";
                if (i != kv.Count - 1)
                {
                    set += ",";
                }
            }


            OleDbCommand comando = new OleDbCommand();
            comando.Connection = _conexao;
            comando.CommandText = $"UPDATE [{_tabela}] SET {set} {a}";
            _querylogs.EscreverLog(comando.CommandText);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                falhou = true;
                _logs.EscreverLog(e.Message);
            }
            _conexao.Close();

            return !falhou;

        }

        public bool delete(string a)
        {
            bool falhou = false;
            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();

            OleDbCommand comando = new OleDbCommand();
            comando.Connection = _conexao;
            comando.CommandText = $"delete * from [{_tabela}] {a}";
            _querylogs.EscreverLog(comando.CommandText);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                falhou = true;
                _logs.EscreverLog(e.Message);
            }
            _conexao.Close();

            return !falhou;

        }

        public bool exists(string a)
        {
            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();


            OleDbCommand comando = new OleDbCommand();
            comando.Connection = _conexao;
            comando.CommandText = $"SELECT * FROM [{_tabela}] {a}";
            _querylogs.EscreverLog(comando.CommandText);
            OleDbDataReader t = comando.ExecuteReader();
            if(t.HasRows)
            {
                _conexao.Close();
                return true;
            }
            else
            {
                _conexao.Close();
                return false;
            }

        }




    }
}
