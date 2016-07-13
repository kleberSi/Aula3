using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            String cliente = "", produto = "";
            int opcao, operacao;
            ArrayList ListPrd = new ArrayList();
            List<string> ListCli = new List<string>();
  
            do
            {
                Console.Clear();
                Console.WriteLine("1- Cliente");
                Console.WriteLine("2- Produto");
                Console.WriteLine("3- Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("       Clientes");
                        Console.WriteLine("1- Cadastrar Cliente");
                        Console.WriteLine("2- Consultar Cliente");
                        Console.WriteLine("3- Consultar Cliente por Nome");
                        Console.WriteLine("4- Remover Cliente pelo Nome");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("        Produto");
                        Console.WriteLine("1- Cadastrar Produto");
                        Console.WriteLine("2- Consultar Produto");
                        Console.WriteLine("3- Consultar Produto por Nome");
                        Console.WriteLine("4- Remover Produto pelo Nome:");

                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }
                if ((opcao.Equals(1)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.Clear();
                        Console.Write("Informe o nome:");
                        cliente = Console.ReadLine();
                        ListCli.Add(cliente);
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                        Console.ReadKey();
                    }
                    else if ((operacao.Equals(2)))
                    {
                        Console.Clear();
                        foreach (var item in ListCli)
                        {
                            Console.WriteLine("Nome do Cliente: " + item);

                        }
                        Console.ReadKey();
                    }
                    else if ((operacao.Equals(3))){
                    
                        Console.Clear();
                        Console.WriteLine(" Informe o nome que deseja pesquisar: ");
                        String nomeAux = Console.ReadLine();
                        foreach (var item in ListCli)
                        {
                            if (item.Equals(nomeAux))
                            {
                                Console.WriteLine(" Achei {0}!", item);
                            }
                            Console.ReadKey();
                        }
                    }
                    else if (operacao.Equals(4))
                    {
                        Console.Write(" Insira o nome que deseja remover: ");
                        String nomeAux = Console.ReadLine();
                        bool removeu = ListCli.Remove(nomeAux);
                        if (removeu)
                        {
                            Console.WriteLine("Nome removido com sucesso!");
                            Console.ReadKey();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }

                }
                else if ((opcao.Equals(2)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.Clear();
                        Console.Write(" Informe  o nome: ");
                        produto = Console.ReadLine();
                        ListPrd.Add(produto);
                        Console.WriteLine("Produto cadastrado com sucesso!");
                        Console.ReadKey();
                    }
                    else if ((operacao.Equals(2)))
                    {
                        Console.Clear();
                        foreach (var item in ListPrd)
                        {
                            Console.Write("Descrição: " + item);
                        }
                        Console.ReadKey();
                    }
                    else if (operacao.Equals(3))
                    {
                        Console.Clear();
                        Console.Write(" Informe o nome do produto que deseja pesquisar: ");
                        String descAux = Console.ReadLine();
                        foreach (var item in ListPrd)
                        {
                            if (item.Equals(descAux))
                               Console.WriteLine(" Achei {0}!", item);
                        }
                        Console.ReadKey();
                    }
                    else if (operacao.Equals(4))
                    {
                        Console.Write(" Insira o nome do produto que desejar remover: ");
                        String descAux = Console.ReadLine();
                        foreach (var item in ListPrd)
                        {
                            if (item.Equals(descAux))
                            {
                                ListPrd.Remove(item);
                                Console.WriteLine(" Produto Removido com sucesso!");
                                break;
                            }
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }  
            } while (opcao != 3);
        }

    }
}
