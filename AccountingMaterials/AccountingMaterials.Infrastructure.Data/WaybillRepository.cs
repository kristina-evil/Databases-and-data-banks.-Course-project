using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Infrastructure.Data
{
    public class WaybillRepository : IWaybillRepository
    {
        private readonly DataContext dataContext;

        public WaybillRepository(DataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<Waybill>> GetAll()
        {
            return await this.dataContext.Waybills.ToListAsync();
        }

        public async Task<Waybill> GetById(long id)
        {
            return await this.dataContext.Waybills.FindAsync(id);
        }

        public async Task Add(Waybill waybill)
        {
            this.dataContext.Waybills.Add(waybill);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this.dataContext.Waybills.Remove(this.dataContext.Waybills.Find(id));
            await this.dataContext.SaveChangesAsync();
        }
    }
}
