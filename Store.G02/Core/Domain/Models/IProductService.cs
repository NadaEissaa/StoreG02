using Domain.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductResultDto>> GetAllProductsAsync();

        Task<IEnumerable<Product>> GetProductByIdAsync();

        //by id
        Task<BrandResultDto> GetAllBrandsAsync();
        //brands
        Task<IEnumerable<TypeResultDto>> GetAllTypesAsync();
    }
}
