using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Turma
    {
        public int ID { get; set; }
        public List<Aluno> Alunos { get; set; }
    }

    public class Aluno
    {
        public string Nome { get; set; }
        public int Altura { get; set; }
    }
}
