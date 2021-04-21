using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.WebAPI.Controllers
{
    [Route("api/RequimentInvoice")]
    [ApiController]
    public class RequirementInvoiceController : Controller
    {
        private readonly IRequirementInvoiceRepository requirementInvoiceRepository;

        public RequirementInvoiceController(IRequirementInvoiceRepository requirementInvoiceRepository)
        {
            this.requirementInvoiceRepository = requirementInvoiceRepository ?? throw new ArgumentNullException(nameof(requirementInvoiceRepository));
        }

        [HttpGet]
        public async Task<IList<RequirementInvoice>> GetAll()
        {
            return await this.requirementInvoiceRepository.GetAll();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<RequirementInvoice>> GetById([FromRoute] long id)
        {
            return this.Ok(await this.requirementInvoiceRepository.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] RequirementInvoice requirementInvoice)
        {
            await this.requirementInvoiceRepository.Add(requirementInvoice);
        }

        [HttpDelete("{id:long}")]
        public async Task Delete([FromRoute] long id)
        {
            await this.requirementInvoiceRepository.Delete(id);
        }
    }
}
