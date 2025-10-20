using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroParaAlunos
{
    internal class Aluno
    {
        public String nome { get; set; }
        public int matricula { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double Media => (nota1 + nota2) / 2;
    }
}
