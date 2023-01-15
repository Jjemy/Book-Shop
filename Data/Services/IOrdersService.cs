using System;
using Ecommerce.Models;

namespace Ecommerce.Data.Services
{
	public interface IOrdersService
	{
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}

