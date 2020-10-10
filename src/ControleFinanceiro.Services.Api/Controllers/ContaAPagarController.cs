using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Services.Api.Controllers
{
    public class ContaAPagarController : BaseApiController
    {
        private readonly IContaAPagarAppService _contaAPagarAppService;

        public ContaAPagarController(IContaAPagarAppService contaAPagarAppService)
        {
            _contaAPagarAppService = contaAPagarAppService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<ContaAPagarViewModel>>> GetAllAsync()
        {
            return Ok(await _contaAPagarAppService.GetAllAsync());
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(ContaAPagarInsertViewModel contaAPagar)
        {
            return Ok(await _contaAPagarAppService.CreateAsync(contaAPagar));
        }
    }
}
