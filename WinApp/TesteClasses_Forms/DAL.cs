using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using MinhasClasses;

namespace TesteClasses_Forms
{
    public class DAL
    {
        private OleDbConnection _conexao;

        public DAL()
        {
            _conexao = new OleDbConnection();
            _conexao.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Basedados\\DBTeste.mdb;";
        }

        public List<Editora> ObterTodasEditoras()
        {
            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();


            OleDbCommand comando = new OleDbCommand();
            comando.CommandText = "SELECT * FROM [EDITORA]";
            OleDbDataReader dataR = comando.ExecuteReader();
            if (dataR.HasRows)
            {
                List<Editora> temp = new List<Editora>();
                while (dataR.Read())
                {
                    Editora editora = new Editora();
                    editora.Id = dataR.GetString(0);
                    editora.Nome = dataR.GetString(1);
                    temp.Add(editora);
                }
                return temp;
            }

            _conexao.Close();
            return new List<Editora>();
        }
        
        public int InserirEditora(Editora e)
        {
            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();


            OleDbCommand comando = new OleDbCommand();
            comando.Connection = _conexao;
            comando.CommandText = "INSERT INTO [EDITORA] VALUES (@i,@n)";
            comando.Parameters.AddWithValue("@i", e.Id);
            comando.Parameters.AddWithValue("@n", e.Nome);
            int nlinhas = comando.ExecuteNonQuery();
            _conexao.Close();
            return nlinhas;
        }


    }
}
