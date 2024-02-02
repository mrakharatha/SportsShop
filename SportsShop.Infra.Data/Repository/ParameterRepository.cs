using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Products;
using SportsShop.Infra.Data.Context;

namespace SportsShop.Infra.Data.Repository
{
    public class ParameterRepository : IParameterRepository
    {
        private readonly SportsShopDbContext _context;

        public ParameterRepository(SportsShopDbContext context)
        {
            _context = context;
        }

        public List<Parameter> GetAll()
        {
            return _context.Parameters.Include(x => x.User).OrderByDescending(x => x.Id).ToList();
        }

        public void AddParameter(Parameter parameter)
        {
            _context.Add(parameter);
            _context.SaveChanges();
        }

        public Parameter GetParameterById(int parameterId)
        {
            return _context.Parameters.Find(parameterId);
        }

        public void UpdateParameter(Parameter parameter)
        {
            _context.Update(parameter);
            _context.SaveChanges();
        }

        public bool IsExist(int parameterId)
        {
            return _context.ParameterValues.Any(x => x.ParameterId == parameterId);
        }

        public List<SelectListItem> GetAllParameters()
        {
            return _context.Parameters
                .OrderByDescending(x => x.Id)
                .Select(r => new SelectListItem()
                {
                    Text = r.Name,
                    Value = r.Id.ToString()
                }).ToList();
        }
    }
}