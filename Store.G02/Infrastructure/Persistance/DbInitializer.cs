using Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;

using System.IO;
using System.Text.Json;
using Domain.Models;
using Persistance.Date;
using System.Reflection.Emit;

namespace Persistance
{
    public class DbInitializer : IDbInitializer
    {
        private readonly StoreDbContext _context;

        public DbInitializer(StoreDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            try
            {
                // Ensure Database is created and migrations applied
                if (_context.Database.GetPendingMigrations().Any())
                {
                    await _context.Database.MigrateAsync();
                }

                // Seed Product Types
                if (!_context.ProductTypes.Any())
                {
                    var typesData = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Date\Seeding\types.json");
                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    if (types is not null && types.Any())
                    {
                        await _context.ProductTypes.AddRangeAsync(types);
                        await _context.SaveChangesAsync();
                    }
                }

                // Seed Product Brands
                if (!_context.ProductBrands.Any())
                {
                    var brandData = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Date\Seeding\brands.json");
                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandData);

                    if (brands is not null && brands.Any())
                    {
                        await _context.ProductBrands.AddRangeAsync(brands);
                        await _context.SaveChangesAsync();
                    }
                }

                // Seed Products
                if (!_context.Products.Any())
                {
                    var productData = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Date\Seeding\products.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(productData);


                    if (products is not null && products.Any())
                    {
                        await _context.Products.AddRangeAsync(products);
                        await _context.SaveChangesAsync();
                    }

                }

            }
            catch (Exception)
            {
                throw;
            }
       
        }
    }
}
