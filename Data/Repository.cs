﻿
namespace OnlineMarket.Data
{
    public interface Repository
    {
        Task<Product> GetProduct(int id);
        Task<List<Product>> GetProducts();
        Task<List<Product>> FindAsyn(Expression<Func<Product, bool>> predicate);
        Task AddAsync(Product entity);
        Task UpdateAsync(Product entity);
        Task DeleteAsync(Product entity);
    }
}
