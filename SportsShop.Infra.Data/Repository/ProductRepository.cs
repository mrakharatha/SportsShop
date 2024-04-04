using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportsShop.Domain.Dtos.Products;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Products;
using SportsShop.Infra.Data.Context;

namespace SportsShop.Infra.Data.Repository
{
    public class ProductRepository: IProductRepository
    {
     private   readonly SportsShopDbContext _context;

        public ProductRepository(SportsShopDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products
                .Include(x => x.User)
                .Include(x => x.ProductGroup)
                .Include(x => x.Brand)
                .OrderByDescending(x => x.CreateDate)
                .ToList();
        }

        public void AddProduct(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }

        public ProductDto GetProductDtoById(int productId)
        {
            return _context.Products
                .Where(x => x.Id==productId)
                .Select(x => new ProductDto()
                {
                    ProductId = x.Id,
                    ProductGroupId = x.ProductGroupId,
                    BrandId = x.BrandId,
                    UserId = x.UserId,
                    Title = x.Title,
                    Status = x.Status,
                    PathImage = x.ProductImage,
                    PriceProduct = x.PriceProduct,
                    Number = (x.PriceProduct!=null)?x.PriceProduct.Value.ToString("N0"):"",
                    Description = x.Description,
                    BriefDescription = x.BriefDescription,
                    MoreInformation = x.MoreInformation,
                    SendAndReturn = x.SendAndReturn,
                })
                .SingleOrDefault();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public void UpdateProduct(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

        public bool IsExist(int productId)
        {
           return _context.Products.Where(x=> x.Id==productId).Any(x => x.ProductGalleries.Any());
        }
    }
}