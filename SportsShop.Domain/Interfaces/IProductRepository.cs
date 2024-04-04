using SportsShop.Domain.Dtos.Products;
using SportsShop.Domain.Models.Products;
using System.Collections.Generic;

namespace SportsShop.Domain.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void AddProduct(Product product);
        ProductDto GetProductDtoById(int productId);
        Product GetProductById(int productId);
        void UpdateProduct(Product product);
        bool IsExist(int productId);
    }
}