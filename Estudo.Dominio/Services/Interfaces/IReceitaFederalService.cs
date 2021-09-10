using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Dominio.Services.Interfaces
{
   public interface IReceitaFederalService
    {
        Task<bool> PessoaValidaAsync(string nome, string cpf);
    }
}
