﻿using Domain.Contracts;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistance.Repositories
{
    public class GenericRepository<TEntity,TKey> : IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly StoreDbContext _context;

        public GenericRepository(StoreDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync(bool trackChanges = false)
        {
            if (typeof(TEntity) == typeof(Product))
            {
                return trackChanges ?
                  await _context.Products.Include(P=>P.ProductBrand).Include(P => P.ProductType).ToListAsync() as IEnumerable<TEntity>
                : await _context.Products.Include(P => P.ProductBrand).Include(P => P.ProductType).AsNoTracking().ToListAsync() as IEnumerable<TEntity>;
            }


           return trackChanges?
                  await _context.Set<TEntity>().ToListAsync()
                : await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(TKey id)
        {
            if (typeof(TEntity) == typeof(Product))
            {
                return await _context.Products.Include(P => P.ProductBrand).Include(P => P.ProductType).FirstOrDefaultAsync(P => P.Id == id as int?) as TEntity;
            }
            return await _context.Set<TEntity>().FindAsync(id);
        }
        public async Task AddAsync(TEntity entity)
        {
             await _context.AddAsync(entity);
        }
        public  void Update(TEntity entity)
        {
             _context.Update(entity);
        }
        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

    }
}
