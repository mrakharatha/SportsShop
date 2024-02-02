using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Domain.Models.Products;

namespace SportsShop.Domain.Interfaces
{
    public interface IParameterRepository
    {
        List<Parameter> GetAll();
        void AddParameter(Parameter parameter);
        Parameter GetParameterById(int parameterId);
        void UpdateParameter(Parameter parameter);
        bool IsExist(int parameterId);
        List<SelectListItem> GetAllParameters();

    }
}