using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DAL
    {
        private SqlConnection _connection;
        public DAL(string connectionString)
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = connectionString;
            //Ver se a connectionString é valida
            try
            {
                _connection.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Connection String Invalida / Connection Falhada", e);
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<Clientes> ListaTodosClientes()
        {
            if(_connection.State != ConnectionState.Open)
                _connection.Open();

            List<Clientes> clientes = new List<Clientes>();

            SqlCommand command = new SqlCommand();
            command.CommandText = $"SELECT CustomerID,CompanyName from Customers";
            command.Connection = _connection;
            using (SqlDataReader data = command.ExecuteReader())
            {
                if (data.HasRows)
                    while (data.Read())
                    {
                        Clientes cliente = new Clientes();
                        cliente.ID = (data.IsDBNull(0) ? "" : data.GetString(0));
                        cliente.Nome = (data.IsDBNull(1) ? "" : data.GetString(1));
                        clientes.Add(cliente);
                    }
            }
            _connection.Close();
            return clientes;
        }

        public List<Cliente> ListaContactosClientes()
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            List<Cliente> clientes = new List<Cliente>();

            SqlCommand command = new SqlCommand();
            command.CommandText = $"SELECT CustomerID,CompanyName,ContactName from Customers";
            command.Connection = _connection;
            using (SqlDataReader data = command.ExecuteReader())
            {
                if (data.HasRows)
                    while (data.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.ID = (data.IsDBNull(0) ? "" : data.GetString(0));
                        cliente.Nome = (data.IsDBNull(1) ? "" : data.GetString(1));
                        cliente.NomeContacto = (data.IsDBNull(2) ? "" : data.GetString(2));
                        clientes.Add(cliente);
                    }
            }
            _connection.Close();
            return clientes;
        }

        public DataTable ListaEncomendasClientes(string id)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            DataTable result = new DataTable();

            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT Orders.CustomerID,Orders.OrderID, SUM(UnitPrice * Quantity) - SUM(UnitPrice * Quantity * Discount) AS 'Valor Total' "
                                + "FROM[Order Details],Orders "
                                + "where[Order Details].OrderID = Orders.OrderID and Orders.CustomerID = @a "
                                + "GROUP BY Orders.OrderID,Orders.CustomerID "
                                + "ORDER BY SUM(UnitPrice* Quantity)-SUM(UnitPrice * Quantity * Discount) DESC ";

            command.Parameters.AddWithValue("@a", id);
            command.Connection = _connection;
            result.Load(command.ExecuteReader());
            _connection.Close();
            return result;
        }
    }
}
