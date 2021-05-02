using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.WebAPI.Controllers
{
    [Route("api/Employees")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        [HttpGet]
        public async Task<IList<Employee>> GetAll()
        {
            return await this.employeeRepository.GetAll();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Employee>> GetById([FromRoute] long id)
        {
            return this.Ok(await this.employeeRepository.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] Employee employee)
        {
            await this.employeeRepository.Add(employee);
        }

        [HttpPut]
        public async Task Put(Employee employee)
        {
            await this.employeeRepository.Update(employee);
        }

        [HttpDelete("{id:long}")]
        public async Task Delete([FromRoute] long id)
        {
            await this.employeeRepository.Delete(id);
        }
    }
}
