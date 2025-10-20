using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroParaAlunos
{
    internal abstract class Cadastro
    {
        public static List<Aluno> alunos;

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
