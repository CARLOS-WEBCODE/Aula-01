using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//define a localização da classe
namespace ProjetoAula01.Entities
{
    //definição da class
    public class Cliente
    {
        //propriedades da classe (campos)
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}