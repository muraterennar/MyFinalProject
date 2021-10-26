using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _prodcuts;

        public InMemoryProductDal()
        {
            _prodcuts = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1, ProductName="Bardak",UnitPrice=15,UnitsInStock=20},
                new Product{ProductId=2,CategoryId=2, ProductName="Kamera",UnitPrice=500,UnitsInStock=5},
                new Product{ProductId=3,CategoryId=2, ProductName="Telefon",UnitPrice=2500,UnitsInStock=30},
                new Product{ProductId=4,CategoryId=2, ProductName="Klavye",UnitPrice=50,UnitsInStock=10},
                new Product{ProductId=4,CategoryId=2, ProductName="Mouse",UnitPrice=32,UnitsInStock=4}
            };
        }

        public void Add(Product product)
        {
            _prodcuts.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _prodcuts.SingleOrDefault(p => p.ProductId == product.ProductId);

            _prodcuts.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _prodcuts;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _prodcuts.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProduuctDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _prodcuts.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
        }
    }
}
