using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvc_ctg2.Entities;

namespace mvc_ctg2
{
    class Program
    {
        static void Main(string[] args)
        {
            menu MeuMenu = new menu(new operacoes(), new dados());

            MeuMenu.MostraMenu();
        }
    }
}
