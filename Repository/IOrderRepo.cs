using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IOrderRepo 
    {
        public List<Order> GetOrders();
        public Order getOrder(int id);
        public void AddOrder(Order order);
        public void UpdateOrder(int id, Order order);
        public void DeleteOrder(int id);

        public List<Order> getOrderByUserId(int? id);
    }
}
