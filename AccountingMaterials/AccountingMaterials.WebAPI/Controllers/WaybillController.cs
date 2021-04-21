using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.WebAPI.Controllers
{
    [Route("api/Waybill")]
    [ApiController]
    public class WaybillController : Controller
    {
        private readonly IWaybillRepository waybillRepository;

        public WaybillController(IWaybillRepository waybillRepository)
        {
            this.waybillRepository = waybillRepository ?? throw new ArgumentNullException(nameof(waybillRepository));
        }

        [HttpGet]
        public async Task<IList<Waybill>> GetAll()
        {
            return await this.waybillRepository.GetAll();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Waybill>> GetById([FromRoute] long id)
        {
            return this.Ok(await this.waybillRepository.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] Waybill waybill)
        {
            await this.waybillRepository.Add(waybill);
        }

        [HttpDelete("{id:long}")]
        public async Task Delete([FromRoute] long id)
        {
            await this.waybillRepository.Delete(id);
        }
    }
}
