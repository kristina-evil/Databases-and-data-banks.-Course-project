using AccountingMaterials.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Domain.Abstractions.Repositories
{
    public interface IUseOfMaterials
    {
        public Task<IList<UseOfMatrials>> GetAll();
        public Task<UseOfMatrials> GetById(long id);
        public Task Add(UseOfMatrials useOfMatrials);
        public Task Delete(long id);
        public Task Save();
    }
}
