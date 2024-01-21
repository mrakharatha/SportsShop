using SportsShop.Domain.Models.Products;
using System.Collections.Generic;

namespace SportsShop.Domain.Interfaces
{
    public interface IParameterValueRepository
    {
        List<ParameterValue> GetAll(int parameterId);

        void AddParameterValue(ParameterValue parameterValue);
        ParameterValue GetParameterValueById(int parameterValueId);
        void UpdateParameterValue(ParameterValue parameterValue);
    }
}