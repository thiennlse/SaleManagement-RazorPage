using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepo : IProductRepo
    {
        public void AddProduct(Product product) => ProductDAO.Instance.AddProduct(product);

        public void DeleteProduct(int id)=> ProductDAO.Instance.DeleteProduct(id);

        public Product GetProduct(int id)=> ProductDAO.Instance.GetProduct(id);

        public List<Product> GetProducts()=> ProductDAO.Instance.GetProducts();

        public void UpdateProduct(int id, Product _product)=> ProductDAO.Instance.UpdateProduct(id, _product);

    }
}
