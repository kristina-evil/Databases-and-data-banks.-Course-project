using AccountingMaterials.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Domain.Abstractions.Repositories
{
    public interface IDebtActRepository
    {
        public Task<IList<DebtAct>> GetAll();
        public Task<DebtAct> GetById(long id);
        public Task Add(DebtAct debtAct);
        public Task Delete(long id);
    }
}
