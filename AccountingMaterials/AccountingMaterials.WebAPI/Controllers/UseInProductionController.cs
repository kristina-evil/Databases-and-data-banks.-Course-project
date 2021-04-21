using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.WebAPI.Controllers
{
    [Route("api/UseInProduction")]
    [ApiController]
    public class UseInProductionController : Controller
    {
        private readonly IUseInProductionRepository useInProductionRepository;

        public UseInProductionController(IUseInProductionRepository useInProductionRepository)
        {
            this.useInProductionRepository = useInProductionRepository ?? throw new ArgumentNullException(nameof(useInProductionRepository));
        }

        [HttpGet]
        public async Task<IList<UseInProduction>> GetAll()
        {
            return await this.useInProductionRepository.GetAll();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UseInProduction>> GetById([FromRoute] long id)
        {
            return this.Ok(await this.useInProductionRepository.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] UseInProduction useInProduction)
        {
            await this.useInProductionRepository.Add(useInProduction);
        }

        [HttpDelete("{id:long}")]
        public async Task Delete([FromRoute] long id)
        {
            await this.useInProductionRepository.Delete(id);
        }
    }
}
