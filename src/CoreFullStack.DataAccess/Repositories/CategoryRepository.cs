using CoreFullStack.DataAccess.Base;
using CoreFullStack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreFullStack.Domain.Context;

namespace CoreFullStack.DataAccess.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DomainContext context) : base(context)
        {
        }
    }
}
