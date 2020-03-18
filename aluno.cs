using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_ctg2.Entities
{
    class aluno
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Mail { get; set; }

        public string GeraCodigo()
        {
            string Result = string.Empty;

            Result = Guid.NewGuid().ToString("N").Substring(0, 5).ToUpper();

            return Result;
        }
    }
}
