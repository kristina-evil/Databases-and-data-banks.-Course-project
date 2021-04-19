using AccountingMaterials.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Domain.Abstractions.Repositories
{
    public interface IUnitRepository
    {
        public Task<IList<Unit>> GetAll();
        public Task<Unit> GetById(long id);
        public Task Add(Unit unit);
        public Task Update(long id, Unit unit);
        public Task Delete(long id);
        public Task Save();
    }
}
