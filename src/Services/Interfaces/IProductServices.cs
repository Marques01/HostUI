﻿using Models;

namespace Services.Interfaces
{
    public interface IProductServices
    {
        Task CreateAsync(Product model);

        void Update(Product model);

        void Delete(Product model);

        Product GetById(int id);

        Task<IEnumerable<Product>> GetByName(string name);

        Task<IEnumerable<Product>> GetProductsAsync();

        Task<IEnumerable<Product>> GetByPricing(decimal price);

        Task<IEnumerable<CategoryProduct>> GetByCategory(int id);        
    }
}
