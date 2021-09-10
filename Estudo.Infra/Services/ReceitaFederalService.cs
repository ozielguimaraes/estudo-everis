using Estudo.Dominio.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Infra.Services
{
    public class ReceitaFederalService : IReceitaFederalService
    {
        public async Task<bool> PessoaValidaAsync(string nome, string cpf)
        {
            await Task.Delay(2000);

            return nome.Split(' ').Length > 1;
        }
    }
}
