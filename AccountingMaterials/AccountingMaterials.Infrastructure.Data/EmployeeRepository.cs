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
        private readonly DataContext _dataContext;

        public EmployeeRepository(DataContext dataContext)
        {
            this._dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<Employee>> GetAll()
        {
            return await this._dataContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(long id)
        {
            return await this._dataContext.Employees.FindAsync(id);
        }

        public async Task Add(Employee employee)
        {
            this._dataContext.Employees.Add(employee);
            await this._dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this._dataContext.Employees.Remove(this._dataContext.Employees.Find(id));
            await this._dataContext.SaveChangesAsync();
        }

        public async Task Update(Employee employee)
        {
            await Task.Run(() => _dataContext.Employees.Attach(employee));
            
            _dataContext.Entry(employee).State = EntityState.Modified;
            
            await _dataContext.SaveChangesAsync();
        }
    }
}
