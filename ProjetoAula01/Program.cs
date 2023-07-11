using ProjetoAula01.Entities;
using ProjetoAula01.Repositories;
using System;

//define a localização da classe dentro do projeto
namespace ProjetoAula01
{
    //definição da classe
    class Program
    {
        //método (funções) para executar o projeto
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** AULA 01 - C# WEBDEVELOPER ***\n");
            //criando um objeto para a classe Cliente (variável de instância)
            var cliente = new Cliente();

            //acessando as propriedades da Classe...
            cliente.IdCliente = Guid.NewGuid();

            Console.Write("Informe o nome do cliente......: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Informe o email do cliente.....: ");
            cliente.Email = Console.ReadLine();

            Console.Write("Informe o telefone do cliente..: ");
            cliente.Telefone = Console.ReadLine();

            //imprimir os dados do cliente no console
            Console.WriteLine("\nDADOS DO CLIENTE:\n");
            Console.WriteLine("\tID......: " + cliente.IdCliente);
            Console.WriteLine("\tNOME....: " + cliente.Nome);
            Console.WriteLine("\tEMAIL...: " + cliente.Email);
            Console.WriteLine("\tTELEFONE: " + cliente.Telefone);

            try //tentativa
            {
                //criando um objeto para a classe ClienteRepository
                var clienteRepository = new ClienteRepository();

                //executar a gravação do arquivo
                clienteRepository.ExportarDados(cliente);

                //imprimir mensagem de sucesso
                Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");
            }
            catch(Exception e) //captura da exceção
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }

            //pausar prompt
            Console.ReadKey();
        }
    }
}
