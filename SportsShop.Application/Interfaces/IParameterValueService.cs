using SportsShop.Application.Helpers;
using System.Collections.Generic;
using SportsShop.Domain.Models.Products;

namespace SportsShop.Application.Interfaces
{
    public interface IParameterValueService
    {
        List<ParameterValue> GetAll(int parameterId);
        void AddParameterValue(ParameterValue parameterValue);
        ParameterValue GetParameterValueById(int parameterValueId);
        void UpdateParameterValue(ParameterValue parameterValue);
        RequestResult DeleteParameterValue(int parameterValueId);
    }
}