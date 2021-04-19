using AccountingMaterials.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AccountingMaterials.Domain.Abstractions.Repositories
{
    public interface IRequirementInvoiceRepository
    {
        public Task<IList<RequirementInvoice>> GetAll();
        public Task<RequirementInvoice> GetById(long id);
        public Task Add(RequirementInvoice requirementInvoice);
        public Task Delete(long id);
        public Task Save();
    }
}
