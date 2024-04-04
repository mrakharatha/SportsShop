using System;
using System.Collections.Generic;
using System.Linq;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Dtos.Products;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Products;

namespace SportsShop.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IGlobalService _globalService;
        public ProductService(IProductRepository productRepository, IGlobalService globalService)
        {
            _productRepository = productRepository;
            _globalService = globalService;
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public void AddProduct(ProductDto model)
        {
            var product = new Product()
            {
                ProductGroupId = model.ProductGroupId,
                BrandId = model.BrandId,
                UserId = model.UserId,
                Title = model.Title,
                Status = model.Status,
                ProductImage = _globalService.Upload(model.ProductImage, "ProductImage"),
                PriceProduct = model.PriceProduct,
                BriefDescription = model.BriefDescription,
                Description = model.Description,
                MoreInformation = model.MoreInformation,
            };

            AddProduct(product);
        }

        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public void UpdateProduct(ProductDto model)
        {

            var product = GetProductById(model.ProductId);


            product.ProductGroupId = model.ProductGroupId;
            product.BrandId = model.BrandId;
            product.UserId = model.UserId;
            product.Title = model.Title;
            product.Status = model.Status;
            product.ProductImage = _globalService.Upload(model.ProductImage, "ProductImage", model.PathImage);
            product.PriceProduct = model.PriceProduct;
            product.BriefDescription = model.BriefDescription;
            product.Description = model.Description;
            product.MoreInformation = model.MoreInformation;


            UpdateProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            product.UpdateDate = DateTime.Now;
            _productRepository.UpdateProduct(product);
        }


        public ProductDto GetProductDtoById(int productId)
        {
            return _productRepository.GetProductDtoById(productId);
        }

        public Product GetProductById(int productId)
        {
            return _productRepository.GetProductById(productId);
        }

        public RequestResult DeleteProduct(int productId)
        {
            var product = GetProductById(productId);
            if (product == null) return new RequestResult(false, RequestResultStatusCode.InternalServerError);

            if (IsExist(productId))
                return new RequestResult(false, RequestResultStatusCode.InternalServerError, " کالا در سیستم استفاده شده است!");

            product.DeleteDate = DateTime.Now;
            UpdateProduct(product);
            return new RequestResult(true, RequestResultStatusCode.Success, " کالا با موفقیت حذف شد.");
        }

        public bool IsExist(int productId)
        {
            return _productRepository.IsExist(productId);
        }
    }
}