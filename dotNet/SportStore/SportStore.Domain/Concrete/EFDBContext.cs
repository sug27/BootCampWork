using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SportStore.Domain.Entities;
using System.Data.Entity;
using System.Threading.Tasks;

namespace SportStore.Domain.Concrete
{
    class EFDBContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
