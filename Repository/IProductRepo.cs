using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IProductRepo
    {
        public List<Product> GetProducts();
        public void AddProduct(Product product);
        public Product GetProduct(int id);
        public void DeleteProduct(int id);
        public void UpdateProduct(int id, Product _product);

    }
}
