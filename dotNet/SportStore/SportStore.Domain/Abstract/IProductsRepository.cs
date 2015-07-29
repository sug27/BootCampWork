using System;
using System.Collections.Generic;
using SportStore.Domain.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Domain.Abstract
{
    public interface IProductsRepository
    {
        IQueryable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int ProductID);
    }
}
