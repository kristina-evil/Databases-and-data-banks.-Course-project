using AccountingMaterials.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Domain.Abstractions.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<IList<Employee>> GetAll();
        public Task<Employee> GetById(long id);
        public Task Add(Employee employee);
        public Task Update(long id, Employee employee);
        public Task Delete(long id);
    }
}
