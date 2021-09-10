using Estudo.Dominio.Entities;
using Estudo.Dominio.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody]ClienteVm viewModel)
        {
            var model = new Cliente(viewModel.Nome, viewModel.Email, viewModel.Cpf);
            return Ok(await clienteService.Adicionar(model));
        }

        [HttpGet]
        [Route("{search:alpha}")]
        public async Task<IActionResult> Pesquisar(string search)
        {
            return Ok(await clienteService.Pesquisar(search));
        }
    }
}
