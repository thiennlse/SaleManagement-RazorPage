using BusinessObject.DataAccess;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        private readonly Ass01Context _context;
        private static ProductDAO _instance;

        public ProductDAO()
        {
            _context = new Ass01Context();
        }

        public static ProductDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductDAO();
                }
                return _instance;
            }
        }



        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(n => n.ProductId.Equals(id));
        }

        public void OrderProduct(int id )
        {
            Product product = GetProduct(id);       
            if (product != null)
            {
                
            }
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProduct(id);
            if (product != null)
            {
                _context.Products.Remove(product);  
                _context.SaveChanges();
            }
        }
        
        public void UpdateProduct(int id, Product _product)
        {
            Product product = GetProduct(id);
            if (product != null) 
            {
                product.ProductName = _product.ProductName; 
                product.UnitPrice = _product.UnitPrice;
                product.UnitInStocks = _product.UnitInStocks;
                product.Weight = _product.Weight;
                _context.Products.Update(product);
                _context.SaveChanges();
            }
        }
    }
}
