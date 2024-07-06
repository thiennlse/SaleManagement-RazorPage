using BusinessObject.DataAccess;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        private readonly Ass01Context _context;
        private static OrderDAO _instance;


        public OrderDAO() 
        {
            _context = new Ass01Context();
        }

        public static OrderDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OrderDAO();
                }
                return _instance;
            }
        }

        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public Order getOrder(int id)
        {
            return _context.Orders.FirstOrDefault( n=>n.OrderId.Equals(id));
        }

        

        public List<Order> getOrderByUserId(int? id) 
        {
            return _context.Orders.Where(n => n.MemberId.Equals(id)).ToList();
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
        public void DeleteOrder(int  id)
        {
            Order order = getOrder(id); 
            if(order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
        public void UpdateOrder(int id ,Order order)
        {
            Order _order = getOrder(id);
            if (_order != null)
            {
                order.OrderDate = _order.OrderDate;
                order.Freight = _order.Freight;
                order.RequiredDate = _order.RequiredDate;
                order.ShippedDate = _order.ShippedDate;
                _context.Orders.Update(order);
                _context.SaveChanges();
            }
            
        }
    }
}
