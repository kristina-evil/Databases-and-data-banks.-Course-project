using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Infrastructure.Data
{
    public class UnitRepository : IUnitRepository
    {
        private readonly DataContext dataContext;

        public UnitRepository(DataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<Unit>> GetAll()
        {
            return await this.dataContext.Units.ToListAsync();
        }

        public async Task<Unit> GetById(long id)
        {
            return await this.dataContext.Units.FindAsync(id);
        }

        public async Task Add(Unit unit)
        {
            this.dataContext.Units.Add(unit);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this.dataContext.Units.Remove(this.dataContext.Units.Find(id));
            await this.dataContext.SaveChangesAsync();
        }
    }
}
