using System.Collections.Generic;
using SportsShop.Application.Helpers;
using SportsShop.Domain.Dtos.Products;
using SportsShop.Domain.Models.Products;

namespace SportsShop.Application.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        void AddProduct(ProductDto model);
        void AddProduct(Product product);

        void UpdateProduct(ProductDto model);
        void UpdateProduct(Product product);


        ProductDto GetProductDtoById(int productId);
        Product GetProductById(int productId);

        RequestResult DeleteProduct(int productId);
        bool IsExist(int productId);
    }
}