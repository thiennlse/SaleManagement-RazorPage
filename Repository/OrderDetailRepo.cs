using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderDetailRepo : IOrderDetailRepo
    {
        public void addOrderDetail(OrderDetail orderDetail)=>OrderDetailDAO.Instance.addOrderDetail(orderDetail);

        public OrderDetail GetOrderDetail(int id)=> OrderDetailDAO.Instance.GetOrderDetail(id);

        public List<OrderDetail> GetOrderDetails()=>OrderDetailDAO.Instance.GetOrderDetails();

        public void UpdateOrderDetail(int id, OrderDetail _orderDetail)=>OrderDetailDAO.Instance.UpdateOrderDetail(id, _orderDetail);
    }
}
