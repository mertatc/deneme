using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Create(Product entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            var products = new List<Product>()
            {
                new Product() { Id = 1, Name = "SAMSUNG", ImageUrl = "1.jpg", Price = 1000 },
                new Product() { Id = 1, Name = "SAMSUNG", ImageUrl = "1.jpg", Price = 1000 },
                new Product() { Id = 1, Name = "SAMSUNG", ImageUrl = "1.jpg", Price = 1000 },
            };

            return products;
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
