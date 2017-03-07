using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFullStack.Domain
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
