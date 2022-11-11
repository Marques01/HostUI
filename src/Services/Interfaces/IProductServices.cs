﻿using Models;

namespace BLL.Repository.Interfaces
{
    public interface IProductRepository
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
