using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace mvc_ctg2.Entities
{
    class dados
    {
        private ArrayList Cadastro;

        public dados()
        {
            Cadastro = new ArrayList();
        }

        public void InserirAluno(aluno x)
        {
            Cadastro.Add(x);
        }

        public ArrayList ListarAlunos()
        {
            return Cadastro;
        }

    }
}
