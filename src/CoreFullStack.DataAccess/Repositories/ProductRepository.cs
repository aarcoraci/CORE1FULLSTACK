using CoreFullStack.DataAccess.Base;
using CoreFullStack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreFullStack.Domain.Context;

namespace CoreFullStack.DataAccess.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DomainContext context) : base(context)
        {
        }
    }
}
