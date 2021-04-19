using AccountingMaterials.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Domain.Abstractions.Repositories
{
    public interface IRequimentActRepository
    {
        public Task<IList<RequiementAct>> GetAll();
        public Task<RequiementAct> GetById(long id);
        public Task Add(RequiementAct requiementAct);
        public Task Delete(long id);
        public Task Save();
    }
}
