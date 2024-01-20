using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Product;
using SportsShop.Infra.Data.Context;

namespace SportsShop.Infra.Data.Repository
{
    public class ProductGroupRepository: IProductGroupRepository
    {
       private readonly SportsShopDbContext _context;

        public ProductGroupRepository(SportsShopDbContext context)
        {
            _context = context;
        }

        public List<ProductGroup> GetAll()
        {
            return _context.ProductGroups
                .Include(x=> x.ParentGroup)
                .Include(x=> x.User)
                .OrderByDescending(x=> x.Id)
                .ToList();
        }

        public List<SelectListItem> GetAllProductGroups(bool checkIsNullParent)

        {
            IQueryable<ProductGroup> query = _context.ProductGroups;


            query = checkIsNullParent ? query.Where(x => x.ParentId == null) : query.Where(x => x.ParentId != null);



            return query
                .OrderByDescending(x => x.Id)
                .Select(r => new SelectListItem()
                {
                    Text = r.Name,
                    Value = r.Id.ToString()
                }).ToList();
        }

        public void AddProductGroup(ProductGroup productGroup)
        {
            _context.Add(productGroup);
            _context.SaveChanges();
        }

        public void UpdateProductGroup(ProductGroup productGroup)
        {
            _context.Update(productGroup);
            _context.SaveChanges();
        }

        public ProductGroup GetProductGroupById(int productGroupId)
        {
            return _context.ProductGroups.Find(productGroupId);
        }

        public bool IsExist(int productGroupId)
        {
            return _context.ProductGroups.Any(x => x.ParentId == productGroupId);
        }
    }
}