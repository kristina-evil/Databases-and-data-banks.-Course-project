using AccountingMaterials.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Domain.Abstractions.Repositories
{
    public interface IMaterialsRepository
    {
        public Task<IList<Materials>> GetAll();
        public Task<Materials> GetById(long id);
        public Task Add(Materials materials);
        public Task Update(long id, Materials materials);
        public Task Delete(long id);
        public Task Save();
    }
}
