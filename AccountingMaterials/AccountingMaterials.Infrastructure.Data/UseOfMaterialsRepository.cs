using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Infrastructure.Data
{
    public class UseOfMaterialsRepository : IUseOfMaterialsRepository
    {
        private readonly DataContext dataContext;

        public UseOfMaterialsRepository(DataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<UseOfMatrials>> GetAll()
        {
            return await this.dataContext.UseOfMatrials.ToListAsync();
        }

        public async Task<UseOfMatrials> GetById(long id)
        {
            return await this.dataContext.UseOfMatrials.FindAsync(id);
        }

        public async Task Add(UseOfMatrials useOfMatrials)
        {
            this.dataContext.UseOfMatrials.Add(useOfMatrials);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this.dataContext.UseOfMatrials.Remove(this.dataContext.UseOfMatrials.Find(id));
            await this.dataContext.SaveChangesAsync();
        }
    }
}
