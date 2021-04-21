using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.WebAPI.Controllers
{
    [Route("api/UseOfMaterials")]
    [ApiController]
    public class UseOfMaterialsController : Controller
    {
        private readonly IUseOfMaterialsRepository useOfMaterialsRepository;

        public UseOfMaterialsController(IUseOfMaterialsRepository useOfMaterialsRepository)
        {
            this.useOfMaterialsRepository = useOfMaterialsRepository ?? throw new ArgumentNullException(nameof(useOfMaterialsRepository));
        }

        [HttpGet]
        public async Task<IList<UseOfMatrials>> GetAll()
        {
            return await this.useOfMaterialsRepository.GetAll();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UseOfMatrials>> GetById([FromRoute] long id)
        {
            return this.Ok(await this.useOfMaterialsRepository.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] UseOfMatrials useOfMatrials)
        {
            await this.useOfMaterialsRepository.Add(useOfMatrials);
        }

        [HttpDelete("{id:long}")]
        public async Task Delete([FromRoute] long id)
        {
            await this.useOfMaterialsRepository.Delete(id);
        }
    }
}
