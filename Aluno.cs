using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroParaAlunos
{
    internal class Aluno
    {
        public String Nome { get; set; }
        public int Matricula { get; set; }
        public static HashSet<int> Matriculas = new HashSet<int>();
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }


        public double Media => (Nota1 + Nota2) / 2;


        public Aluno(string nome, int matricula, double nota1, double nota2)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            Matriculas.Add(matricula);
        }
    }
}
