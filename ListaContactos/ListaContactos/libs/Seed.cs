using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public static class Seed
    {
        private static Random _random = new Random();
        
        public static void Create()
        {
            for (int i = 0; i < 10; i++)
            {
                Comunicacoes.AddTipo($"teste tipo #{i + 1}");
                Conta teste = new Conta();
                teste.User = $"teste{i+1}";
                teste.Nome = $"Nome Teste{i+1}";
                teste.Password = "123+qwe";
                teste.save();
            }

            for (int i = 0; i < 10; i++)
            {
                foreach(Conta c in Contas.all())
                {
                    Contacto t = new Contacto(c);
                    t.Nome = $"Contacto do {c.User}";
                    t.Nif = _random.Next(100000000, 999999999);
                    t.Morada = $"Rua dos sins {i}";
                    t.Publico = i > 5;
                    t.Titulo = $"Mestre dos testes {i}";

                    t.AdicionarEmpresa($"Testes Inc. {i}");
                    t.AdicionarComunicacao($"teste{1}", $"Teste comunicacao {i}");
                    t.save(c);
                }
            }
        }
    }
}
