﻿namespace Online_Platform.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Online_Platform.Models;
    using Online_Platform.Services.Models.Orders;
    using Online_Platform.Services.Models.ShoppingCart;

    public interface IOrderService
    {
        Task<IEnumerable<OrderListingServiceModel>> AllByUserAsync(string userId);

        Task<bool> CanBeDeletedAsync(int id, string userId);

        Task<int> CreateAsync(string userId, PaymentType paymentMethod, decimal totalPrice, IEnumerable<CartItemDetailsServiceModel> cartItems);

        Task<bool> ExistsAsync(int id, string userId);

        Task<OrderListingServiceModel> GetByIdForUserAsync(int id, string userId);

        Task<OrderListingServiceModel> GetInvoiceAsync(string invoiceId);

        Task<bool> RemoveAsync(int id, string userId);
    }
}
