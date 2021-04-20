using AccountingMaterials.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Domain.Abstractions.Repositories
{
    public interface ITimecardRepository
    {
        public Task<IList<Timecards>> GetAll();
        public Task<Timecards> GetById(long id);
        public Task Add(Timecards timecards);
        public Task Delete(long id);
    }
}
