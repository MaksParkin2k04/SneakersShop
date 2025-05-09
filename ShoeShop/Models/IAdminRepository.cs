﻿using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace ShoeShop.Models {
    public interface IAdminRepository {
        Task<Product?> GetProduct(Guid productId);
        Task<IReadOnlyList<Product>> GetProducts(ProductSorting sorting, IsSaleFilter filter, string searchName, int start, int count);
        Task<int> ProductCount(IsSaleFilter filter, string partProductName);

        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task RemoveProduct(Guid productId);

        Task<IReadOnlyList<Order>> GetOrders(OrderStatusFilter filter, OrderSorting sorting, int start, int count);
        Task<int> OrderCount(OrderStatusFilter filter);
    }
}
