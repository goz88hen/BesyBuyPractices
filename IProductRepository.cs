using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyPractices
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProducts();
        public Products GetByProduct(int id);
        public void UpdateProduct(Products product);
        public void  DeleteProduct(int id);
            
    }
}
