using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Infrastructure.Data
{
    public class RequirementInvoiceRepository : IRequirementInvoiceRepository
    {
        private readonly DataContext dataContext;

        public RequirementInvoiceRepository(DataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<RequirementInvoice>> GetAll()
        {
            return await this.dataContext.RequirementInvoices.ToListAsync();
        }

        public async Task<RequirementInvoice> GetById(long id)
        {
            return await this.dataContext.RequirementInvoices.FindAsync(id);
        }

        public async Task Add(RequirementInvoice requirementInvoice)
        {
            this.dataContext.RequirementInvoices.Add(requirementInvoice);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this.dataContext.RequirementInvoices.Remove(this.dataContext.RequirementInvoices.Find(id));
            await this.dataContext.SaveChangesAsync();
        }
    }
}
