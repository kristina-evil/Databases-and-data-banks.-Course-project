using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Infrastructure.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext dataContext;

        public EmployeeRepository(DataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<Employee>> GetAll()
        {
            return await this.dataContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(long id)
        {
            return await this.dataContext.Employees.FindAsync(id);
        }

        public async Task Add(Employee employee)
        {
            this.dataContext.Employees.Add(employee);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this.dataContext.Employees.Remove(this.dataContext.Employees.Find(id));
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Update(long id, Employee employee)
        {
            var person = this.dataContext.Employees.Find(id);
            person.Position = employee.Position;
            await this.dataContext.SaveChangesAsync();
        }
    }
}
