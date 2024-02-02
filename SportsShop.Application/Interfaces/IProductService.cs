using System.Collections.Generic;
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


        void DeleteProductParameterRange(int productId);
        void AddProductParameterRange(List<ProductParameter> productParameters);

        ProductDto GetProductDtoById(int productId);
        Product GetProductById(int productId);

    }
}