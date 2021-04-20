using AccountingMaterials.Domain.Abstractions.Repositories;
using AccountingMaterials.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingMaterials.Infrastructure.Data
{
    public class MaterialsRepository : IMaterialsRepository
    {
        private readonly DataContext dataContext;

        public MaterialsRepository(DataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<IList<Materials>> GetAll()
        {
            return await this.dataContext.Materials.ToListAsync();
        }

        public async Task<Materials> GetById(long id)
        {
            return await this.dataContext.Materials.FindAsync(id);
        }

        public async Task Add(Materials materials)
        {
            this.dataContext.Materials.Add(materials);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            this.dataContext.Materials.Remove(this.dataContext.Materials.Find(id));
            await this.dataContext.SaveChangesAsync();
        }

        public async Task Update(long id, Materials materials)
        {
            var material = this.dataContext.Materials.Find(id);
            material.Price = materials.Price;
            await this.dataContext.SaveChangesAsync();
        }
    }
}
