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
        private static Log _log = new Log($"seeds/seed.txt");
        
        public static bool Create()
        {
            Comunicacoes.AddTipo("Telefone");
            Comunicacoes.AddTipo("Email");
            Comunicacoes.AddTipo("Fax");
            Comunicacoes.AddTipo("Pager");
            for (int i = 0; i < 6; i++)
                Comunicacoes.AddTipo($"teste comunicacao tipo #{i + 1}");

            for (int i = 0; i < 10; i++)
            {
                Conta teste = new Conta();
                teste.User = $"teste{i+1}";
                teste.Nome = $"Nome Teste{i+1}";
                teste.Password = "123+qwe";
                teste.save();
                _log.EscreverLog($"Conta {teste.User} concluida");
            }

            foreach(Conta c in Contas.all())
            {
                for (int i = 0; i < 10; i++)
                {
                    Contacto t = new Contacto(c);
                    t.Nome = $"Contacto do {c.User} #{i+1}";
                    t.Nif = _random.Next(100000000, 999999999);
                    t.Morada = $"Rua dos sins {i}";
                    t.Publico = i>=5;
                    t.Titulo = $"Mestre dos testes {i}";
                    t.AdicionarComunicacao("Telefone", _random.Next(910000000, 919999999).ToString());
                    t.AdicionarComunicacao("Email", $"{t.Nome.Replace(' ','_')}@gmail.com");

                    for(int y = 0;y<5;y++)
                    {
                        t.AdicionarEmpresa($"Testes Inc. {y}");
                        t.AdicionarComunicacao($"teste comunicacao tipo #{i + 1}", $"Teste comunicacao {y}");
                    }
                    t.save(c);
                    _log.EscreverLog($"Contacto {t.Nome} concluido");
                }
            }
            return true;
        }
    }
}
