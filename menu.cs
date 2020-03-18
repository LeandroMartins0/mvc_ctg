using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace mvc_ctg2.Entities
{
    class menu
    {
        private operacoes MinhaOperacao;
        private dados MeusDados;

        public menu(operacoes o, dados d)
        {
            MinhaOperacao = o;
            MeusDados = d;
        }

        public void MostraMenu()
        {
            int opc = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("Sistema de Cadastro de Alunos");
                Console.WriteLine("=============================\n");

                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Alterar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Pesquisar");
                Console.WriteLine("5 - Listar");
                Console.WriteLine("6 - Ordenar");
                Console.WriteLine("7 - Salvar Dados em Arquivo XML");
                Console.WriteLine("8 - Ler Dados de Arquivo XML");
                Console.WriteLine("9 - Sair");

                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        MinhaOperacao.Inserir(MeusDados);
                        break;
                    case 2:
                        //Alterar
                        break;
                    case 3:
                        //Excluir
                        break;
                    case 4:
                        //Pesquisar
                        break;
                    case 5:
                        MinhaOperacao.ListarAlunos(MeusDados);
                        break;
                    case 6:
                        //Ordenar
                        break;
                    case 7:
                        //Salvar Dados em arquivo XML
                        Console.Write("\nSalvando arquivo XML...");
                        if (MinhaOperacao.SalvarXml(MeusDados) == true)
                            Console.WriteLine("\nArquivo salvo com sucesso!");
                        else
                            Console.WriteLine("fail");
                        Thread.Sleep(2000);
                        break;
                    case 8:
                        //Ler Dados de XML
                        break;
                    case 9:
                        Console.Write("\nSaída do Sistema");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.Write("\nOpção inválida!!!");
                        Thread.Sleep(2000);
                        break;
                }

            } while (opc != 9);

        }

    }
}
