using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Infrastructure.Data
{
    public class DebtActRepository : IDebtActRepository
    {
        private readonly DataContext dataContext;

        public DebtActRepository(DataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<DebtAct>> GetAll()
        {
            return await this.dataContext.DebtActs.ToListAsync();
        }

        public async Task<DebtAct> GetById(long id)
        {
            return await this.dataContext.DebtActs.FindAsync(id);
        }

        public async Task Add(DebtAct debtAct)
        {
            this.dataContext.DebtActs.Add(debtAct);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this.dataContext.DebtActs.Remove(this.dataContext.DebtActs.Find(id));
            await this.dataContext.SaveChangesAsync();
        }
    }
}
