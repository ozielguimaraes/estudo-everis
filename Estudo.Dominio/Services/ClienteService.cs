using Estudo.Dominio.Entities;
using Estudo.Dominio.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Dominio.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IReceitaFederalService receitaFederalService;

        public ClienteService(IReceitaFederalService receitaFederalService)
        {
            this.receitaFederalService = receitaFederalService;
        }

        public async Task<bool> Adicionar(Cliente cliente)
        {
            //adicionar validações FLUENTVALITATION**
            if(cliente.Nome is not null && cliente.Cpf is not null)
            {
                var pessoaValida = await receitaFederalService.PessoaValidaAsync(cliente.Nome, cliente.Cpf);
                if (pessoaValida)
                {
                    //ADICIONAR NO BANCO
                    //.....


                    return true;
                }
                else return false;
            }

            return false;
        }

        public async Task<IEnumerable<Cliente>> Pesquisar(string search)
        {
            await Task.Delay(1000);

            return new List<Cliente> {
                new Cliente("Fulano de tal", "mail@mail.com", "111.111.111-11"),
                new Cliente("Beltrano de tal", "maail@maaail.com", "222.111.111-11"),
                new Cliente("Fulano da Silva", "mail@maail.com", "123.111.111-11")
            };
        }
    }
}
