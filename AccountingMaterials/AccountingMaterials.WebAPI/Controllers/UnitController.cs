using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.WebAPI.Controllers
{
    [Route("api/Unit")]
    [ApiController]
    public class UnitController : Controller
    {
        private readonly IUnitRepository unitRepository;

        public UnitController(IUnitRepository unitRepository)
        {
            this.unitRepository = unitRepository ?? throw new ArgumentNullException(nameof(unitRepository));
        }

        [HttpGet]
        public async Task<IList<Unit>> GetAll()
        {
            return await this.unitRepository.GetAll();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Unit>> GetById([FromRoute] long id)
        {
            return this.Ok(await this.unitRepository.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] Unit unit)
        {
            await this.unitRepository.Add(unit);
        }

        [HttpDelete("{id:long}")]
        public async Task Delete([FromRoute] long id)
        {
            await this.unitRepository.Delete(id);
        }
    }
}
