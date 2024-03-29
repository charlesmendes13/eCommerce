﻿using Basket.Domain.Models;

namespace Basket.Domain.Interfaces.Repositories
{
    public interface IItemRepository
    {
        Task<Item> GetByIdAsync(int id);
        void Update(Item item);
    }
}
