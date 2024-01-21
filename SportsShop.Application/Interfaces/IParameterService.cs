using System.Collections.Generic;
using SportsShop.Application.Helpers;
using SportsShop.Domain.Models.Products;

namespace SportsShop.Application.Interfaces
{
    public interface IParameterService
    {
        List<Parameter> GetAll();
        void AddParameter(Parameter parameter);
        Parameter GetParameterById(int parameterId);
        void UpdateParameter(Parameter parameter);
        bool IsExist(int parameterId);
        RequestResult DeleteParameter(int parameterId);
    }
}