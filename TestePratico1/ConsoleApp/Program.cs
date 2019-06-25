using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Testes()
        {
            //Teste para SomaValores
            //int[] teste = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(ClassLibrary.Class.SomaValores(teste, true));

            //Teste para DictTurmasToDatatable

            //Random r = new Random();

            //Dictionary<int, Dictionary<string, int>> turmas = new Dictionary<int, Dictionary<string, int>>();
            //for (int i = 1; i <= 10; i++)
            //{
            //    Dictionary<string, int> alunos = new Dictionary<string, int>();
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        alunos.Add($"Teste{j}", r.Next(150, 200));
            //    }
            //    turmas.Add(i, alunos);
            //}
            //DataTable result = ClassLibrary.Class.DictTurmasToDatatable(turmas);

            //List<ClassLibrary.Turma> turmas = new List<ClassLibrary.Turma>();
            //for (int i = 1; i <= 10; i++)
            //{
            //    List<ClassLibrary.Aluno> alunos = new List<ClassLibrary.Aluno>();
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        alunos.Add(new ClassLibrary.Aluno() {
            //            Nome= $"Teste{j}",
            //            Altura = r.Next(150, 200)
            //        });
            //    }
            //    turmas.Add(new ClassLibrary.Turma() { ID = i, Alunos = alunos });
            //}

            //DataTable result = ClassLibrary.Class.TurmasToDatatable(turmas);
            //foreach ( DataRow test in result.Rows)
            //{
            //    foreach(object x in test.ItemArray)
            //        Console.Write($" {x} ");
            //    Console.WriteLine("");
            //}

            //ClassLibrary.DAL dal = new ClassLibrary.DAL(Properties.Settings.Default.ConnectionString);
            //DataTable result = dal.ListaEncomendasClientes("ALFKI");
            //foreach (DataRow test in result.Rows)
            //{
            //    foreach (object x in test.ItemArray)
            //        Console.Write($" {x} ");
            //    Console.WriteLine("");
            //}




            Console.ReadKey();
        }

        public static int lerInt(int min=0,int max=int.MaxValue)
        {
            int i = 0;
            while (!int.TryParse(Console.ReadLine(), out i) || i<min || i>max)
            {
                Console.WriteLine("Erro. Tem de ser um numero.");
            }
            return i;
        }

        public static bool lerPar()
        {
            char c;
            do
            {
                c = Console.ReadKey().KeyChar;
                if (c != 'P' && c != 'p' && c != 'I' && c != 'i')
                    Console.WriteLine("Erro.");
            } while (c != 'P' && c != 'p' && c != 'I' && c != 'i');
            return c=='P'||c=='p';
        }

        static void Menu(int opc)
        {
            switch(opc)
            {
                case 1:
                    SomarNumeros();
                    break;
                case 2:
                    MostrarNome();
                    break;
                default:
                    return;
            }
        }

        private static void MostrarNome()
        {
            Console.Clear();
            Console.WriteLine("Escreva o seu id de cliente: ");
            ClassLibrary.DAL dal = new ClassLibrary.DAL(Properties.Settings.Default.ConnectionString);
            string id = Console.ReadLine();
            ClassLibrary.Cliente cliente = dal.ListaContactosClientes().FirstOrDefault(c => c.ID.StartsWith(id,StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine(
                (cliente == null ?
                        "Não conseguimos encontrar um cliente com esse ID" : $"Nome do contacto: {cliente.NomeContacto}"
                ));
            Console.ReadKey();
        }

        private static void SomarNumeros()
        {
            Console.Clear();
            Console.WriteLine("Quantos numeros pretende somar: ");
            int[] numeros = new int[lerInt(1)];
            for(int i=0;i<numeros.Length;i++)
            {
                Console.WriteLine($"Numero #{i+1}: ");
                numeros[i] = lerInt();
            }
            Console.WriteLine("Somar Par ou Impar? (P/I) ");
            Console.WriteLine($"\nResultado: {ClassLibrary.Class.SomaValores(numeros, lerPar())}");
            Console.WriteLine("\n\nClique para continuar...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //Testes();
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Somar Numeros");
                Console.WriteLine("2 - Mostrar Nome de Contacto");
                Console.WriteLine("\n\n0 - Sair");
                opc = lerInt();
                Menu(opc);
            } while (opc != 0);

            Environment.Exit(0);
        }
    }
}
