using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.WebAPI.Controllers
{
    [Route("api/RequimentAct")]
    [ApiController]
    public class RequimentActController : Controller
    {
        private readonly IRequimentActRepository requimentActRepository;

        public RequimentActController(IRequimentActRepository requimentActRepository)
        {
            this.requimentActRepository = requimentActRepository ?? throw new ArgumentNullException(nameof(requimentActRepository));
        }

        [HttpGet]
        public async Task<IList<RequiementAct>> GetAll()
        {
            return await this.requimentActRepository.GetAll();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<RequiementAct>> GetById([FromRoute] long id)
        {
            return this.Ok(await this.requimentActRepository.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] RequiementAct requiementAct)
        {
            await this.requimentActRepository.Add(requiementAct);
        }

        [HttpDelete("{id:long}")]
        public async Task Delete([FromRoute] long id)
        {
            await this.requimentActRepository.Delete(id);
        }
    }
}
