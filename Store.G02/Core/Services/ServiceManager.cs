using AutoMapper;
using Domain.Contracts;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager(IUnitOfWork unitofwork, IMapper mapper) : IServiceManager
    {
        public IProductService productService { get; } = new ProductService(unitofwork , mapper);
    }
}
