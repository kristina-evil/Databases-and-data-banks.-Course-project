using AccountingMaterials.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Domain.Abstractions.Repositories
{
    public interface IWaybillRepository
    {
        public Task<IList<Waybill>> GetAll();
        public Task<Waybill> GetById(long id);
        public Task Add(Waybill waybill);
        public Task Delete(long id);
    }
}
