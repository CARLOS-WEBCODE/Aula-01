using ProjetoAula01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//define a localização da classe dentro do projeto
namespace ProjetoAula01.Repositories
{
    //definição da classe
    public class ClienteRepository
    {
        //atributos privados
        private string _diretorio = "c:\\temp";
        private string _arquivo = "clientes.txt";

        //método construtor
        public ClienteRepository()
        {
            //verificando se a pasta não existe
            if ( ! Directory.Exists(_diretorio))
            {
                //criando a pasta na maquina do usuário - exclamação para negar
                Directory.CreateDirectory(_diretorio);
            }
        }

        //método para gravar os dados do cliente em um arquivo
        public void ExportarDados(Cliente cliente)
        {
            //abrindo um arquivo em modo de escrita
            var streamWriter = new StreamWriter(_diretorio + "\\" + _arquivo, true);

            //escrevendo os dados do cliente no arquivo
            streamWriter.WriteLine("ID DO CLIENTE......: " + cliente.IdCliente);
            streamWriter.WriteLine("NOME...............: " + cliente.Nome);
            streamWriter.WriteLine("EMAIL..............: " + cliente.Email);
            streamWriter.WriteLine("TELEFONE...........: " + cliente.Telefone);
            streamWriter.WriteLine("---");

            //salvando e fechando o arquivo
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
