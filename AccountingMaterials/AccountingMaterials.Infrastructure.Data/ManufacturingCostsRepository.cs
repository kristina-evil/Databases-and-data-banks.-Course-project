using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Infrastructure.Data
{
    public class ManufacturingCostsRepository :IManufacturingCostsRepository
    {
        private readonly DataContext dataContext;

        public ManufacturingCostsRepository(DataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<ManufacturingCost>> GetAll()
        {
            return await this.dataContext.ManufacturingCosts.ToListAsync();
        }

        public async Task<ManufacturingCost> GetById(long id)
        {
            return await this.dataContext.ManufacturingCosts.FindAsync(id);
        }

        public async Task Add(ManufacturingCost manufacturing)
        {
            this.dataContext.ManufacturingCosts.Add(manufacturing);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this.dataContext.ManufacturingCosts.Remove(this.dataContext.ManufacturingCosts.Find(id));
            await this.dataContext.SaveChangesAsync();
        }
    }
}
