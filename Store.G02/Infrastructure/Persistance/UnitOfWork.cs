using Domain.Contracts;
using Domain.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Persistance.Date;
using Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly StoreDbContext _context;
        private readonly Dictionary<string, object> _repositories;
=
        public UnitOfWork(StoreDbContext context)
        {
            _context = context;
            _repositories = new Dictionary<string, object>();
        }
        public IGenericRepository<TEntity, Tkey> GetRepository<TEntity, Tkey>() where TEntity : BaseEntity<Tkey>
        {

            var type = typeof(TEntity).Name;
            if (!_repositories.ContainsKey(type))
            {
                var repositoy = new GenericRepository<TEntity, Tkey>(_context);
                _repositories.Add(type, repositoy);
            }
            return (IGenericRepository < TEntity, Tkey >) _repositories[type];

        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
