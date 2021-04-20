using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Infrastructure.Data
{
    public class UseInProductionRepository : IUseInProductionRepository
    {
        private readonly DataContext dataContext;

        public UseInProductionRepository(DataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<UseInProduction>> GetAll()
        {
            return await this.dataContext.UseInProductions.ToListAsync();
        }

        public async Task<UseInProduction> GetById(long id)
        {
            return await this.dataContext.UseInProductions.FindAsync(id);
        }

        public async Task Add(UseInProduction useInProduction)
        {
            this.dataContext.UseInProductions.Add(useInProduction);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this.dataContext.UseInProductions.Remove(this.dataContext.UseInProductions.Find(id));
            await this.dataContext.SaveChangesAsync();
        }
    }
}
