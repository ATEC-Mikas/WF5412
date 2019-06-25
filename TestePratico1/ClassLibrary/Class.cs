using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class Class
    {
        public static int SomaValores(int[] listaNumeros, bool par)
        {
            int soma = 0;
            foreach(int num in listaNumeros)
                if(num%2==(par ? 0 : 1))
                    soma += num;

            return soma;
        }

        //Comentario:
        // Esta estrutura de dados tem a limitação grave de só poder ter um "Miguel" ou um "Joao" por turma visto que num dictionary a key tem de ser única
        public static DataTable DictTurmasToDatatable(Dictionary<int,Dictionary<string,int>> turmas)
        {
            DataTable result = new DataTable();
            result.Clear();
            result.Columns.Add("turmaid").DataType = typeof(int);
            result.Columns.Add("nomealuno");
            result.Columns.Add("altura").DataType = typeof(int);
            foreach (KeyValuePair<int,Dictionary<string,int>> turma in turmas)
            {
                foreach(KeyValuePair<string,int> aluno in turma.Value)
                {
                    DataRow entrada = result.NewRow();
                    entrada["turmaid"] = turma.Key;
                    entrada["nomealuno"] = aluno.Key;
                    entrada["altura"] = aluno.Value;
                    result.Rows.Add(entrada);
                }
            }
            result.DefaultView.Sort = "turmaid asc, nomealuno asc, altura desc";
            result = result.DefaultView.ToTable();
            return result;
        }

        public static DataTable TurmasToDatatable(List<Turma> turmas)
        {
            DataTable result = new DataTable();
            result.Clear();
            result.Columns.Add("turmaid").DataType = typeof(int);
            result.Columns.Add("nomealuno");
            result.Columns.Add("altura").DataType = typeof(int);
            foreach (Turma turma in turmas)
            {
                foreach (Aluno aluno in turma.Alunos)
                {
                    DataRow entrada = result.NewRow();
                    entrada["turmaid"] = turma.ID;
                    entrada["nomealuno"] = aluno.Nome;
                    entrada["altura"] = aluno.Altura;
                    result.Rows.Add(entrada);
                }
            }
            result.DefaultView.Sort = "turmaid asc, nomealuno asc, altura desc";
            result = result.DefaultView.ToTable();
            return result;
        }
    }

    public class Cliente
    {
        public string ID { get; set; }
        public string Nome { get; set; }
        public string NomeContacto { get; set; }

        public Cliente()
        { }
        public Cliente(string ID)
        {

        }
    }
    public class Clientes
    {
        public string ID { get; set; }
        public string Nome { get; set; }
        public static class Campos
        {
            public static string CustomerID { get { return "CustomerID"; } }
            public static string CompanyName { get { return "CompanyName"; } }
        }


    }
}




