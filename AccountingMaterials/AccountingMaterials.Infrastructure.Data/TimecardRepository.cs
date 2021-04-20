using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Infrastructure.Data
{
    public class TimecardRepository : ITimecardRepository
    {
        private readonly DataContext dataContext;

        public TimecardRepository(DataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<Timecards>> GetAll()
        {
            return await this.dataContext.Timecards.ToListAsync();
        }

        public async Task<Timecards> GetById(long id)
        {
            return await this.dataContext.Timecards.FindAsync(id);
        }

        public async Task Add(Timecards timecards)
        {
            this.dataContext.Timecards.Add(timecards);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this.dataContext.Timecards.Remove(this.dataContext.Timecards.Find(id));
            await this.dataContext.SaveChangesAsync();
        }
    }
}
