using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhasClasses;

namespace TesteClasses_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Editora te = new Editora("MikEdits");
            GeneroLivro tg = new GeneroLivro("Drama");
            Livro tl = new Livro("teste","Lusiadas",tg,DateTime.Today,te);
            Console.WriteLine(tl.ImprimeDados());
            List<Editora> le = new List<Editora>();
            for (int i = 0; i < 5; i++)
                le.Add(new Editora("MikEdits" + i));
            Autor ta = new Autor("Eu",le);
            Console.WriteLine(ta.ImprimeDados());
            Console.ReadKey();
        }
    }
}
