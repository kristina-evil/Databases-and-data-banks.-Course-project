using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.WebAPI.Controllers
{
    [Route("api/Timecard")]
    [ApiController]
    public class TimecardController : Controller
    {
        private readonly ITimecardRepository timecardRepository;

        public TimecardController(ITimecardRepository timecardRepository)
        {
            this.timecardRepository = timecardRepository ?? throw new ArgumentNullException(nameof(timecardRepository));
        }

        [HttpGet]
        public async Task<IList<Timecards>> GetAll()
        {
            return await this.timecardRepository.GetAll();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Timecards>> GetById([FromRoute] long id)
        {
            return this.Ok(await this.timecardRepository.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] Timecards timecards)
        {
            await this.timecardRepository.Add(timecards);
        }

        [HttpDelete("{id:long}")]
        public async Task Delete([FromRoute] long id)
        {
            await this.timecardRepository.Delete(id);
        }
    }
}
