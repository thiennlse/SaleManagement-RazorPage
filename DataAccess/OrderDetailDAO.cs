using BusinessObject.DataAccess;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private readonly Ass01Context _context;
        private static OrderDetailDAO _instance;

        public OrderDetailDAO()
        {
            _context = new Ass01Context();
        }

        public static OrderDetailDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OrderDetailDAO();
                }
                return _instance;
            }
        }

        public List<OrderDetail> GetOrderDetails()
        {
            return _context.OrderDetails.ToList();
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return _context.OrderDetails.FirstOrDefault(n => n.OderId.Equals(id));
        }

        public void addOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges(); 
        }

        public void UpdateOrderDetail(int id, OrderDetail _orderDetail)
        {
            OrderDetail orderDetail = GetOrderDetail(id);
            if(orderDetail != null)
            {
                orderDetail.UnitPrice = _orderDetail.UnitPrice;
                orderDetail.Quantity = _orderDetail.Quantity;
                orderDetail.Discount = _orderDetail.Discount;
                _context.OrderDetails.Update(orderDetail);
                _context.SaveChanges();
            }
        }
    }
}
