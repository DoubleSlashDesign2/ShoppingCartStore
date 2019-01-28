﻿namespace ShoppingCartStore.Services.DataServices
{
    using Microsoft.AspNetCore.Http;
    using ShoppingCartStore.Models;
    using System.Threading.Tasks;

    public interface ICartService
    {
        int? GetProductCountFromSession(ISession session);

        int? GetProductCountFromDb(ISession session);

        Task MigrateSessionProducts(string userEmail, ISession session);

        Task AddToPersistedCart(string productId, string username);

        Task AddToSessionCart(string productId, ISession session);
    }
}
