using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Infrastructure.Data
{
    public class RequimentActRepository : IRequimentActRepository
    {
        private readonly DataContext dataContext;

        public RequimentActRepository(DataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<RequiementAct>> GetAll()
        {
            return await this.dataContext.RequiementActs.ToListAsync();
        }

        public async Task<RequiementAct> GetById(long id)
        {
            return await this.dataContext.RequiementActs.FindAsync(id);
        }

        public async Task Add(RequiementAct requiementAct)
        {
            this.dataContext.RequiementActs.Add(requiementAct);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this.dataContext.RequiementActs.Remove(this.dataContext.RequiementActs.Find(id));
            await this.dataContext.SaveChangesAsync();
        }
    }
}
