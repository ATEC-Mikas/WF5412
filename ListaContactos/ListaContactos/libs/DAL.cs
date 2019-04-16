using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    internal class DAL
    {
        private OleDbConnection _conexao;
        private string _tabela;

        public DAL(string tabela) {
            _conexao = new OleDbConnection();
            _conexao.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db\\listacontactos.mdb;";
            _tabela = tabela;
        }

        public OleDbDataReader find(string s)
        {
            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();


            OleDbCommand comando = new OleDbCommand();
            comando.CommandText = "SELECT "+s+ " FROM [" + _tabela + "]";
            
            comando.Connection = _conexao;
            return comando.ExecuteReader();
        }

        public OleDbDataReader find(string s,string a)
        {
            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();


            OleDbCommand comando = new OleDbCommand();
            comando.CommandText = "SELECT " + s + " FROM ["+_tabela+"] "+a;

            comando.Connection = _conexao;
            return comando.ExecuteReader();
        }


    }
}
