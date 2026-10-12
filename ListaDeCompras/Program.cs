using System;
using System.IO;
using System.Collections.Generic;

namespace ListaDeCompras
{
    public class Program
                    {
        public static void Main(string[] args)
        {
            //1 Estrutura

            string path = @"C:\Users\Admin\Desktop";   
            string filename = "Lista.txt";
            string fullPath = path + filename;

            string separador = ("");

            List<string> listaDeCompras = new List<string>();

            //2 Logica

            if (File.Exists(fullPath))
            {
                listaDeCompras.AddRange(File.ReadAllLines(fullPath));
            }

            while (true)
            {
                Console.WriteLine(separador);
                Console.WriteLine("Lista de compras:");
                Console.WriteLine("1. Adicionar item");
                Console.WriteLine("2. Remover item");
                Console.WriteLine("3. Exibir lista");
                Console.WriteLine("4. Sair");
                Console.WriteLine(separador);

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o item a ser adicionado:");
                        string itemAdicionar = Console.ReadLine();
                        listaDeCompras.Add(itemAdicionar);
                        break;
                    case "2":
                        Console.WriteLine("Digite o item a ser removido:");
                        string itemRemover = Console.ReadLine();
                        listaDeCompras.Remove(itemRemover);
                        break;
                    case "3":
                        Console.WriteLine("Itens na lista de compras:");
                        foreach (string item in listaDeCompras)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "4":
                        File.WriteAllLines(fullPath, listaDeCompras);
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}