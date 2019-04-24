using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public static class Contactos
    {
        private static DAL _dal = new DAL("Contato");

        public static List<Contacto> All()
        {
            List<Contacto> contactos = new List<Contacto>();


            OleDbDataReader data = _dal.get("id,nome,titulo,morada,nif,criador,data_criado,publico");
            if (data.HasRows)
            {
                while (data.Read())
                {
                        string id = data.GetString(0);
                        contactos.Add(new Contacto(id,
                                                   data.GetString(1),
                                                   data.GetString(2),
                                                   data.GetString(3),
                                                   data.GetInt32(4),
                                                   Contas.FindByUser(data.GetString(5)),
                                                   data.GetDateTime(6),
                                                   data.GetBoolean(7),
                                                   Comunicacoes.FindById(id),
                                                   Empresas.FindById(id))
                            );
                }
                data.Close();
            }
            return contactos;
        }

        public static List<Contacto> All(Conta c)
        {
            List<Contacto> contactos = new List<Contacto>();


            OleDbDataReader data = _dal.find("id,nome,titulo,morada,nif,criador,data_criado,publico",$"where criador='{c.User}' and publico=false");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    string id = data.GetString(0);
                    contactos.Add(new Contacto(id,
                                               data.GetString(1),
                                               data.GetString(2),
                                               data.GetString(3),
                                               data.GetInt32(4),
                                               Contas.FindByUser(data.GetString(5)),
                                               data.GetDateTime(6),
                                               data.GetBoolean(7),
                                               Comunicacoes.FindById(id),
                                               Empresas.FindById(id))
                        );
                }
                data.Close();
            }
            data = _dal.find("id,nome,titulo,morada,nif,criador,data_criado,publico", $"where publico=true");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    string id = data.GetString(0);
                    contactos.Add(new Contacto(id,
                                               data.GetString(1),
                                               data.GetString(2),
                                               data.GetString(3),
                                               data.GetInt32(4),
                                               Contas.FindByUser(data.GetString(5)),
                                               data.GetDateTime(6),
                                               data.GetBoolean(7),
                                               Comunicacoes.FindById(id),
                                               Empresas.FindById(id))
                        );
                }
            }
            return contactos;
        }

        public static bool Existe(string id)
        {
            return _dal.exists($"where id='{id}'");
        }

    }
}
