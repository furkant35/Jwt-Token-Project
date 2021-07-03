using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YSKProje.UdemyJwtProje.DataAccess.Concrete.EntityFrameworkCore.Context;
using YSKProje.UdemyJwtProje.DataAccess.Interfaces;
using YSKProje.UdemyJwtProje.Entities.Interfaces;

namespace YSKProje.UdemyJwtProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        public async Task Add(TEntity entity)
        {
            using var context = new UdemyJwtContext();
            context.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            using var context = new UdemyJwtContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new UdemyJwtContext();
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task<TEntity> GetById(int id)
        {
            using var context = new UdemyJwtContext();
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GettAllByFilter(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new UdemyJwtContext();
            return await context.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task Remove(TEntity entity)
        {
            using var context = new UdemyJwtContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            using var context = new UdemyJwtContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
