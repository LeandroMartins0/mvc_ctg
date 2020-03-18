using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Xml;
using System.Threading.Tasks;

namespace mvc_ctg2.Entities
{
    class operacoes
    {
        public void Inserir(dados MeusDados)
        {
            do
            {
                aluno MeuAluno = new aluno();

                Console.Clear();

                Console.WriteLine("Cadastramento de Aluno");
                Console.WriteLine("======================\n");

                MeuAluno.Codigo = MeuAluno.GeraCodigo();
                Console.WriteLine("Código do Aluno: {0}", MeuAluno.Codigo);

                Console.Write("Nome: ");
                MeuAluno.Nome = Console.ReadLine();

                Console.Write("Telefone: ");
                MeuAluno.Telefone = Console.ReadLine();

                Console.Write("E-mail: ");
                MeuAluno.Mail = Console.ReadLine();

                MeusDados.InserirAluno(MeuAluno);

                Console.Write("Inserir outro registro? (ESC para Cancelar)");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public void ListarAlunos(dados MeusDados)
        {
            ArrayList lista;

            Console.Clear();

            Console.WriteLine("Listagem do Cadastro de Alunos");
            Console.WriteLine("==============================\n");

            lista = MeusDados.ListarAlunos();

            foreach (aluno x in lista)
            {
                Console.WriteLine("{0} ({1})", x.Nome, x.Codigo);
                Console.WriteLine("Telefone: {0}", x.Telefone);
                Console.WriteLine("E-mail: {0}\n", x.Mail);
            }

            Console.ReadKey();
        }

        public bool SalvarXml(dados MeusDados)
        {
            bool result = false;

            ArrayList lista;

            lista = MeusDados.ListarAlunos();

            string path = @"C:\server\cadastro_alunos.xml";

            using (XmlWriter escreve = XmlWriter.Create(path))
            {
                if (File.Exists(path))
                {
                    escreve.WriteStartDocument();
                    escreve.WriteStartElement("Codigo");

                    foreach (aluno x in lista)
                    {
                        escreve.WriteStartElement("Codigo", x.Codigo);
                        escreve.WriteElementString("Nome", x.Nome);
                        escreve.WriteElementString("Telefone", x.Telefone);
                        escreve.WriteElementString("E-mail", x.Mail);
                        escreve.WriteEndElement();
                    }
                    escreve.WriteEndElement();
                    escreve.WriteEndDocument();

                    result = true;
                }
                else
                {
                    Console.Write("A pasta não pôde ser criada!");

                    result = false;
                }
            }

            return result;
        }
    }
}
