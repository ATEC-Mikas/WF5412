using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContactos
{
    public static class Seed
    {
        private static bool? _status=null;
        public static bool? Status { get { return _status; } }
        private static Random _random = new Random();
        private static Log _log = new Log($"seeds/seed.txt");

        private static string[] titulo = {"Sr.","Dr.","Sra.", "Dra.", "Eng."};
        private static string[] pnomes = 
        {
            "Maria",
            "Leonor",
            "Matilde",
            "Beatriz",
            "Carolina",
            "Mariana",
            "Ana",
            "Sofia",
            "Francisca",
            "Inês",
            "Santiago",
            "Francisco",
            "João",
            "Afonso",
            "Rodrigo",
            "Martim",
            "Tomás",
            "Duarte",
            "Miguel",
            "Gabriel"
        };
        private static string[] unomes =
        {
            "Silva",
            "Santos",
            "Ferreira",
            "Pereira",
            "Oliveira",
            "Costa",
            "Rodrigues",
            "Martins",
            "Jesus",
            "Sousa",
            "Fernandes",
            "Gonçalves",
            "Gomes",
            "Lopes",
            "Marques",
            "Alves",
            "Almeida",
            "Ribeiro",
            "Pinto",
            "Carvalho"
        };
        private static string[] empresa =
        {
            "Teste Architects",
            "Teste Wanted",
            "HappyHour Teste",
            "Teste Blogger",
            "Teste Service",
            "SilkRoad Teste",
            "Teste Easy",
            "Practical Teste",
            "Teste Cat",
            "Savage Teste",
            "Save Teste",
            "Canary Teste",
            "Teste Mentor",
            "Teste Breeze",
            "Teste Mob",
            "Brain Teste",
            "Teste Beat",
            "SweetWater Teste",
            "Teste Balance",
            "Teste Station",
            "Synapse Teste",
            "Make Teste",
            "Lighthouse Teste",
            "Teste Pop",
            "Zodiac Teste",
            "Teste Bear",
            "Charisma Teste",
            "President Teste",
            "Robot Teste",
            "Teste Fire",
            "Resolution Teste",
            "Teste Applications",
            "Spire Teste"
        };
        private static string[] tiposCom = {
                            "Telefone",
                            "Email",
                            "Fax",
                            "Pager"
        };
        private static string[] morada =
        {
            "Avenida dos Aliados",
            "Rua do Almada",
            "Avenida da Associação Empresarial de Portugal",
            "Rua da Bainharia",
            "Rua de Belomonte",
            "Avenida da Boavista",
            "Rua do Breiner",
            "Rua dos Caldeireiros",
            "Escadas do Caminho Novo",
            "Rua de Cândido dos Reis (Porto)",
            "Rua das Carmelitas",
            "Rua do Carvalhido",
            "Rua de Cedofeita",
            "Rua dos Clérigos",
            "Escadas do Codeçal",
            "Rua do Comércio do Porto",
            "Rua da Constituição",
            "Rua de Costa Cabral",
            "Rua de D. Hugo",
            "Rua Escura",
            "Rua das Flores (Porto)",
            "Alameda das Fontainhas",
            "Avenida da França",
            "Rua da Galeria de Paris",
            "Rua de José Falcão",
            "Rua do Major David Magno",
            "Avenida do Marechal Gomes da Costa (Porto)",
            "Rua dos Mercadores",
            "Rua de Miguel Bombarda",
            "Rua de Mota Pinto",
            "Rua de Mouzinho da Silveira",
            "Rua de Nove de Julho",
            "Rua de Passos Manuel",
            "Rua do Rosário",
            "Rua do Loureiro",
            "Rua de Sá da Bandeira",
            "Rua de Sant'Ana",
            "Rua de Santa Catarina",
            "Rua de São Bento da Vitória",
            "Rua de São Miguel (Porto)",
            "Rua de São Roque da Lameira",
            "Rua das Taipas (Porto)",
            "Rua de Trás",
            "Rua de Trinta e Um de Janeiro",
            "Escadas das Verdades"
        };

        private static string GetRandomPNome()
        {
            return pnomes[_random.Next(0, pnomes.Length - 1)];
        }
        private static string GetRandomUNome()
        {
            return unomes[_random.Next(0, unomes.Length - 1)];
        }
        private static string GetRandomTitulo()
        {
            return titulo[_random.Next(0, titulo.Length - 1)];
        }
        private static string GetRandomEmpresa()
        {
            return empresa[_random.Next(0, empresa.Length - 1)];
        }
        private static string GetRandomTipoCom()
        {
            return tiposCom[_random.Next(0, tiposCom.Length - 1)];
        }
        private static string GetRandomMorada()
        {
            return morada[_random.Next(0, morada.Length - 1)];
        }



        public static void Create()
        {
            _status = false;
            foreach (string s in tiposCom)
                Comunicacoes.AddTipo(s);

            for (int i = 0; i < 10; i++)
            {
                Conta teste = new Conta();
                teste.User = $"{GetRandomPNome()}{i+1}";
                teste.Nome = $"{GetRandomPNome()} {GetRandomUNome()}";
                teste.Password = "123";
                teste.save();
                _log.EscreverLog($"Conta {teste.User} concluida");
            }

            foreach(Conta c in Contas.all())
            {
                for (int i = 0; i < 10; i++)
                {
                    Contacto t = new Contacto(c);
                    t.Nome = $"{GetRandomPNome()} {GetRandomUNome()} #{i+1}";
                    t.Nif = _random.Next(100000000, 999999999);
                    t.Morada = $"{GetRandomMorada()} Nº{_random.Next(1, 40)} {_random.Next(1, 5).ToString()}º"+ (_random.Next(0,1)==0? "DTO" : "ESQ");
                    t.Publico = _random.Next(0, 1) == 0;
                    t.Titulo = GetRandomTitulo();
                    t.AdicionarComunicacao("Telefone", _random.Next(910000000, 919999999).ToString());
                    t.AdicionarComunicacao("Email", $"{t.Nome.Replace(' ','_')}@gmail.com");

                    for(int y = 0;y<6;y++)
                    {
                        t.AdicionarEmpresa($"{GetRandomEmpresa()} {y}");
                        t.AdicionarComunicacao(GetRandomTipoCom(), $"Teste Seed comunicacao {y}");
                    }
                    t.save(c);
                    _log.EscreverLog($"Contacto {t.Nome} concluido");
                }
            }
            _status = true;
        }
    }
}
