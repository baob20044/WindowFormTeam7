using StoreManage.DTOs.OrderDetail;
using System;
using System.Collections.Generic;

namespace StoreManage.DTOs.Order
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string EmployeeName { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderExportDateTime { get; set; }
        public string OrderNotice { get; set; }
        public ICollection<OrderDetailDto> OrderDetails { get; set; } = new List<OrderDetailDto>();
        public int TotalAmount { get; set; }
        public decimal Total { get; set; }
        public bool Confirmed { get; set; }
    }
}