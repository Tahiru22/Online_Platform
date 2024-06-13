namespace Online_Platform.Services.Models.Orders
{
    using Online_Platform.Mapping;
    using Online_Platform.Models;
    using System;
    using System.Collections.Generic;
    public class OrderListingServiceModel : IMapFrom<Order>
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalPrice { get; set; }

        public PaymentType PaymentMethod { get; set; }

        public Status Status { get; set; }

        public string InvoiceId { get; set; }

        public IEnumerable<OrderItemServiceModel> OrderItems { get; set; }
    }
}
