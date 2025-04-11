using Domain.Contracts;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistance.Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repository
{
    public class GenericRepository<TEntity, Tkey> : IGenericRepository<TEntity, Tkey> where TEntity : BaseEntity<Tkey>
    {
        private readonly StoreDbContext _context;

        public GenericRepository(StoreDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(bool trackchanges = false)
        {

           return trackchanges?
                await _context.Set<TEntity>().ToListAsync()
               :await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetAsync(Tkey id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
  
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
         }
    }
}
