using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal //dan implement ediyoruz
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product GatOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>()
            {
                new Product() { Id = 1, Name = "SAMSUNG", ImageUrl = "1.jpg", Price = 1000 },
                new Product() { Id = 1, Name = "SAMSUNG", ImageUrl = "1.jpg", Price = 1000 },
                new Product() { Id = 1, Name = "SAMSUNG", ImageUrl = "1.jpg", Price = 1000 },
            };

            return products;
        }

        public Product GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
