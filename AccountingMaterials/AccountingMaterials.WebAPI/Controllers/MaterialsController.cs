using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.WebAPI.Controllers
{
    [Route("api/Materials")]
    [ApiController]
    public class MaterialsController : Controller
    {
        private readonly IMaterialsRepository materialsRepository;

        public MaterialsController(IMaterialsRepository materialsRepository)
        {
            this.materialsRepository = materialsRepository ?? throw new ArgumentNullException(nameof(materialsRepository));
        }

        [HttpGet]
        public async Task<IList<Materials>> GetAll()
        {
            return await this.materialsRepository.GetAll();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Materials>> GetById([FromRoute] long id)
        {
            return this.Ok(await this.materialsRepository.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] Materials materials)
        {
            await this.materialsRepository.Add(materials);
        }

        [HttpPut("{id:long}")]
        public async Task Put([FromRoute] long id, [FromBody] Materials materials)
        {
            await this.materialsRepository.Update(id, materials);
        }

        [HttpDelete("{id:long}")]
        public async Task Delete([FromRoute] long id)
        {
            await this.materialsRepository.Delete(id);
        }
    }
}
