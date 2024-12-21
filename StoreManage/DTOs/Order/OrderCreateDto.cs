using System.Collections.Generic;
using StoreManage.DTOs.OrderDetail;

namespace StoreManage.DTOs.Order
{
    public class OrderCreateDto
    {
        public int OrderId { get; set; }
        public int EmployeeId { get; set; }
        public string OrderNotice { get; set; }
        public ICollection<OrderDetailCreateDto> OrderDetails { get; set; }
    }
}