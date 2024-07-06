using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderRepo : IOrderRepo
    {
        public void AddOrder(Order order) => OrderDAO.Instance.AddOrder(order);

        public void DeleteOrder(int id) => OrderDAO.Instance.DeleteOrder(id);

        public Order getOrder(int id) =>OrderDAO.Instance.getOrder(id);

        public List<Order> getOrderByUserId(int? id)=> OrderDAO.Instance.getOrderByUserId(id);

        public List<Order> GetOrders() => OrderDAO.Instance.GetOrders();

        public void UpdateOrder(int id , Order order) => OrderDAO.Instance.UpdateOrder(id, order);
    }
}
