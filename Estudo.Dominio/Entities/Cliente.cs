using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Dominio.Entities
{
    public class Cliente
    {
        public Cliente(string nome, string email, string cpf)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        
        public string PrimeiroNome => Nome?.Split(' ').FirstOrDefault() ?? string.Empty;
    }
}
