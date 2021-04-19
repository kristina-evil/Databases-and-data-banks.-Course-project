using AccountingMaterials.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Domain.Abstractions.Repositories
{
    public interface IUseInProductionRepository
    {
        public Task<IList<UseInProduction>> GetAll();
        public Task<UseInProduction> GetById(long id);
        public Task Add(UseInProduction useInProduction);
        public Task Delete(long id);
        public Task Save();
    }
}
