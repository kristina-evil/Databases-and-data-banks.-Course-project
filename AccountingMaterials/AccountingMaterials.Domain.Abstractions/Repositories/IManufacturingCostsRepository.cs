using AccountingMaterials.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Domain.Abstractions.Repositories
{
    public interface IManufacturingCostsRepository
    {
        public Task<IList<ManufacturingCost>> GetAll();
        public Task<ManufacturingCost> GetById(long id);
        public Task Add(ManufacturingCost manufacturingCost);
        public Task Update(long id, ManufacturingCost manufacturingCost);
        public Task Delete(long id);
        public Task Save();
    }
}
