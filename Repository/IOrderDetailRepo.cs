using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IOrderDetailRepo
    {
        public List<OrderDetail> GetOrderDetails();
        public OrderDetail GetOrderDetail(int id);
        public void addOrderDetail(OrderDetail orderDetail);
        public void UpdateOrderDetail(int id, OrderDetail _orderDetail);

    }
}
