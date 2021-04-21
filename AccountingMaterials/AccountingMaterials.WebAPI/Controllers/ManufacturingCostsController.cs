using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.WebAPI.Controllers
{
    [Route("api/ManufacturingCosts")]
    [ApiController]
    public class ManufacturingCostsController : Controller
    {
        private readonly IManufacturingCostsRepository manufacturingCostsRepository;

        public ManufacturingCostsController(IManufacturingCostsRepository manufacturingCostsRepository)
        {
            this.manufacturingCostsRepository = manufacturingCostsRepository ?? throw new ArgumentNullException(nameof(manufacturingCostsRepository));
        }

        [HttpGet]
        public async Task<IList<ManufacturingCost>> GetAll()
        {
            return await this.manufacturingCostsRepository.GetAll();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ManufacturingCost>> GetById([FromRoute] long id)
        {
            return this.Ok(await this.manufacturingCostsRepository.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] ManufacturingCost manufacturingCost)
        {
            await this.manufacturingCostsRepository.Add(manufacturingCost);
        }

        [HttpDelete("{id:long}")]
        public async Task Delete([FromRoute] long id)
        {
            await this.manufacturingCostsRepository.Delete(id);
        }
    }
}
