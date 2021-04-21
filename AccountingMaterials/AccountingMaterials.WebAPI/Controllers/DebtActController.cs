using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.WebAPI.Controllers
{
    [Route("api/DebtAct")]
    [ApiController]
    public class DebtActController : Controller
    {
        private readonly IDebtActRepository debtActRepository;

        public DebtActController(IDebtActRepository debtActRepository)
        {
            this.debtActRepository = debtActRepository ?? throw new ArgumentNullException(nameof(debtActRepository));
        }

        [HttpGet]
        public async Task<IList<DebtAct>> GetAll()
        {
            return await this.debtActRepository.GetAll();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<DebtAct>> GetById([FromRoute] long id)
        {
            return this.Ok(await this.debtActRepository.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] DebtAct debtAct)
        {
            await this.debtActRepository.Add(debtAct);
        }

        [HttpDelete("{id:long}")]
        public async Task Delete([FromRoute] long id)
        {
            await this.debtActRepository.Delete(id);
        }
    }
}
