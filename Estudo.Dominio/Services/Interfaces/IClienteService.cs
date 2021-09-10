using Estudo.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Dominio.Services.Interfaces
{
    public interface IClienteService
    {
        Task<bool> Adicionar(Cliente cliente);
        Task<IEnumerable<Cliente>> Pesquisar(string search);
    }
}
