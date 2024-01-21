using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Products;
using SportsShop.Infra.Data.Context;

namespace SportsShop.Infra.Data.Repository
{
    public class ParameterValueRepository: IParameterValueRepository
    {
       private readonly SportsShopDbContext _context;

        public ParameterValueRepository(SportsShopDbContext context)
        {
            _context = context;
        }

        public List<ParameterValue> GetAll(int parameterId)
        {
            return _context.ParameterValues
                .Where(x => x.ParameterId == parameterId)
                .Include(x => x.User)
                .OrderByDescending(x => x.Id)
                .ToList();
        }

        public void AddParameterValue(ParameterValue parameterValue)
        {
            _context.Add(parameterValue);
            _context.SaveChanges();
        }

        public ParameterValue GetParameterValueById(int parameterValueId)
        {
            return _context.ParameterValues.Find(parameterValueId);
        }

        public void UpdateParameterValue(ParameterValue parameterValue)
        {
            _context.Update(parameterValue);
            _context.SaveChanges();
        }
    }
}