using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroParaAlunos
{
    internal abstract class Cadastro
    {
        
        private static List<Aluno> alunos = new List<Aluno>();
        public static List<Aluno> Alunos
        {
            get{ return alunos; }
        }


        //public Cadastro(List<Aluno> alunos)
        //{
        //    alunos = new List<Aluno> ();
        //}


        public static void Cadastrar(Aluno aluno)
        {
            alunos.Add(aluno);
        }
    }
}
